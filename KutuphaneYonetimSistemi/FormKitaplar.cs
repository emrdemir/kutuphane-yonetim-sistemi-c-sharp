using System.Data;
using System.Data.SqlClient;

namespace KutuphaneYonetimSistemi
{
    public partial class FormKitaplar : Form
    {
        SqlConnection connection = new(@"Data Source=DESKTOP-2I5MOLK\SQLEXPRESS;Initial Catalog=DbYTAKutuphane;Integrated Security=True");
        public FormKitaplar()
        {
            InitializeComponent();
        }
        private void buttonKitapEkle_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO TableKitaplar(KitapAdi, YazarAdi, YazarSoyadi, ISBN, Durum, KitapTurKodu) VALUES (@P1, @P2, @P3, @P4, @P5, @P6)", connection);
                sqlCommand.Parameters.AddWithValue("@P1", textBoxKitapAdi.Text);
                sqlCommand.Parameters.AddWithValue("@P2", textBoxYazarAdi.Text);
                sqlCommand.Parameters.AddWithValue("@P3", textBoxYazarSoyad.Text);
                sqlCommand.Parameters.AddWithValue("@P4", textBoxISBN.Text);
                sqlCommand.Parameters.AddWithValue("@P5", true);
                sqlCommand.Parameters.AddWithValue("@P6", textBoxKitapTurKod.Text);

                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitap Eklenirken Hata oluştu, lütfen veritabanını kontrol ediniz!");
            }
            finally
            {
                connection.Close();
            }
            verileriGoster();

        }

        private void verileriGoster()
        {

            try
            {
                string q = "SELECT * FROM TableKitaplar";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(q, connection);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridViewKitaplar.DataSource = dt;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void FormKitaplar_Load(object sender, EventArgs e)
        {
            verileriGoster();

        }

        private void dataGridViewKitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelGecikmeBedeli.Text = "0";
            int secilenSatir = dataGridViewKitaplar.SelectedCells[0].RowIndex;
            labelID.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[0].Value.ToString();
            textBoxKitapAdi.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[1].Value.ToString();
            textBoxYazarAdi.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[2].Value.ToString();
            textBoxYazarSoyad.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[3].Value.ToString();
            textBoxISBN.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[4].Value.ToString();
            textBoxKitapTurKod.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[8].Value.ToString();
            textBoxOduncAlan.Text = dataGridViewKitaplar.Rows[secilenSatir].Cells[6].Value.ToString();
            if (dataGridViewKitaplar.Rows[secilenSatir].Cells[7].Value != DBNull.Value)

                dateTimePickerOduncAlmaTarihi.Value = (DateTime)dataGridViewKitaplar.Rows[secilenSatir].Cells[7].Value;
        }

        private void buttonKitapBilgiGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("UPDATE TableKitaplar SET KitapAdi = @P1, YazarAdi=@P2, YazarSoyadi=@P3, ISBN=@P4, KitapTurkodu=@P5 WHERE ID = @P6", connection);
                sqlCommand.Parameters.AddWithValue("@P1", textBoxKitapAdi.Text);
                sqlCommand.Parameters.AddWithValue("@P2", textBoxYazarAdi.Text);
                sqlCommand.Parameters.AddWithValue("@P3", textBoxYazarSoyad.Text);
                sqlCommand.Parameters.AddWithValue("@P4", textBoxISBN.Text);
                sqlCommand.Parameters.AddWithValue("@P5", textBoxKitapTurKod.Text);
                sqlCommand.Parameters.AddWithValue("@P6", labelID.Text);

                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitap güncellenirken hata oluştu ! " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            verileriGoster();
        }

        private void buttonOduncVer_Click(object sender, EventArgs e)
        {
            if (labelID.Text != "-")
            {
                try
                {
                    connection.Open();
                    SqlCommand sqlCommand = new SqlCommand("UPDATE TableKitaplar SET OduncAlan = @P1, OduncAlmaTarihi=@P2, Durum=@P3 WHERE ID = @P4", connection);
                    sqlCommand.Parameters.AddWithValue("@P1", textBoxOduncAlan.Text);
                    sqlCommand.Parameters.Add("@P2", SqlDbType.Date).Value = dateTimePickerOduncAlmaTarihi.Value.Date;
                    sqlCommand.Parameters.AddWithValue("@P3", "False");
                    sqlCommand.Parameters.AddWithValue("@P4", labelID.Text);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kitap ödünç işlemi sırasında hata oluştu ! " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }

                verileriGoster();
            }
            else
            {
                MessageBox.Show("Lütfen Listeden Bir Kitap Seçiniz !");
            }
        }

        private void buttonGecikmeBedeliHesapla_Click(object sender, EventArgs e)
        {
            if (labelID.Text != "-")
            {
                DateTime dateTime = DateTime.Now;
                int gunFarki = (int)(dateTime - dateTimePickerOduncAlmaTarihi.Value.Date).TotalDays;

                if (gunFarki > 10)
                {
                    int gecikmeBedeli = (gunFarki - 10) * 1;
                    labelGecikmeBedeli.Text = gecikmeBedeli.ToString();
                }
            }

        }

        private void buttonKitabiIadeEt_Click(object sender, EventArgs e)
        {
            if (labelID.Text != "-")
            {
                try
                {
                    connection.Open();
                    SqlCommand sqlCommand = new SqlCommand("UPDATE TableKitaplar SET OduncAlan = @P1, OduncAlmaTarihi=@P2, Durum=@P3 WHERE ID = @P4", connection);
                    sqlCommand.Parameters.AddWithValue("@P1", "");
                    sqlCommand.Parameters.Add("@P2", SqlDbType.Date).Value = DBNull.Value;
                    sqlCommand.Parameters.AddWithValue("@P3", "True");
                    sqlCommand.Parameters.AddWithValue("@P4", labelID.Text);
                    sqlCommand.ExecuteNonQuery();
                    textBoxOduncAlan.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kitap iade işlemi sırasında hata oluştu ! " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }

                verileriGoster();
            }
            else
            {
                MessageBox.Show("Lütfen Listeden Bir Kitap Seçiniz !");
            }
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            metinKutularniTemizle();
        }
        public void metinKutularniTemizle()
        {
            labelID.Text = "-";
            textBoxKitapAdi.Text = " ";
            textBoxYazarAdi.Text = "";
            textBoxYazarSoyad.Text = " ";
            textBoxISBN.Text = " ";
            textBoxKitapTurKod.Text = " ";
            textBoxOduncAlan.Text = " ";
        }

        private void buttonArama_Click(object sender, EventArgs e)
        {
            aramaSonuclariniGoster();

        }
        private void aramaSonuclariniGoster()
        {

            try
            {
                string q = "SELECT * FROM TableKitaplar WHERE KitapAdi LIKE '%" + textBoxKitapAdi.Text + "%' AND YazarAdi LIKE '%" + textBoxYazarAdi.Text + "%' AND YazarSoyadi LIKE '%" + textBoxYazarSoyad.Text + "%' AND ISBN LIKE '%" + textBoxISBN.Text + "%' AND KitapTurKodu LIKE '%" + textBoxYazarAdi.Text + "%' AND OduncAlan LIKE '%" + textBoxOduncAlan.Text + "%'";


                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(q, connection);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridViewKitaplar.DataSource = dt;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonTumKitaplariGoster_Click(object sender, EventArgs e)
        {
            verileriGoster();
        }

        private void buttonKitapSil_Click(object sender, EventArgs e)
        {
            if (labelID.Text == "-" || labelID.Text == "")
            {
                MessageBox.Show("Lütfen Listeden Bir Kitap Seçiniz !");
            }
            else
            {
                try
                {
                    connection.Open();
                    SqlCommand sqlCommand = new SqlCommand("DELETE FROM TableKitaplar WHERE ID = @P1", connection);
                    sqlCommand.Parameters.AddWithValue("@P1", labelID.Text);
                    sqlCommand.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kitap silme işlemi sırasında hata oluştu ! " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }

                verileriGoster();
                metinKutularniTemizle();
            }
        }
        private void FormKitaplar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
