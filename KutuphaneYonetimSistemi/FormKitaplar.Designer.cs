namespace KutuphaneYonetimSistemi
{
    partial class FormKitaplar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKitaplar));
            groupBox1 = new GroupBox();
            groupBox6 = new GroupBox();
            buttonTumKitaplariGoster = new Button();
            buttonKitapBilgiGuncelle = new Button();
            buttonKitapEkle = new Button();
            groupBox5 = new GroupBox();
            buttonKitapSil = new Button();
            buttonArama = new Button();
            buttonTemizle = new Button();
            textBoxKitapTurKod = new TextBox();
            textBoxISBN = new TextBox();
            textBoxYazarSoyad = new TextBox();
            textBoxYazarAdi = new TextBox();
            textBoxKitapAdi = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            labelID = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            buttonOduncVer = new Button();
            dateTimePickerOduncAlmaTarihi = new DateTimePicker();
            textBoxOduncAlan = new TextBox();
            label9 = new Label();
            label8 = new Label();
            groupBox3 = new GroupBox();
            buttonKitabiIadeEt = new Button();
            label11 = new Label();
            labelGecikmeBedeli = new Label();
            buttonGecikmeBedeliHesapla = new Button();
            label10 = new Label();
            groupBox4 = new GroupBox();
            dataGridViewKitaplar = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKitaplar).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox6);
            groupBox1.Controls.Add(groupBox5);
            groupBox1.Controls.Add(textBoxKitapTurKod);
            groupBox1.Controls.Add(textBoxISBN);
            groupBox1.Controls.Add(textBoxYazarSoyad);
            groupBox1.Controls.Add(textBoxYazarAdi);
            groupBox1.Controls.Add(textBoxKitapAdi);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(labelID);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(32, 36);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(733, 609);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kitap Kayıt ve Güncelleme";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(buttonTumKitaplariGoster);
            groupBox6.Controls.Add(buttonKitapBilgiGuncelle);
            groupBox6.Controls.Add(buttonKitapEkle);
            groupBox6.Location = new Point(20, 375);
            groupBox6.Margin = new Padding(4);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(4);
            groupBox6.Size = new Size(584, 90);
            groupBox6.TabIndex = 19;
            groupBox6.TabStop = false;
            groupBox6.Text = "Kitap Düzenleme İşlemleri";
            // 
            // buttonTumKitaplariGoster
            // 
            buttonTumKitaplariGoster.Location = new Point(407, 20);
            buttonTumKitaplariGoster.Margin = new Padding(4);
            buttonTumKitaplariGoster.Name = "buttonTumKitaplariGoster";
            buttonTumKitaplariGoster.Size = new Size(172, 63);
            buttonTumKitaplariGoster.TabIndex = 16;
            buttonTumKitaplariGoster.Text = "Türm Kitapları Göster";
            buttonTumKitaplariGoster.UseVisualStyleBackColor = true;
            buttonTumKitaplariGoster.Click += buttonTumKitaplariGoster_Click;
            // 
            // buttonKitapBilgiGuncelle
            // 
            buttonKitapBilgiGuncelle.Location = new Point(29, 23);
            buttonKitapBilgiGuncelle.Margin = new Padding(4);
            buttonKitapBilgiGuncelle.Name = "buttonKitapBilgiGuncelle";
            buttonKitapBilgiGuncelle.Size = new Size(172, 60);
            buttonKitapBilgiGuncelle.TabIndex = 13;
            buttonKitapBilgiGuncelle.Text = "Kitap Bilgi Güncelle";
            buttonKitapBilgiGuncelle.UseVisualStyleBackColor = true;
            buttonKitapBilgiGuncelle.Click += buttonKitapBilgiGuncelle_Click;
            // 
            // buttonKitapEkle
            // 
            buttonKitapEkle.Location = new Point(218, 23);
            buttonKitapEkle.Margin = new Padding(4);
            buttonKitapEkle.Name = "buttonKitapEkle";
            buttonKitapEkle.Size = new Size(172, 60);
            buttonKitapEkle.TabIndex = 12;
            buttonKitapEkle.Text = "Yeni Kitap Ekle";
            buttonKitapEkle.UseVisualStyleBackColor = true;
            buttonKitapEkle.Click += buttonKitapEkle_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(buttonKitapSil);
            groupBox5.Controls.Add(buttonArama);
            groupBox5.Controls.Add(buttonTemizle);
            groupBox5.Location = new Point(20, 500);
            groupBox5.Margin = new Padding(4);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(4);
            groupBox5.Size = new Size(584, 83);
            groupBox5.TabIndex = 18;
            groupBox5.TabStop = false;
            groupBox5.Text = "Arama";
            // 
            // buttonKitapSil
            // 
            buttonKitapSil.Location = new Point(405, 22);
            buttonKitapSil.Margin = new Padding(4);
            buttonKitapSil.Name = "buttonKitapSil";
            buttonKitapSil.Size = new Size(172, 51);
            buttonKitapSil.TabIndex = 17;
            buttonKitapSil.Text = "Kitap Sil";
            buttonKitapSil.UseVisualStyleBackColor = true;
            buttonKitapSil.Click += buttonKitapSil_Click;
            // 
            // buttonArama
            // 
            buttonArama.Location = new Point(216, 22);
            buttonArama.Margin = new Padding(4);
            buttonArama.Name = "buttonArama";
            buttonArama.Size = new Size(172, 51);
            buttonArama.TabIndex = 15;
            buttonArama.Text = "Arama";
            buttonArama.UseVisualStyleBackColor = true;
            buttonArama.Click += buttonArama_Click;
            // 
            // buttonTemizle
            // 
            buttonTemizle.Location = new Point(27, 22);
            buttonTemizle.Margin = new Padding(4);
            buttonTemizle.Name = "buttonTemizle";
            buttonTemizle.Size = new Size(172, 51);
            buttonTemizle.TabIndex = 14;
            buttonTemizle.Text = "Temizle";
            buttonTemizle.UseVisualStyleBackColor = true;
            buttonTemizle.Click += buttonTemizle_Click;
            // 
            // textBoxKitapTurKod
            // 
            textBoxKitapTurKod.Font = new Font("Sitka Small", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxKitapTurKod.Location = new Point(211, 326);
            textBoxKitapTurKod.Margin = new Padding(4);
            textBoxKitapTurKod.Name = "textBoxKitapTurKod";
            textBoxKitapTurKod.Size = new Size(351, 30);
            textBoxKitapTurKod.TabIndex = 11;
            // 
            // textBoxISBN
            // 
            textBoxISBN.Font = new Font("Sitka Small", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxISBN.Location = new Point(211, 269);
            textBoxISBN.Margin = new Padding(4);
            textBoxISBN.Name = "textBoxISBN";
            textBoxISBN.Size = new Size(351, 30);
            textBoxISBN.TabIndex = 10;
            // 
            // textBoxYazarSoyad
            // 
            textBoxYazarSoyad.Font = new Font("Sitka Small", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxYazarSoyad.Location = new Point(211, 213);
            textBoxYazarSoyad.Margin = new Padding(4);
            textBoxYazarSoyad.Name = "textBoxYazarSoyad";
            textBoxYazarSoyad.Size = new Size(351, 30);
            textBoxYazarSoyad.TabIndex = 9;
            // 
            // textBoxYazarAdi
            // 
            textBoxYazarAdi.Font = new Font("Sitka Small", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxYazarAdi.Location = new Point(211, 155);
            textBoxYazarAdi.Margin = new Padding(4);
            textBoxYazarAdi.Name = "textBoxYazarAdi";
            textBoxYazarAdi.Size = new Size(351, 30);
            textBoxYazarAdi.TabIndex = 8;
            // 
            // textBoxKitapAdi
            // 
            textBoxKitapAdi.Font = new Font("Sitka Small", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxKitapAdi.Location = new Point(211, 97);
            textBoxKitapAdi.Margin = new Padding(4);
            textBoxKitapAdi.Name = "textBoxKitapAdi";
            textBoxKitapAdi.Size = new Size(351, 30);
            textBoxKitapAdi.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Small", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(20, 213);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(138, 26);
            label7.TabIndex = 6;
            label7.Text = "Yazar Soyad :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Small", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(20, 272);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(70, 26);
            label6.TabIndex = 5;
            label6.Text = "ISBN :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Small", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(20, 155);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(112, 26);
            label5.TabIndex = 4;
            label5.Text = "Yazar Adı :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(20, 326);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(163, 26);
            label4.TabIndex = 3;
            label4.Text = "Kitap Tür Kodu :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(20, 97);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(108, 26);
            label3.TabIndex = 2;
            label3.Text = "Kitap Adı :";
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Font = new Font("Sitka Small", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelID.Location = new Point(211, 47);
            labelID.Margin = new Padding(4, 0, 4, 0);
            labelID.Name = "labelID";
            labelID.Size = new Size(19, 26);
            labelID.TabIndex = 1;
            labelID.Text = "-";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Small", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(20, 47);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 26);
            label1.TabIndex = 0;
            label1.Text = "Kitap ID ;";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonOduncVer);
            groupBox2.Controls.Add(dateTimePickerOduncAlmaTarihi);
            groupBox2.Controls.Add(textBoxOduncAlan);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(787, 36);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(355, 609);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kitap Ödünç Alma";
            // 
            // buttonOduncVer
            // 
            buttonOduncVer.Location = new Point(97, 201);
            buttonOduncVer.Margin = new Padding(4);
            buttonOduncVer.Name = "buttonOduncVer";
            buttonOduncVer.Size = new Size(172, 60);
            buttonOduncVer.TabIndex = 14;
            buttonOduncVer.Text = "Kitap Ödünç Ver";
            buttonOduncVer.UseVisualStyleBackColor = true;
            buttonOduncVer.Click += buttonOduncVer_Click;
            // 
            // dateTimePickerOduncAlmaTarihi
            // 
            dateTimePickerOduncAlmaTarihi.Location = new Point(125, 101);
            dateTimePickerOduncAlmaTarihi.Margin = new Padding(4);
            dateTimePickerOduncAlmaTarihi.Name = "dateTimePickerOduncAlmaTarihi";
            dateTimePickerOduncAlmaTarihi.Size = new Size(223, 30);
            dateTimePickerOduncAlmaTarihi.TabIndex = 9;
            // 
            // textBoxOduncAlan
            // 
            textBoxOduncAlan.Font = new Font("Sitka Small", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxOduncAlan.Location = new Point(130, 47);
            textBoxOduncAlan.Margin = new Padding(4);
            textBoxOduncAlan.Name = "textBoxOduncAlan";
            textBoxOduncAlan.Size = new Size(217, 30);
            textBoxOduncAlan.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Sitka Small", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(7, 105);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(74, 26);
            label9.TabIndex = 2;
            label9.Text = "Tarih :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Small", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(7, 47);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(129, 26);
            label8.TabIndex = 1;
            label8.Text = "Ödünç Alan :";
            // 
            // groupBox3
            // 
            groupBox3.AutoSize = true;
            groupBox3.Controls.Add(buttonKitabiIadeEt);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(labelGecikmeBedeli);
            groupBox3.Controls.Add(buttonGecikmeBedeliHesapla);
            groupBox3.Controls.Add(label10);
            groupBox3.Location = new Point(1170, 36);
            groupBox3.Margin = new Padding(4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4);
            groupBox3.Size = new Size(338, 609);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kitap İade";
            // 
            // buttonKitabiIadeEt
            // 
            buttonKitabiIadeEt.Location = new Point(86, 405);
            buttonKitabiIadeEt.Margin = new Padding(4);
            buttonKitabiIadeEt.Name = "buttonKitabiIadeEt";
            buttonKitabiIadeEt.Size = new Size(172, 60);
            buttonKitabiIadeEt.TabIndex = 16;
            buttonKitabiIadeEt.Text = "Kitap İade Et";
            buttonKitabiIadeEt.UseVisualStyleBackColor = true;
            buttonKitabiIadeEt.Click += buttonKitabiIadeEt_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Sitka Small", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(292, 51);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(35, 26);
            label11.TabIndex = 15;
            label11.Text = "TL";
            // 
            // labelGecikmeBedeli
            // 
            labelGecikmeBedeli.AutoSize = true;
            labelGecikmeBedeli.Font = new Font("Sitka Small", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            labelGecikmeBedeli.Location = new Point(220, 52);
            labelGecikmeBedeli.Margin = new Padding(4, 0, 4, 0);
            labelGecikmeBedeli.Name = "labelGecikmeBedeli";
            labelGecikmeBedeli.Size = new Size(24, 26);
            labelGecikmeBedeli.TabIndex = 14;
            labelGecikmeBedeli.Text = "0";
            // 
            // buttonGecikmeBedeliHesapla
            // 
            buttonGecikmeBedeliHesapla.Location = new Point(86, 189);
            buttonGecikmeBedeliHesapla.Margin = new Padding(4);
            buttonGecikmeBedeliHesapla.Name = "buttonGecikmeBedeliHesapla";
            buttonGecikmeBedeliHesapla.Size = new Size(172, 60);
            buttonGecikmeBedeliHesapla.TabIndex = 13;
            buttonGecikmeBedeliHesapla.Text = "Gecikme Bedeli Hesapla";
            buttonGecikmeBedeliHesapla.UseVisualStyleBackColor = true;
            buttonGecikmeBedeliHesapla.Click += buttonGecikmeBedeliHesapla_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Sitka Small", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(32, 52);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(162, 26);
            label10.TabIndex = 2;
            label10.Text = "Gecikme Bedeli :";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridViewKitaplar);
            groupBox4.Dock = DockStyle.Bottom;
            groupBox4.Location = new Point(0, 622);
            groupBox4.Margin = new Padding(4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4);
            groupBox4.Size = new Size(1535, 345);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Kitap Listesi";
            // 
            // dataGridViewKitaplar
            // 
            dataGridViewKitaplar.AllowUserToAddRows = false;
            dataGridViewKitaplar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewKitaplar.BackgroundColor = SystemColors.ButtonFace;
            dataGridViewKitaplar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewKitaplar.Dock = DockStyle.Fill;
            dataGridViewKitaplar.Location = new Point(4, 27);
            dataGridViewKitaplar.Margin = new Padding(4);
            dataGridViewKitaplar.Name = "dataGridViewKitaplar";
            dataGridViewKitaplar.RowHeadersWidth = 51;
            dataGridViewKitaplar.RowTemplate.Height = 29;
            dataGridViewKitaplar.Size = new Size(1527, 314);
            dataGridViewKitaplar.TabIndex = 0;
            dataGridViewKitaplar.CellClick += dataGridViewKitaplar_CellClick;
            // 
            // FormKitaplar
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSalmon;
            ClientSize = new Size(1535, 967);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "FormKitaplar";
            Text = "Kütüphane Kitap Yönetim Sistemi";
            WindowState = FormWindowState.Maximized;
            FormClosing += FormKitaplar_FormClosing;
            Load += FormKitaplar_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewKitaplar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label labelID;
        private Label label1;
        private TextBox textBoxKitapAdi;
        private TextBox textBoxKitapTurKod;
        private TextBox textBoxISBN;
        private TextBox textBoxYazarSoyad;
        private TextBox textBoxYazarAdi;
        private Button buttonKitapBilgiGuncelle;
        private Button buttonKitapEkle;
        private GroupBox groupBox4;
        private DataGridView dataGridViewKitaplar;
        private TextBox textBoxOduncAlan;
        private Label label9;
        private Label label8;
        private DateTimePicker dateTimePickerOduncAlmaTarihi;
        private Label labelGecikmeBedeli;
        private Button buttonGecikmeBedeliHesapla;
        private Label label10;
        private Button buttonOduncVer;
        private Button buttonKitabiIadeEt;
        private Label label11;
        private Panel panel1;
        private Button buttonArama;
        private Button buttonTemizle;
        private Button buttonTumKitaplariGoster;
        private GroupBox groupBox6;
        private GroupBox groupBox5;
        private Button buttonKitapSil;
    }
}