using System.Data.SqlClient;

namespace KutuphaneYonetimSistemi
{
    public partial class FormGiris : Form
    {
        FormKitaplar formKitaplar;

        public FormGiris()
        {
            InitializeComponent();
        }

        SqlConnection connection = new(@"Data Source=DESKTOP-2I5MOLK\SQLEXPRESS;Initial Catalog=DbYTAKutuphane;Integrated Security=True");

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            string sifre = "";

            try
            {
                connection.Open();
                SqlCommand sqlKomut = new SqlCommand("SELECT Sifre FROM TABLEKutuphaneYoneticileri WHERE KullaniciAdi = @p1", connection);
                sqlKomut.Parameters.AddWithValue("@p1", textBoxKullaniciAdi.Text);
                SqlDataReader sqlDataReader = sqlKomut.ExecuteReader();


                while (sqlDataReader.Read())
                {
                    sifre = sqlDataReader[0].ToString();
                }
                if (!string.IsNullOrEmpty(sifre) && sifre == textBoxSifre.Text)
                {
                    FormGiris.ActiveForm.Hide();
                    formKitaplar = new FormKitaplar();
                    formKitaplar.Show();

                }
                else
                {
                    MessageBox.Show("Kullanýcý Adý veya Þifre Hatalý");
                    textBoxKullaniciAdi.Text = "";
                    textBoxSifre.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Baðlantý Hatasý" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}