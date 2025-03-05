namespace OdevTakip
{
    partial class Form1
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
            panel1 = new Panel();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label10 = new Label();
            lbOgrenci = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtNo = new TextBox();
            txtDersAdı = new TextBox();
            txtOdevPuan = new TextBox();
            txtOdevkonu = new TextBox();
            cbevet = new CheckBox();
            cbHayır = new CheckBox();
            btnKaydet = new Button();
            btnYeni = new Button();
            btnSil = new Button();
            btnEkle = new Button();
            cbSınıf = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(643, 74);
            panel1.TabIndex = 0;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label9.ForeColor = SystemColors.InfoText;
            label9.Location = new Point(127, 0);
            label9.Name = "label9";
            label9.Size = new Size(530, 74);
            label9.TabIndex = 1;
            label9.Text = "ÖDEV TAKİP SİSTEMİ";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLight;
            pictureBox1.Image = Properties.Resources.graduated;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(label10);
            panel2.Controls.Add(lbOgrenci);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 74);
            panel2.Name = "panel2";
            panel2.Size = new Size(210, 594);
            panel2.TabIndex = 1;
            // 
            // label10
            // 
            label10.BackColor = Color.PapayaWhip;
            label10.Dock = DockStyle.Top;
            label10.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label10.Location = new Point(0, 0);
            label10.Name = "label10";
            label10.Size = new Size(210, 42);
            label10.TabIndex = 1;
            label10.Text = "Öğrenci Listesi";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbOgrenci
            // 
            lbOgrenci.FormattingEnabled = true;
            lbOgrenci.Location = new Point(1, 43);
            lbOgrenci.Name = "lbOgrenci";
            lbOgrenci.Size = new Size(210, 574);
            lbOgrenci.TabIndex = 0;
            lbOgrenci.SelectedIndexChanged += lbOgrenci_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(240, 114);
            label1.Name = "label1";
            label1.Size = new Size(44, 25);
            label1.TabIndex = 2;
            label1.Text = "Ad :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(240, 165);
            label2.Name = "label2";
            label2.Size = new Size(72, 25);
            label2.TabIndex = 3;
            label2.Text = "Soyad :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(240, 264);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 3;
            label3.Text = "Sınıf :";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(246, 215);
            label4.Name = "label4";
            label4.Size = new Size(46, 25);
            label4.TabIndex = 3;
            label4.Text = "No :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(240, 350);
            label5.Name = "label5";
            label5.Size = new Size(133, 25);
            label5.TabIndex = 3;
            label5.Text = "Ödev Konusu :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(240, 555);
            label6.Name = "label6";
            label6.Size = new Size(118, 25);
            label6.TabIndex = 3;
            label6.Text = "Ödev Puanı :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.Location = new Point(240, 463);
            label7.Name = "label7";
            label7.Size = new Size(167, 25);
            label7.TabIndex = 3;
            label7.Text = "Ödevi yaptınızmı ?";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label8.Location = new Point(240, 307);
            label8.Name = "label8";
            label8.Size = new Size(92, 25);
            label8.TabIndex = 3;
            label8.Text = "Ders Adı :";
            label8.Click += label3_Click;
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtAd.Location = new Point(337, 106);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(146, 33);
            txtAd.TabIndex = 4;
            // 
            // txtSoyad
            // 
            txtSoyad.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSoyad.Location = new Point(339, 157);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(146, 33);
            txtSoyad.TabIndex = 4;
            // 
            // txtNo
            // 
            txtNo.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtNo.Location = new Point(338, 207);
            txtNo.Name = "txtNo";
            txtNo.Size = new Size(146, 33);
            txtNo.TabIndex = 4;
            // 
            // txtDersAdı
            // 
            txtDersAdı.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtDersAdı.Location = new Point(339, 304);
            txtDersAdı.Name = "txtDersAdı";
            txtDersAdı.Size = new Size(146, 33);
            txtDersAdı.TabIndex = 4;
            // 
            // txtOdevPuan
            // 
            txtOdevPuan.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtOdevPuan.Location = new Point(364, 552);
            txtOdevPuan.Name = "txtOdevPuan";
            txtOdevPuan.Size = new Size(146, 33);
            txtOdevPuan.TabIndex = 4;
            // 
            // txtOdevkonu
            // 
            txtOdevkonu.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtOdevkonu.Location = new Point(240, 378);
            txtOdevkonu.Multiline = true;
            txtOdevkonu.Name = "txtOdevkonu";
            txtOdevkonu.Size = new Size(324, 82);
            txtOdevkonu.TabIndex = 4;
            // 
            // cbevet
            // 
            cbevet.AutoSize = true;
            cbevet.BackColor = Color.DarkSeaGreen;
            cbevet.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cbevet.Location = new Point(241, 502);
            cbevet.Name = "cbevet";
            cbevet.Size = new Size(71, 34);
            cbevet.TabIndex = 5;
            cbevet.Text = "Evet";
            cbevet.TextAlign = ContentAlignment.MiddleRight;
            cbevet.UseVisualStyleBackColor = false;
            // 
            // cbHayır
            // 
            cbHayır.AutoSize = true;
            cbHayır.BackColor = Color.Red;
            cbHayır.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cbHayır.Location = new Point(327, 502);
            cbHayır.Name = "cbHayır";
            cbHayır.Size = new Size(80, 34);
            cbHayır.TabIndex = 5;
            cbHayır.Text = "Hayır";
            cbHayır.TextAlign = ContentAlignment.MiddleRight;
            cbHayır.UseVisualStyleBackColor = false;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.Lime;
            btnKaydet.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnKaydet.Location = new Point(432, 615);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(89, 41);
            btnKaydet.TabIndex = 6;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnYeni
            // 
            btnYeni.BackColor = Color.Yellow;
            btnYeni.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnYeni.Location = new Point(335, 615);
            btnYeni.Name = "btnYeni";
            btnYeni.Size = new Size(89, 41);
            btnYeni.TabIndex = 6;
            btnYeni.Text = "Yeni";
            btnYeni.UseVisualStyleBackColor = false;
            btnYeni.Click += btnYeni_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.Red;
            btnSil.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnSil.Location = new Point(240, 615);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(89, 41);
            btnSil.TabIndex = 6;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.White;
            btnEkle.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnEkle.Location = new Point(527, 615);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(100, 41);
            btnEkle.TabIndex = 6;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // cbSınıf
            // 
            cbSınıf.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cbSınıf.FormattingEnabled = true;
            cbSınıf.Location = new Point(337, 256);
            cbSınıf.Name = "cbSınıf";
            cbSınıf.Size = new Size(145, 33);
            cbSınıf.TabIndex = 7;
            cbSınıf.SelectedIndexChanged += cbSınıf_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(643, 668);
            Controls.Add(cbSınıf);
            Controls.Add(btnSil);
            Controls.Add(btnYeni);
            Controls.Add(btnEkle);
            Controls.Add(btnKaydet);
            Controls.Add(cbHayır);
            Controls.Add(cbevet);
            Controls.Add(txtOdevkonu);
            Controls.Add(txtOdevPuan);
            Controls.Add(txtDersAdı);
            Controls.Add(txtSoyad);
            Controls.Add(txtNo);
            Controls.Add(txtAd);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtNo;
        private TextBox txtDersAdı;
        private TextBox txtOdevPuan;
        private TextBox txtOdevkonu;
        private CheckBox cbevet;
        private ListBox lbOgrenci;
        private PictureBox pictureBox1;
        private CheckBox cbHayır;
        private Label label9;
        private Button btnKaydet;
        private Button btnYeni;
        private Button btnSil;
        private Label label10;
        private Button btnEkle;
        private ComboBox cbSınıf;
    }
}
