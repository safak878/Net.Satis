namespace NetSatıs.BackOffice.Kasa
{
    partial class FrmKasaIslem
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKasaIslem));
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.GrupFiyat = new DevExpress.XtraEditors.GroupControl();
            this.Gruplar = new DevExpress.XtraEditors.GroupControl();
            this.TxtAcıklama = new DevExpress.XtraEditors.MemoEdit();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BtnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.GrupGenel = new DevExpress.XtraEditors.GroupControl();
            this.TxtKasaKodu = new System.Windows.Forms.TextBox();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.GrupMenu = new DevExpress.XtraEditors.GroupControl();
            this.LblBaslık = new DevExpress.XtraEditors.LabelControl();
            this.TxtYetkılıKodu = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxtYetkılıAdı = new System.Windows.Forms.TextBox();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.TxtKasaAdı = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.GrupFiyat)).BeginInit();
            this.GrupFiyat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gruplar)).BeginInit();
            this.Gruplar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAcıklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrupGenel)).BeginInit();
            this.GrupGenel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrupMenu)).BeginInit();
            this.GrupMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.labelControl2.Appearance.Options.UseBorderColor = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl2.Location = new System.Drawing.Point(19, 42);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(77, 21);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Kasa Kodu :";
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "add.png");
            this.ımageList2.Images.SetKeyName(1, "delete.png");
            // 
            // GrupFiyat
            // 
            this.GrupFiyat.Controls.Add(this.labelControl10);
            this.GrupFiyat.Controls.Add(this.TxtAcıklama);
            this.GrupFiyat.Dock = System.Windows.Forms.DockStyle.Top;
            this.GrupFiyat.Location = new System.Drawing.Point(0, 262);
            this.GrupFiyat.Name = "GrupFiyat";
            this.GrupFiyat.Size = new System.Drawing.Size(451, 97);
            this.GrupFiyat.TabIndex = 12;
            this.GrupFiyat.Text = "Fiyatlar";
            // 
            // Gruplar
            // 
            this.Gruplar.Controls.Add(this.TxtYetkılıAdı);
            this.Gruplar.Controls.Add(this.labelControl12);
            this.Gruplar.Controls.Add(this.TxtYetkılıKodu);
            this.Gruplar.Controls.Add(this.labelControl1);
            this.Gruplar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Gruplar.Location = new System.Drawing.Point(0, 162);
            this.Gruplar.Name = "Gruplar";
            this.Gruplar.Size = new System.Drawing.Size(451, 100);
            this.Gruplar.TabIndex = 10;
            this.Gruplar.Text = "Diğer Bilgiler";
            // 
            // TxtAcıklama
            // 
            this.TxtAcıklama.Location = new System.Drawing.Point(102, 35);
            this.TxtAcıklama.Name = "TxtAcıklama";
            this.TxtAcıklama.Size = new System.Drawing.Size(337, 47);
            this.TxtAcıklama.TabIndex = 22;
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnKaydet.ImageOptions.ImageIndex = 0;
            this.BtnKaydet.ImageOptions.ImageList = this.ımageList1;
            this.BtnKaydet.Location = new System.Drawing.Point(236, 32);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(102, 31);
            this.BtnKaydet.TabIndex = 4;
            this.BtnKaydet.Text = "KAYDET";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "floppy_disk.png");
            this.ımageList1.Images.SetKeyName(1, "folder_out.png");
            // 
            // BtnKapat
            // 
            this.BtnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnKapat.ImageOptions.ImageIndex = 1;
            this.BtnKapat.ImageOptions.ImageList = this.ımageList1;
            this.BtnKapat.Location = new System.Drawing.Point(342, 32);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(102, 31);
            this.BtnKapat.TabIndex = 6;
            this.BtnKapat.Text = "KAPAT";
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // GrupGenel
            // 
            this.GrupGenel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.GrupGenel.Controls.Add(this.TxtKasaAdı);
            this.GrupGenel.Controls.Add(this.labelControl3);
            this.GrupGenel.Controls.Add(this.TxtKasaKodu);
            this.GrupGenel.Controls.Add(this.labelControl2);
            this.GrupGenel.Dock = System.Windows.Forms.DockStyle.Top;
            this.GrupGenel.Location = new System.Drawing.Point(0, 54);
            this.GrupGenel.Name = "GrupGenel";
            this.GrupGenel.Size = new System.Drawing.Size(451, 108);
            this.GrupGenel.TabIndex = 9;
            this.GrupGenel.Text = "Kasa Bilgisi";
            // 
            // TxtKasaKodu
            // 
            this.TxtKasaKodu.Location = new System.Drawing.Point(97, 44);
            this.TxtKasaKodu.Multiline = true;
            this.TxtKasaKodu.Name = "TxtKasaKodu";
            this.TxtKasaKodu.Size = new System.Drawing.Size(175, 20);
            this.TxtKasaKodu.TabIndex = 12;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.labelControl10.Appearance.Options.UseBorderColor = true;
            this.labelControl10.Appearance.Options.UseTextOptions = true;
            this.labelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl10.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl10.Location = new System.Drawing.Point(19, 39);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(77, 43);
            this.labelControl10.TabIndex = 9;
            this.labelControl10.Text = "Açıklama :";
            // 
            // GrupMenu
            // 
            this.GrupMenu.Controls.Add(this.BtnKapat);
            this.GrupMenu.Controls.Add(this.BtnKaydet);
            this.GrupMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GrupMenu.Location = new System.Drawing.Point(0, 361);
            this.GrupMenu.Name = "GrupMenu";
            this.GrupMenu.Size = new System.Drawing.Size(451, 68);
            this.GrupMenu.TabIndex = 8;
            this.GrupMenu.Text = "Diğer Bilgiler";
            // 
            // LblBaslık
            // 
            this.LblBaslık.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblBaslık.Appearance.Options.UseFont = true;
            this.LblBaslık.Appearance.Options.UseTextOptions = true;
            this.LblBaslık.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LblBaslık.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LblBaslık.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.LblBaslık.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblBaslık.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblBaslık.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("LblBaslık.ImageOptions.Image")));
            this.LblBaslık.Location = new System.Drawing.Point(0, 0);
            this.LblBaslık.Name = "LblBaslık";
            this.LblBaslık.Size = new System.Drawing.Size(451, 54);
            this.LblBaslık.TabIndex = 7;
            this.LblBaslık.Text = "Kasa İşlemeleri";
            // 
            // TxtYetkılıKodu
            // 
            this.TxtYetkılıKodu.Location = new System.Drawing.Point(102, 43);
            this.TxtYetkılıKodu.Multiline = true;
            this.TxtYetkılıKodu.Name = "TxtYetkılıKodu";
            this.TxtYetkılıKodu.Size = new System.Drawing.Size(337, 20);
            this.TxtYetkılıKodu.TabIndex = 14;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.labelControl1.Appearance.Options.UseBorderColor = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl1.Location = new System.Drawing.Point(24, 41);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(77, 21);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "Yetkili Kodu :";
            // 
            // TxtYetkılıAdı
            // 
            this.TxtYetkılıAdı.Location = new System.Drawing.Point(102, 69);
            this.TxtYetkılıAdı.Multiline = true;
            this.TxtYetkılıAdı.Name = "TxtYetkılıAdı";
            this.TxtYetkılıAdı.Size = new System.Drawing.Size(337, 20);
            this.TxtYetkılıAdı.TabIndex = 16;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.labelControl12.Appearance.Options.UseBorderColor = true;
            this.labelControl12.Appearance.Options.UseTextOptions = true;
            this.labelControl12.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl12.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl12.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl12.Location = new System.Drawing.Point(24, 67);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(77, 21);
            this.labelControl12.TabIndex = 15;
            this.labelControl12.Text = "Yetkili Adı :";
            // 
            // TxtKasaAdı
            // 
            this.TxtKasaAdı.Location = new System.Drawing.Point(97, 70);
            this.TxtKasaAdı.Multiline = true;
            this.TxtKasaAdı.Name = "TxtKasaAdı";
            this.TxtKasaAdı.Size = new System.Drawing.Size(342, 20);
            this.TxtKasaAdı.TabIndex = 14;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.labelControl3.Appearance.Options.UseBorderColor = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl3.Location = new System.Drawing.Point(19, 68);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(77, 21);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "Kasa Adı :";
            // 
            // FrmKasaIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 429);
            this.Controls.Add(this.GrupFiyat);
            this.Controls.Add(this.Gruplar);
            this.Controls.Add(this.GrupGenel);
            this.Controls.Add(this.GrupMenu);
            this.Controls.Add(this.LblBaslık);
            this.Name = "FrmKasaIslem";
            this.Text = "FrmKasaIslem";
            this.Load += new System.EventHandler(this.FrmKasaIslem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrupFiyat)).EndInit();
            this.GrupFiyat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Gruplar)).EndInit();
            this.Gruplar.ResumeLayout(false);
            this.Gruplar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAcıklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrupGenel)).EndInit();
            this.GrupGenel.ResumeLayout(false);
            this.GrupGenel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrupMenu)).EndInit();
            this.GrupMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ImageList ımageList2;
        private DevExpress.XtraEditors.GroupControl GrupFiyat;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.MemoEdit TxtAcıklama;
        private DevExpress.XtraEditors.GroupControl Gruplar;
        private System.Windows.Forms.TextBox TxtYetkılıAdı;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private System.Windows.Forms.TextBox TxtYetkılıKodu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.SimpleButton BtnKapat;
        private DevExpress.XtraEditors.GroupControl GrupGenel;
        private System.Windows.Forms.TextBox TxtKasaAdı;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox TxtKasaKodu;
        private DevExpress.XtraEditors.GroupControl GrupMenu;
        private DevExpress.XtraEditors.LabelControl LblBaslık;
    }
}