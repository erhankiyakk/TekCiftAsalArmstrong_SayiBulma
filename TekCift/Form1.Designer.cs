namespace TekCift
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnHesapla = new System.Windows.Forms.Button();
            this.grpGirisBelgesi = new System.Windows.Forms.GroupBox();
            this.tabIslemler = new System.Windows.Forms.TabControl();
            this.tabTekSayilar = new System.Windows.Forms.TabPage();
            this.txtTekSayilarCarpim = new System.Windows.Forms.TextBox();
            this.lblTekSayilarCarpim = new System.Windows.Forms.Label();
            this.txtTekSayilarToplam = new System.Windows.Forms.TextBox();
            this.lblTekSayilarToplam = new System.Windows.Forms.Label();
            this.lwTekSayilar = new System.Windows.Forms.ListView();
            this.tabCiftSayilar = new System.Windows.Forms.TabPage();
            this.txtCiftSayilarCarpim = new System.Windows.Forms.TextBox();
            this.lblCiftSayilarCarpim = new System.Windows.Forms.Label();
            this.txtCiftSayilarToplam = new System.Windows.Forms.TextBox();
            this.lblCiftSayilarToplam = new System.Windows.Forms.Label();
            this.lwCiftSayilar = new System.Windows.Forms.ListView();
            this.tabAsalSayilar = new System.Windows.Forms.TabPage();
            this.txtAsalSayilarCarpim = new System.Windows.Forms.TextBox();
            this.lblAsalSayilarCarpim = new System.Windows.Forms.Label();
            this.txtAsalSayilarToplam = new System.Windows.Forms.TextBox();
            this.lblAsalSayilarToplam = new System.Windows.Forms.Label();
            this.lwAsalSayilar = new System.Windows.Forms.ListView();
            this.tabArmstrongSayilar = new System.Windows.Forms.TabPage();
            this.txtArmstrongSayilarCarpim = new System.Windows.Forms.TextBox();
            this.lblAmstrongSayilarCarpim = new System.Windows.Forms.Label();
            this.txtArmstrongSayilarToplam = new System.Windows.Forms.TextBox();
            this.lblAmstrongSayilarToplam = new System.Windows.Forms.Label();
            this.lwArmstrongSayilar = new System.Windows.Forms.ListView();
            this.btnIleri = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.mtxtBitis = new System.Windows.Forms.MaskedTextBox();
            this.lblBitis = new System.Windows.Forms.Label();
            this.mtxtBaslangic = new System.Windows.Forms.MaskedTextBox();
            this.lblBaslangıc = new System.Windows.Forms.Label();
            this.ntfIslemler = new System.Windows.Forms.NotifyIcon(this.components);
            this.grpGirisBelgesi.SuspendLayout();
            this.tabIslemler.SuspendLayout();
            this.tabTekSayilar.SuspendLayout();
            this.tabCiftSayilar.SuspendLayout();
            this.tabAsalSayilar.SuspendLayout();
            this.tabArmstrongSayilar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(429, 35);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(94, 34);
            this.btnHesapla.TabIndex = 0;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpGirisBelgesi
            // 
            this.grpGirisBelgesi.Controls.Add(this.tabIslemler);
            this.grpGirisBelgesi.Controls.Add(this.btnIleri);
            this.grpGirisBelgesi.Controls.Add(this.btnGeri);
            this.grpGirisBelgesi.Controls.Add(this.mtxtBitis);
            this.grpGirisBelgesi.Controls.Add(this.lblBitis);
            this.grpGirisBelgesi.Controls.Add(this.mtxtBaslangic);
            this.grpGirisBelgesi.Controls.Add(this.lblBaslangıc);
            this.grpGirisBelgesi.Controls.Add(this.btnHesapla);
            this.grpGirisBelgesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpGirisBelgesi.Location = new System.Drawing.Point(3, 12);
            this.grpGirisBelgesi.Name = "grpGirisBelgesi";
            this.grpGirisBelgesi.Size = new System.Drawing.Size(845, 498);
            this.grpGirisBelgesi.TabIndex = 1;
            this.grpGirisBelgesi.TabStop = false;
            this.grpGirisBelgesi.Text = "Giris Belgesi";
            // 
            // tabIslemler
            // 
            this.tabIslemler.Controls.Add(this.tabTekSayilar);
            this.tabIslemler.Controls.Add(this.tabCiftSayilar);
            this.tabIslemler.Controls.Add(this.tabAsalSayilar);
            this.tabIslemler.Controls.Add(this.tabArmstrongSayilar);
            this.tabIslemler.Location = new System.Drawing.Point(22, 76);
            this.tabIslemler.Name = "tabIslemler";
            this.tabIslemler.SelectedIndex = 0;
            this.tabIslemler.Size = new System.Drawing.Size(754, 416);
            this.tabIslemler.TabIndex = 8;
            // 
            // tabTekSayilar
            // 
            this.tabTekSayilar.Controls.Add(this.txtTekSayilarCarpim);
            this.tabTekSayilar.Controls.Add(this.lblTekSayilarCarpim);
            this.tabTekSayilar.Controls.Add(this.txtTekSayilarToplam);
            this.tabTekSayilar.Controls.Add(this.lblTekSayilarToplam);
            this.tabTekSayilar.Controls.Add(this.lwTekSayilar);
            this.tabTekSayilar.Location = new System.Drawing.Point(4, 25);
            this.tabTekSayilar.Name = "tabTekSayilar";
            this.tabTekSayilar.Padding = new System.Windows.Forms.Padding(3);
            this.tabTekSayilar.Size = new System.Drawing.Size(746, 387);
            this.tabTekSayilar.TabIndex = 0;
            this.tabTekSayilar.Text = "Tek Sayilar";
            this.tabTekSayilar.UseVisualStyleBackColor = true;
            // 
            // txtTekSayilarCarpim
            // 
            this.txtTekSayilarCarpim.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTekSayilarCarpim.ForeColor = System.Drawing.Color.Gray;
            this.txtTekSayilarCarpim.Location = new System.Drawing.Point(270, 296);
            this.txtTekSayilarCarpim.Multiline = true;
            this.txtTekSayilarCarpim.Name = "txtTekSayilarCarpim";
            this.txtTekSayilarCarpim.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTekSayilarCarpim.Size = new System.Drawing.Size(438, 36);
            this.txtTekSayilarCarpim.TabIndex = 4;
            // 
            // lblTekSayilarCarpim
            // 
            this.lblTekSayilarCarpim.AutoSize = true;
            this.lblTekSayilarCarpim.Location = new System.Drawing.Point(206, 296);
            this.lblTekSayilarCarpim.Name = "lblTekSayilarCarpim";
            this.lblTekSayilarCarpim.Size = new System.Drawing.Size(58, 17);
            this.lblTekSayilarCarpim.TabIndex = 3;
            this.lblTekSayilarCarpim.Text = "Carpim";
            // 
            // txtTekSayilarToplam
            // 
            this.txtTekSayilarToplam.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTekSayilarToplam.Enabled = false;
            this.txtTekSayilarToplam.Location = new System.Drawing.Point(85, 296);
            this.txtTekSayilarToplam.Multiline = true;
            this.txtTekSayilarToplam.Name = "txtTekSayilarToplam";
            this.txtTekSayilarToplam.Size = new System.Drawing.Size(100, 36);
            this.txtTekSayilarToplam.TabIndex = 2;
            // 
            // lblTekSayilarToplam
            // 
            this.lblTekSayilarToplam.AutoSize = true;
            this.lblTekSayilarToplam.Location = new System.Drawing.Point(18, 296);
            this.lblTekSayilarToplam.Name = "lblTekSayilarToplam";
            this.lblTekSayilarToplam.Size = new System.Drawing.Size(61, 17);
            this.lblTekSayilarToplam.TabIndex = 1;
            this.lblTekSayilarToplam.Text = "Toplam";
            // 
            // lwTekSayilar
            // 
            this.lwTekSayilar.HideSelection = false;
            this.lwTekSayilar.Location = new System.Drawing.Point(21, 18);
            this.lwTekSayilar.Name = "lwTekSayilar";
            this.lwTekSayilar.Size = new System.Drawing.Size(687, 256);
            this.lwTekSayilar.TabIndex = 0;
            this.lwTekSayilar.UseCompatibleStateImageBehavior = false;
            // 
            // tabCiftSayilar
            // 
            this.tabCiftSayilar.Controls.Add(this.txtCiftSayilarCarpim);
            this.tabCiftSayilar.Controls.Add(this.lblCiftSayilarCarpim);
            this.tabCiftSayilar.Controls.Add(this.txtCiftSayilarToplam);
            this.tabCiftSayilar.Controls.Add(this.lblCiftSayilarToplam);
            this.tabCiftSayilar.Controls.Add(this.lwCiftSayilar);
            this.tabCiftSayilar.Location = new System.Drawing.Point(4, 25);
            this.tabCiftSayilar.Name = "tabCiftSayilar";
            this.tabCiftSayilar.Padding = new System.Windows.Forms.Padding(3);
            this.tabCiftSayilar.Size = new System.Drawing.Size(746, 387);
            this.tabCiftSayilar.TabIndex = 1;
            this.tabCiftSayilar.Text = "Cift Sayilar";
            this.tabCiftSayilar.UseVisualStyleBackColor = true;
            // 
            // txtCiftSayilarCarpim
            // 
            this.txtCiftSayilarCarpim.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCiftSayilarCarpim.ForeColor = System.Drawing.Color.Gray;
            this.txtCiftSayilarCarpim.Location = new System.Drawing.Point(323, 300);
            this.txtCiftSayilarCarpim.Multiline = true;
            this.txtCiftSayilarCarpim.Name = "txtCiftSayilarCarpim";
            this.txtCiftSayilarCarpim.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCiftSayilarCarpim.Size = new System.Drawing.Size(383, 35);
            this.txtCiftSayilarCarpim.TabIndex = 8;
            // 
            // lblCiftSayilarCarpim
            // 
            this.lblCiftSayilarCarpim.AutoSize = true;
            this.lblCiftSayilarCarpim.Location = new System.Drawing.Point(236, 305);
            this.lblCiftSayilarCarpim.Name = "lblCiftSayilarCarpim";
            this.lblCiftSayilarCarpim.Size = new System.Drawing.Size(58, 17);
            this.lblCiftSayilarCarpim.TabIndex = 7;
            this.lblCiftSayilarCarpim.Text = "Carpim";
            // 
            // txtCiftSayilarToplam
            // 
            this.txtCiftSayilarToplam.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCiftSayilarToplam.Enabled = false;
            this.txtCiftSayilarToplam.Location = new System.Drawing.Point(99, 305);
            this.txtCiftSayilarToplam.Multiline = true;
            this.txtCiftSayilarToplam.Name = "txtCiftSayilarToplam";
            this.txtCiftSayilarToplam.Size = new System.Drawing.Size(131, 30);
            this.txtCiftSayilarToplam.TabIndex = 6;
            // 
            // lblCiftSayilarToplam
            // 
            this.lblCiftSayilarToplam.AutoSize = true;
            this.lblCiftSayilarToplam.Location = new System.Drawing.Point(23, 305);
            this.lblCiftSayilarToplam.Name = "lblCiftSayilarToplam";
            this.lblCiftSayilarToplam.Size = new System.Drawing.Size(61, 17);
            this.lblCiftSayilarToplam.TabIndex = 5;
            this.lblCiftSayilarToplam.Text = "Toplam";
            // 
            // lwCiftSayilar
            // 
            this.lwCiftSayilar.HideSelection = false;
            this.lwCiftSayilar.Location = new System.Drawing.Point(26, 17);
            this.lwCiftSayilar.Name = "lwCiftSayilar";
            this.lwCiftSayilar.Size = new System.Drawing.Size(680, 277);
            this.lwCiftSayilar.TabIndex = 0;
            this.lwCiftSayilar.UseCompatibleStateImageBehavior = false;
            // 
            // tabAsalSayilar
            // 
            this.tabAsalSayilar.Controls.Add(this.txtAsalSayilarCarpim);
            this.tabAsalSayilar.Controls.Add(this.lblAsalSayilarCarpim);
            this.tabAsalSayilar.Controls.Add(this.txtAsalSayilarToplam);
            this.tabAsalSayilar.Controls.Add(this.lblAsalSayilarToplam);
            this.tabAsalSayilar.Controls.Add(this.lwAsalSayilar);
            this.tabAsalSayilar.Location = new System.Drawing.Point(4, 25);
            this.tabAsalSayilar.Name = "tabAsalSayilar";
            this.tabAsalSayilar.Padding = new System.Windows.Forms.Padding(3);
            this.tabAsalSayilar.Size = new System.Drawing.Size(746, 387);
            this.tabAsalSayilar.TabIndex = 2;
            this.tabAsalSayilar.Text = "Asal Sayilar";
            this.tabAsalSayilar.UseVisualStyleBackColor = true;
            // 
            // txtAsalSayilarCarpim
            // 
            this.txtAsalSayilarCarpim.BackColor = System.Drawing.Color.Gainsboro;
            this.txtAsalSayilarCarpim.ForeColor = System.Drawing.Color.Gray;
            this.txtAsalSayilarCarpim.Location = new System.Drawing.Point(326, 308);
            this.txtAsalSayilarCarpim.Multiline = true;
            this.txtAsalSayilarCarpim.Name = "txtAsalSayilarCarpim";
            this.txtAsalSayilarCarpim.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAsalSayilarCarpim.Size = new System.Drawing.Size(378, 35);
            this.txtAsalSayilarCarpim.TabIndex = 8;
            // 
            // lblAsalSayilarCarpim
            // 
            this.lblAsalSayilarCarpim.AutoSize = true;
            this.lblAsalSayilarCarpim.Location = new System.Drawing.Point(243, 308);
            this.lblAsalSayilarCarpim.Name = "lblAsalSayilarCarpim";
            this.lblAsalSayilarCarpim.Size = new System.Drawing.Size(58, 17);
            this.lblAsalSayilarCarpim.TabIndex = 7;
            this.lblAsalSayilarCarpim.Text = "Carpim";
            // 
            // txtAsalSayilarToplam
            // 
            this.txtAsalSayilarToplam.BackColor = System.Drawing.Color.Gainsboro;
            this.txtAsalSayilarToplam.Enabled = false;
            this.txtAsalSayilarToplam.Location = new System.Drawing.Point(102, 308);
            this.txtAsalSayilarToplam.Multiline = true;
            this.txtAsalSayilarToplam.Name = "txtAsalSayilarToplam";
            this.txtAsalSayilarToplam.Size = new System.Drawing.Size(135, 35);
            this.txtAsalSayilarToplam.TabIndex = 6;
            // 
            // lblAsalSayilarToplam
            // 
            this.lblAsalSayilarToplam.AutoSize = true;
            this.lblAsalSayilarToplam.Location = new System.Drawing.Point(19, 308);
            this.lblAsalSayilarToplam.Name = "lblAsalSayilarToplam";
            this.lblAsalSayilarToplam.Size = new System.Drawing.Size(61, 17);
            this.lblAsalSayilarToplam.TabIndex = 5;
            this.lblAsalSayilarToplam.Text = "Toplam";
            // 
            // lwAsalSayilar
            // 
            this.lwAsalSayilar.HideSelection = false;
            this.lwAsalSayilar.Location = new System.Drawing.Point(22, 17);
            this.lwAsalSayilar.Name = "lwAsalSayilar";
            this.lwAsalSayilar.Size = new System.Drawing.Size(665, 264);
            this.lwAsalSayilar.TabIndex = 0;
            this.lwAsalSayilar.UseCompatibleStateImageBehavior = false;
            // 
            // tabArmstrongSayilar
            // 
            this.tabArmstrongSayilar.Controls.Add(this.txtArmstrongSayilarCarpim);
            this.tabArmstrongSayilar.Controls.Add(this.lblAmstrongSayilarCarpim);
            this.tabArmstrongSayilar.Controls.Add(this.txtArmstrongSayilarToplam);
            this.tabArmstrongSayilar.Controls.Add(this.lblAmstrongSayilarToplam);
            this.tabArmstrongSayilar.Controls.Add(this.lwArmstrongSayilar);
            this.tabArmstrongSayilar.Location = new System.Drawing.Point(4, 25);
            this.tabArmstrongSayilar.Name = "tabArmstrongSayilar";
            this.tabArmstrongSayilar.Padding = new System.Windows.Forms.Padding(3);
            this.tabArmstrongSayilar.Size = new System.Drawing.Size(746, 387);
            this.tabArmstrongSayilar.TabIndex = 3;
            this.tabArmstrongSayilar.Text = "Armstrong Sayilar";
            this.tabArmstrongSayilar.UseVisualStyleBackColor = true;
            // 
            // txtArmstrongSayilarCarpim
            // 
            this.txtArmstrongSayilarCarpim.BackColor = System.Drawing.Color.Gainsboro;
            this.txtArmstrongSayilarCarpim.ForeColor = System.Drawing.Color.Gray;
            this.txtArmstrongSayilarCarpim.Location = new System.Drawing.Point(322, 316);
            this.txtArmstrongSayilarCarpim.Multiline = true;
            this.txtArmstrongSayilarCarpim.Name = "txtArmstrongSayilarCarpim";
            this.txtArmstrongSayilarCarpim.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtArmstrongSayilarCarpim.Size = new System.Drawing.Size(373, 38);
            this.txtArmstrongSayilarCarpim.TabIndex = 9;
            // 
            // lblAmstrongSayilarCarpim
            // 
            this.lblAmstrongSayilarCarpim.AutoSize = true;
            this.lblAmstrongSayilarCarpim.Location = new System.Drawing.Point(236, 322);
            this.lblAmstrongSayilarCarpim.Name = "lblAmstrongSayilarCarpim";
            this.lblAmstrongSayilarCarpim.Size = new System.Drawing.Size(58, 17);
            this.lblAmstrongSayilarCarpim.TabIndex = 7;
            this.lblAmstrongSayilarCarpim.Text = "Carpim";
            // 
            // txtArmstrongSayilarToplam
            // 
            this.txtArmstrongSayilarToplam.BackColor = System.Drawing.Color.Gainsboro;
            this.txtArmstrongSayilarToplam.Enabled = false;
            this.txtArmstrongSayilarToplam.Location = new System.Drawing.Point(103, 319);
            this.txtArmstrongSayilarToplam.Multiline = true;
            this.txtArmstrongSayilarToplam.Name = "txtArmstrongSayilarToplam";
            this.txtArmstrongSayilarToplam.Size = new System.Drawing.Size(116, 35);
            this.txtArmstrongSayilarToplam.TabIndex = 6;
            // 
            // lblAmstrongSayilarToplam
            // 
            this.lblAmstrongSayilarToplam.AutoSize = true;
            this.lblAmstrongSayilarToplam.Location = new System.Drawing.Point(19, 319);
            this.lblAmstrongSayilarToplam.Name = "lblAmstrongSayilarToplam";
            this.lblAmstrongSayilarToplam.Size = new System.Drawing.Size(61, 17);
            this.lblAmstrongSayilarToplam.TabIndex = 5;
            this.lblAmstrongSayilarToplam.Text = "Toplam";
            // 
            // lwArmstrongSayilar
            // 
            this.lwArmstrongSayilar.HideSelection = false;
            this.lwArmstrongSayilar.Location = new System.Drawing.Point(22, 7);
            this.lwArmstrongSayilar.Name = "lwArmstrongSayilar";
            this.lwArmstrongSayilar.Size = new System.Drawing.Size(673, 281);
            this.lwArmstrongSayilar.TabIndex = 0;
            this.lwArmstrongSayilar.UseCompatibleStateImageBehavior = false;
            // 
            // btnIleri
            // 
            this.btnIleri.Location = new System.Drawing.Point(691, 35);
            this.btnIleri.Name = "btnIleri";
            this.btnIleri.Size = new System.Drawing.Size(75, 35);
            this.btnIleri.TabIndex = 7;
            this.btnIleri.Text = "Ileri>>";
            this.btnIleri.UseVisualStyleBackColor = true;
            this.btnIleri.Click += new System.EventHandler(this.btnIleri_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(586, 35);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(75, 35);
            this.btnGeri.TabIndex = 6;
            this.btnGeri.Text = "<<Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // mtxtBitis
            // 
            this.mtxtBitis.Location = new System.Drawing.Point(282, 47);
            this.mtxtBitis.Mask = "00000";
            this.mtxtBitis.Name = "mtxtBitis";
            this.mtxtBitis.Size = new System.Drawing.Size(100, 22);
            this.mtxtBitis.TabIndex = 5;
            this.mtxtBitis.Text = "10000";
            this.mtxtBitis.ValidatingType = typeof(int);
            // 
            // lblBitis
            // 
            this.lblBitis.AutoSize = true;
            this.lblBitis.Location = new System.Drawing.Point(232, 50);
            this.lblBitis.Name = "lblBitis";
            this.lblBitis.Size = new System.Drawing.Size(44, 17);
            this.lblBitis.TabIndex = 4;
            this.lblBitis.Text = "Bitiş:";
            // 
            // mtxtBaslangic
            // 
            this.mtxtBaslangic.Location = new System.Drawing.Point(108, 48);
            this.mtxtBaslangic.Mask = "00000";
            this.mtxtBaslangic.Name = "mtxtBaslangic";
            this.mtxtBaslangic.Size = new System.Drawing.Size(100, 22);
            this.mtxtBaslangic.TabIndex = 3;
            this.mtxtBaslangic.Text = "00001";
            this.mtxtBaslangic.ValidatingType = typeof(int);
            // 
            // lblBaslangıc
            // 
            this.lblBaslangıc.AutoSize = true;
            this.lblBaslangıc.Location = new System.Drawing.Point(19, 52);
            this.lblBaslangıc.Name = "lblBaslangıc";
            this.lblBaslangıc.Size = new System.Drawing.Size(83, 17);
            this.lblBaslangıc.TabIndex = 1;
            this.lblBaslangıc.Text = "Başlangıc:";
            // 
            // ntfIslemler
            // 
            this.ntfIslemler.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ntfIslemler.BalloonTipText = "Tek ,Çift ,Asal ,Amstrong Sayi Bulma Programı ";
            this.ntfIslemler.BalloonTipTitle = "Programa Hos Geldiniz !";
            this.ntfIslemler.Icon = ((System.Drawing.Icon)(resources.GetObject("ntfIslemler.Icon")));
            this.ntfIslemler.Text = "Giris Kutusu";
            this.ntfIslemler.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 539);
            this.Controls.Add(this.grpGirisBelgesi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.grpGirisBelgesi.ResumeLayout(false);
            this.grpGirisBelgesi.PerformLayout();
            this.tabIslemler.ResumeLayout(false);
            this.tabTekSayilar.ResumeLayout(false);
            this.tabTekSayilar.PerformLayout();
            this.tabCiftSayilar.ResumeLayout(false);
            this.tabCiftSayilar.PerformLayout();
            this.tabAsalSayilar.ResumeLayout(false);
            this.tabAsalSayilar.PerformLayout();
            this.tabArmstrongSayilar.ResumeLayout(false);
            this.tabArmstrongSayilar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.GroupBox grpGirisBelgesi;
        private System.Windows.Forms.Label lblBaslangıc;
        private System.Windows.Forms.MaskedTextBox mtxtBitis;
        private System.Windows.Forms.Label lblBitis;
        private System.Windows.Forms.MaskedTextBox mtxtBaslangic;
        private System.Windows.Forms.TabControl tabIslemler;
        private System.Windows.Forms.TabPage tabTekSayilar;
        private System.Windows.Forms.TextBox txtTekSayilarCarpim;
        private System.Windows.Forms.Label lblTekSayilarCarpim;
        private System.Windows.Forms.TextBox txtTekSayilarToplam;
        private System.Windows.Forms.Label lblTekSayilarToplam;
        private System.Windows.Forms.ListView lwTekSayilar;
        private System.Windows.Forms.TabPage tabCiftSayilar;
        private System.Windows.Forms.TextBox txtCiftSayilarToplam;
        private System.Windows.Forms.Label lblCiftSayilarToplam;
        private System.Windows.Forms.ListView lwCiftSayilar;
        private System.Windows.Forms.TabPage tabAsalSayilar;
        private System.Windows.Forms.TextBox txtAsalSayilarCarpim;
        private System.Windows.Forms.Label lblAsalSayilarCarpim;
        private System.Windows.Forms.TextBox txtAsalSayilarToplam;
        private System.Windows.Forms.Label lblAsalSayilarToplam;
        private System.Windows.Forms.ListView lwAsalSayilar;
        private System.Windows.Forms.TabPage tabArmstrongSayilar;
        private System.Windows.Forms.Label lblAmstrongSayilarCarpim;
        private System.Windows.Forms.TextBox txtArmstrongSayilarToplam;
        private System.Windows.Forms.Label lblAmstrongSayilarToplam;
        private System.Windows.Forms.ListView lwArmstrongSayilar;
        private System.Windows.Forms.Button btnIleri;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.TextBox txtArmstrongSayilarCarpim;
        private System.Windows.Forms.NotifyIcon ntfIslemler;
        private System.Windows.Forms.TextBox txtCiftSayilarCarpim;
        public System.Windows.Forms.Label lblCiftSayilarCarpim;
    }
}

