namespace NetSatıs.BackOffice.Fis
{
    partial class FrmSerıNoGır
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSerıNoGır));
            this.LblBaslık = new DevExpress.XtraEditors.LabelControl();
            this.GrupMenu = new DevExpress.XtraEditors.GroupControl();
            this.BtnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.BtnVazgec = new DevExpress.XtraEditors.SimpleButton();
            this.BtnYenı = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSıl = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            this.GrupBılgı = new DevExpress.XtraEditors.GroupControl();
            this.TxtSerı = new System.Windows.Forms.TextBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GrupMenu)).BeginInit();
            this.GrupMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrupBılgı)).BeginInit();
            this.GrupBılgı.SuspendLayout();
            this.SuspendLayout();
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
            this.LblBaslık.ImageOptions.ImageIndex = 5;
            this.LblBaslık.ImageOptions.Images = this.ımageList1;
            this.LblBaslık.Location = new System.Drawing.Point(0, 0);
            this.LblBaslık.Name = "LblBaslık";
            this.LblBaslık.Size = new System.Drawing.Size(508, 52);
            this.LblBaslık.TabIndex = 8;
            this.LblBaslık.Text = "Seri No Bilgileri";
            // 
            // GrupMenu
            // 
            this.GrupMenu.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.GrupMenu.Controls.Add(this.BtnKaydet);
            this.GrupMenu.Controls.Add(this.BtnSıl);
            this.GrupMenu.Controls.Add(this.BtnKapat);
            this.GrupMenu.Controls.Add(this.BtnYenı);
            this.GrupMenu.Controls.Add(this.BtnVazgec);
            this.GrupMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GrupMenu.Location = new System.Drawing.Point(0, 338);
            this.GrupMenu.Name = "GrupMenu";
            this.GrupMenu.Size = new System.Drawing.Size(508, 72);
            this.GrupMenu.TabIndex = 11;
            // 
            // BtnKapat
            // 
            this.BtnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnKapat.ImageOptions.ImageIndex = 2;
            this.BtnKapat.ImageOptions.ImageList = this.ımageList1;
            this.BtnKapat.Location = new System.Drawing.Point(403, 26);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(93, 41);
            this.BtnKapat.TabIndex = 6;
            this.BtnKapat.Text = "KAPAT";
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // BtnVazgec
            // 
            this.BtnVazgec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnVazgec.Enabled = false;
            this.BtnVazgec.ImageOptions.ImageIndex = 4;
            this.BtnVazgec.ImageOptions.ImageList = this.ımageList1;
            this.BtnVazgec.Location = new System.Drawing.Point(305, 26);
            this.BtnVazgec.Name = "BtnVazgec";
            this.BtnVazgec.Size = new System.Drawing.Size(93, 41);
            this.BtnVazgec.TabIndex = 4;
            this.BtnVazgec.Text = "VAZGEÇ";
            this.BtnVazgec.Click += new System.EventHandler(this.BtnVazgec_Click);
            // 
            // BtnYenı
            // 
            this.BtnYenı.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnYenı.ImageOptions.ImageIndex = 0;
            this.BtnYenı.ImageOptions.ImageList = this.ımageList1;
            this.BtnYenı.Location = new System.Drawing.Point(8, 26);
            this.BtnYenı.Name = "BtnYenı";
            this.BtnYenı.Size = new System.Drawing.Size(93, 41);
            this.BtnYenı.TabIndex = 7;
            this.BtnYenı.Text = "YENİ";
            this.BtnYenı.Click += new System.EventHandler(this.BtnYenı_Click);
            // 
            // BtnSıl
            // 
            this.BtnSıl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSıl.ImageOptions.ImageIndex = 1;
            this.BtnSıl.ImageOptions.ImageList = this.ımageList1;
            this.BtnSıl.Location = new System.Drawing.Point(107, 26);
            this.BtnSıl.Name = "BtnSıl";
            this.BtnSıl.Size = new System.Drawing.Size(93, 41);
            this.BtnSıl.TabIndex = 8;
            this.BtnSıl.Text = "SİL";
            this.BtnSıl.Click += new System.EventHandler(this.BtnSıl_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnKaydet.Enabled = false;
            this.BtnKaydet.ImageOptions.ImageIndex = 3;
            this.BtnKaydet.ImageOptions.ImageList = this.ımageList1;
            this.BtnKaydet.Location = new System.Drawing.Point(206, 26);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(93, 41);
            this.BtnKaydet.TabIndex = 9;
            this.BtnKaydet.Text = "KAYDET";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBoxControl1.Location = new System.Drawing.Point(0, 105);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(508, 233);
            this.listBoxControl1.TabIndex = 12;
            // 
            // GrupBılgı
            // 
            this.GrupBılgı.Controls.Add(this.TxtSerı);
            this.GrupBılgı.Controls.Add(this.labelControl8);
            this.GrupBılgı.Dock = System.Windows.Forms.DockStyle.Top;
            this.GrupBılgı.Enabled = false;
            this.GrupBılgı.Location = new System.Drawing.Point(0, 52);
            this.GrupBılgı.Name = "GrupBılgı";
            this.GrupBılgı.Size = new System.Drawing.Size(508, 54);
            this.GrupBılgı.TabIndex = 18;
            this.GrupBılgı.Text = "Seri No Bilgisi";
            // 
            // TxtSerı
            // 
            this.TxtSerı.Location = new System.Drawing.Point(80, 26);
            this.TxtSerı.Multiline = true;
            this.TxtSerı.Name = "TxtSerı";
            this.TxtSerı.Size = new System.Drawing.Size(423, 20);
            this.TxtSerı.TabIndex = 28;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.labelControl8.Appearance.Options.UseBorderColor = true;
            this.labelControl8.Appearance.Options.UseTextOptions = true;
            this.labelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl8.Location = new System.Drawing.Point(2, 26);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(77, 21);
            this.labelControl8.TabIndex = 27;
            this.labelControl8.Text = "Seri No :";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "add.png");
            this.ımageList1.Images.SetKeyName(1, "delete.png");
            this.ımageList1.Images.SetKeyName(2, "folder_out.png");
            this.ımageList1.Images.SetKeyName(3, "floppy_disk.png");
            this.ımageList1.Images.SetKeyName(4, "floppy_disk_delete.png");
            this.ımageList1.Images.SetKeyName(5, "ticket_blue.png");
            // 
            // FrmSerıNoGır
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 410);
            this.Controls.Add(this.GrupBılgı);
            this.Controls.Add(this.listBoxControl1);
            this.Controls.Add(this.GrupMenu);
            this.Controls.Add(this.LblBaslık);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSerıNoGır";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSerıNoGır";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSerıNoGır_FormClosing);
            this.Load += new System.EventHandler(this.FrmSerıNoGır_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrupMenu)).EndInit();
            this.GrupMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrupBılgı)).EndInit();
            this.GrupBılgı.ResumeLayout(false);
            this.GrupBılgı.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl LblBaslık;
        private DevExpress.XtraEditors.GroupControl GrupMenu;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.SimpleButton BtnSıl;
        private DevExpress.XtraEditors.SimpleButton BtnKapat;
        private DevExpress.XtraEditors.SimpleButton BtnYenı;
        private DevExpress.XtraEditors.SimpleButton BtnVazgec;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.GroupControl GrupBılgı;
        private System.Windows.Forms.TextBox TxtSerı;
        private DevExpress.XtraEditors.LabelControl labelControl8;
    }
}