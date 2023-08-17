namespace KutuphaneYonetimSistemi
{
    partial class FormGiris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiris));
            panel1 = new Panel();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel4 = new Panel();
            pictureBox3 = new PictureBox();
            buttonGiris = new Button();
            textBoxSifre = new TextBox();
            textBoxKullaniciAdi = new TextBox();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(1163, 652);
            panel1.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(buttonGiris);
            panel3.Controls.Add(textBoxSifre);
            panel3.Controls.Add(textBoxKullaniciAdi);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(647, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(516, 652);
            panel3.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(197, 62);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(82, 63);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(33, 282);
            label2.Name = "label2";
            label2.Size = new Size(94, 22);
            label2.TabIndex = 5;
            label2.Text = "Şifre :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(33, 141);
            label1.Name = "label1";
            label1.Size = new Size(190, 22);
            label1.TabIndex = 4;
            label1.Text = "Kullanıcı Adı :";
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox3);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(516, 56);
            panel4.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Right;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(436, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(80, 56);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // buttonGiris
            // 
            buttonGiris.BackColor = Color.Gold;
            buttonGiris.FlatStyle = FlatStyle.Flat;
            buttonGiris.ForeColor = Color.FromArgb(64, 64, 0);
            buttonGiris.Location = new Point(33, 429);
            buttonGiris.Name = "buttonGiris";
            buttonGiris.Size = new Size(390, 44);
            buttonGiris.TabIndex = 0;
            buttonGiris.Text = "Giriş yap";
            buttonGiris.UseVisualStyleBackColor = false;
            buttonGiris.Click += buttonGiris_Click;
            // 
            // textBoxSifre
            // 
            textBoxSifre.Location = new Point(33, 307);
            textBoxSifre.Multiline = true;
            textBoxSifre.Name = "textBoxSifre";
            textBoxSifre.PasswordChar = '*';
            textBoxSifre.Size = new Size(390, 44);
            textBoxSifre.TabIndex = 3;
            // 
            // textBoxKullaniciAdi
            // 
            textBoxKullaniciAdi.Location = new Point(33, 166);
            textBoxKullaniciAdi.Multiline = true;
            textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            textBoxKullaniciAdi.Size = new Size(390, 44);
            textBoxKullaniciAdi.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(476, 652);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(476, 652);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.BackgroundImage = (Image)resources.GetObject("groupBox1.BackgroundImage");
            groupBox1.Controls.Add(panel1);
            groupBox1.ForeColor = SystemColors.ActiveCaption;
            groupBox1.Location = new Point(1, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1169, 678);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // FormGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1165, 692);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "FormGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kütüphane Yönetim Sistemi";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private Button buttonGiris;
        private TextBox textBoxSifre;
        private Label label2;
        private TextBox textBoxKullaniciAdi;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}