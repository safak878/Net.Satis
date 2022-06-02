namespace NetSatıs.BackOffice.Kasa
{
    partial class FrmKasaSec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKasaSec));
            this.GrupMenu = new DevExpress.XtraEditors.GroupControl();
            this.lblUyarı = new DevExpress.XtraEditors.LabelControl();
            this.BtnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BtnSec = new DevExpress.XtraEditors.SimpleButton();
            this.LblBaslık = new DevExpress.XtraEditors.LabelControl();
            this.gridcontKasa = new DevExpress.XtraGrid.GridControl();
            this.gridKasa = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColKasaKod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColKasaAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColYetkılıKod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColYetkılıAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColAcıklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColKasaGırıs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColKasaCıkıs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColBakıye = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GrupMenu)).BeginInit();
            this.GrupMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridcontKasa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKasa)).BeginInit();
            this.SuspendLayout();
            // 
            // GrupMenu
            // 
            this.GrupMenu.Controls.Add(this.lblUyarı);
            this.GrupMenu.Controls.Add(this.BtnKapat);
            this.GrupMenu.Controls.Add(this.BtnSec);
            this.GrupMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GrupMenu.Location = new System.Drawing.Point(0, 470);
            this.GrupMenu.Name = "GrupMenu";
            this.GrupMenu.Size = new System.Drawing.Size(922, 75);
            this.GrupMenu.TabIndex = 6;
            this.GrupMenu.Text = "Menü";
            // 
            // lblUyarı
            // 
            this.lblUyarı.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUyarı.Appearance.Options.UseFont = true;
            this.lblUyarı.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblUyarı.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lblUyarı.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUyarı.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("lblUyarı.ImageOptions.Image")));
            this.lblUyarı.Location = new System.Drawing.Point(2, 23);
            this.lblUyarı.Name = "lblUyarı";
            this.lblUyarı.Size = new System.Drawing.Size(451, 52);
            this.lblUyarı.TabIndex = 7;
            this.lblUyarı.Text = "Çoklu Seçim Yapabilmek İçin Ctrl Tuşuna basılı tutarak seçiminizi yapın";
            this.lblUyarı.Visible = false;
            // 
            // BtnKapat
            // 
            this.BtnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnKapat.ImageOptions.ImageIndex = 1;
            this.BtnKapat.ImageOptions.ImageList = this.ımageList1;
            this.BtnKapat.Location = new System.Drawing.Point(813, 32);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(102, 31);
            this.BtnKapat.TabIndex = 6;
            this.BtnKapat.Text = "KAPAT";
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "check.png");
            this.ımageList1.Images.SetKeyName(1, "folder_out.png");
            // 
            // BtnSec
            // 
            this.BtnSec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSec.ImageOptions.ImageIndex = 0;
            this.BtnSec.ImageOptions.ImageList = this.ımageList1;
            this.BtnSec.Location = new System.Drawing.Point(702, 32);
            this.BtnSec.Name = "BtnSec";
            this.BtnSec.Size = new System.Drawing.Size(105, 31);
            this.BtnSec.TabIndex = 5;
            this.BtnSec.Text = "SEÇ";
            this.BtnSec.Click += new System.EventHandler(this.BtnSec_Click);
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
            this.LblBaslık.Size = new System.Drawing.Size(922, 54);
            this.LblBaslık.TabIndex = 5;
            this.LblBaslık.Text = "Kasa Seçim Ekranı";
            // 
            // gridcontKasa
            // 
            this.gridcontKasa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridcontKasa.Location = new System.Drawing.Point(0, 54);
            this.gridcontKasa.MainView = this.gridKasa;
            this.gridcontKasa.Name = "gridcontKasa";
            this.gridcontKasa.Size = new System.Drawing.Size(922, 416);
            this.gridcontKasa.TabIndex = 7;
            this.gridcontKasa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridKasa});
            // 
            // gridKasa
            // 
            this.gridKasa.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.ColKasaKod,
            this.ColKasaAd,
            this.ColYetkılıKod,
            this.ColYetkılıAd,
            this.ColAcıklama,
            this.ColKasaGırıs,
            this.ColKasaCıkıs,
            this.ColBakıye});
            this.gridKasa.GridControl = this.gridcontKasa;
            this.gridKasa.Name = "gridKasa";
            this.gridKasa.OptionsView.ShowAutoFilterRow = true;
            this.gridKasa.OptionsView.ShowGroupPanel = false;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // ColKasaKod
            // 
            this.ColKasaKod.Caption = "KASAKOD";
            this.ColKasaKod.FieldName = "KASAKOD";
            this.ColKasaKod.Name = "ColKasaKod";
            this.ColKasaKod.Visible = true;
            this.ColKasaKod.VisibleIndex = 0;
            // 
            // ColKasaAd
            // 
            this.ColKasaAd.Caption = "KASAAD";
            this.ColKasaAd.FieldName = "KASAAD";
            this.ColKasaAd.Name = "ColKasaAd";
            this.ColKasaAd.Visible = true;
            this.ColKasaAd.VisibleIndex = 1;
            // 
            // ColYetkılıKod
            // 
            this.ColYetkılıKod.Caption = "YETKILIKOD";
            this.ColYetkılıKod.FieldName = "YETKILIKOD";
            this.ColYetkılıKod.Name = "ColYetkılıKod";
            this.ColYetkılıKod.Visible = true;
            this.ColYetkılıKod.VisibleIndex = 2;
            // 
            // ColYetkılıAd
            // 
            this.ColYetkılıAd.Caption = "YETKILIAD";
            this.ColYetkılıAd.FieldName = "YETKILIAD";
            this.ColYetkılıAd.Name = "ColYetkılıAd";
            this.ColYetkılıAd.Visible = true;
            this.ColYetkılıAd.VisibleIndex = 3;
            // 
            // ColAcıklama
            // 
            this.ColAcıklama.Caption = "ACIKLAMA";
            this.ColAcıklama.FieldName = "ACIKLAMA";
            this.ColAcıklama.Name = "ColAcıklama";
            this.ColAcıklama.Visible = true;
            this.ColAcıklama.VisibleIndex = 4;
            // 
            // ColKasaGırıs
            // 
            this.ColKasaGırıs.Caption = "KASAGIRIS";
            this.ColKasaGırıs.FieldName = "KASAGIRIS";
            this.ColKasaGırıs.Name = "ColKasaGırıs";
            this.ColKasaGırıs.Visible = true;
            this.ColKasaGırıs.VisibleIndex = 5;
            // 
            // ColKasaCıkıs
            // 
            this.ColKasaCıkıs.Caption = "KASACIKIS";
            this.ColKasaCıkıs.FieldName = "KASACIKIS";
            this.ColKasaCıkıs.Name = "ColKasaCıkıs";
            this.ColKasaCıkıs.Visible = true;
            this.ColKasaCıkıs.VisibleIndex = 6;
            // 
            // ColBakıye
            // 
            this.ColBakıye.Caption = "BAKIYE";
            this.ColBakıye.FieldName = "BAKIYE";
            this.ColBakıye.Name = "ColBakıye";
            this.ColBakıye.Visible = true;
            this.ColBakıye.VisibleIndex = 7;
            // 
            // FrmKasaSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 545);
            this.Controls.Add(this.gridcontKasa);
            this.Controls.Add(this.GrupMenu);
            this.Controls.Add(this.LblBaslık);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKasaSec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKasaSec";
            this.Load += new System.EventHandler(this.FrmKasaSec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrupMenu)).EndInit();
            this.GrupMenu.ResumeLayout(false);
            this.GrupMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridcontKasa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKasa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl GrupMenu;
        private DevExpress.XtraEditors.LabelControl lblUyarı;
        private DevExpress.XtraEditors.SimpleButton BtnKapat;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.SimpleButton BtnSec;
        private DevExpress.XtraEditors.LabelControl LblBaslık;
        private DevExpress.XtraGrid.GridControl gridcontKasa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridKasa;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn ColKasaKod;
        private DevExpress.XtraGrid.Columns.GridColumn ColKasaAd;
        private DevExpress.XtraGrid.Columns.GridColumn ColYetkılıKod;
        private DevExpress.XtraGrid.Columns.GridColumn ColYetkılıAd;
        private DevExpress.XtraGrid.Columns.GridColumn ColAcıklama;
        private DevExpress.XtraGrid.Columns.GridColumn ColKasaGırıs;
        private DevExpress.XtraGrid.Columns.GridColumn ColKasaCıkıs;
        private DevExpress.XtraGrid.Columns.GridColumn ColBakıye;
    }
}