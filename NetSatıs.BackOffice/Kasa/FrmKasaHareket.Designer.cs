namespace NetSatıs.BackOffice.Kasa
{
    partial class FrmKasaHareket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKasaHareket));
            this.ColGenelToplam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridContOdemeTuruToplam = new DevExpress.XtraGrid.GridControl();
            this.gridOdemeTuruToplam = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColOdemeTur = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColKasaGırıs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColKasaCıkıs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColBakıye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridContKasaGenelToplam = new DevExpress.XtraGrid.GridControl();
            this.gridKasaGenelToplam = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColGenelBılgı = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColGenelKayıtSırası = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GrpMenu = new DevExpress.XtraEditors.GroupControl();
            this.BtnAra = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BtnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.LblBaslık = new DevExpress.XtraEditors.LabelControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFISKOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHAREKET = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTOPLAMTUTAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTARIH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColSaat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACIKLAMA = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContOdemeTuruToplam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOdemeTuruToplam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContKasaGenelToplam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKasaGenelToplam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrpMenu)).BeginInit();
            this.GrpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ColGenelToplam
            // 
            this.ColGenelToplam.Caption = "TOPLAM";
            this.ColGenelToplam.FieldName = "TUTAR";
            this.ColGenelToplam.Name = "ColGenelToplam";
            this.ColGenelToplam.OptionsColumn.AllowEdit = false;
            this.ColGenelToplam.Visible = true;
            this.ColGenelToplam.VisibleIndex = 2;
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.groupControl2);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(1558, 376);
            this.splitContainerControl2.SplitterPosition = 806;
            this.splitContainerControl2.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridContOdemeTuruToplam);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(806, 376);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Ödeme Türüne Göre Toplamlar";
            // 
            // gridContOdemeTuruToplam
            // 
            this.gridContOdemeTuruToplam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContOdemeTuruToplam.Location = new System.Drawing.Point(2, 23);
            this.gridContOdemeTuruToplam.MainView = this.gridOdemeTuruToplam;
            this.gridContOdemeTuruToplam.Name = "gridContOdemeTuruToplam";
            this.gridContOdemeTuruToplam.Size = new System.Drawing.Size(802, 351);
            this.gridContOdemeTuruToplam.TabIndex = 2;
            this.gridContOdemeTuruToplam.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridOdemeTuruToplam});
            // 
            // gridOdemeTuruToplam
            // 
            this.gridOdemeTuruToplam.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColOdemeTur,
            this.ColKasaGırıs,
            this.ColKasaCıkıs,
            this.ColBakıye});
            this.gridOdemeTuruToplam.GridControl = this.gridContOdemeTuruToplam;
            this.gridOdemeTuruToplam.Name = "gridOdemeTuruToplam";
            this.gridOdemeTuruToplam.OptionsView.ShowGroupPanel = false;
            // 
            // ColOdemeTur
            // 
            this.ColOdemeTur.Caption = "ODEMETURUAD";
            this.ColOdemeTur.FieldName = "ODEMETURUAD";
            this.ColOdemeTur.Name = "ColOdemeTur";
            this.ColOdemeTur.Visible = true;
            this.ColOdemeTur.VisibleIndex = 0;
            // 
            // ColKasaGırıs
            // 
            this.ColKasaGırıs.Caption = "KASAGIRIS";
            this.ColKasaGırıs.FieldName = "KASAGIRIS";
            this.ColKasaGırıs.Name = "ColKasaGırıs";
            this.ColKasaGırıs.Visible = true;
            this.ColKasaGırıs.VisibleIndex = 1;
            // 
            // ColKasaCıkıs
            // 
            this.ColKasaCıkıs.Caption = "KASACIKIS";
            this.ColKasaCıkıs.FieldName = "KASACIKIS";
            this.ColKasaCıkıs.Name = "ColKasaCıkıs";
            this.ColKasaCıkıs.Visible = true;
            this.ColKasaCıkıs.VisibleIndex = 2;
            // 
            // ColBakıye
            // 
            this.ColBakıye.Caption = "BAKIYE";
            this.ColBakıye.FieldName = "BAKIYE";
            this.ColBakıye.Name = "ColBakıye";
            this.ColBakıye.Visible = true;
            this.ColBakıye.VisibleIndex = 3;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridContKasaGenelToplam);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(742, 376);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Genel Toplamlar";
            // 
            // gridContKasaGenelToplam
            // 
            this.gridContKasaGenelToplam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContKasaGenelToplam.Location = new System.Drawing.Point(2, 23);
            this.gridContKasaGenelToplam.MainView = this.gridKasaGenelToplam;
            this.gridContKasaGenelToplam.Name = "gridContKasaGenelToplam";
            this.gridContKasaGenelToplam.Size = new System.Drawing.Size(738, 351);
            this.gridContKasaGenelToplam.TabIndex = 2;
            this.gridContKasaGenelToplam.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridKasaGenelToplam});
            // 
            // gridKasaGenelToplam
            // 
            this.gridKasaGenelToplam.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColGenelBılgı,
            this.ColGenelKayıtSırası,
            this.ColGenelToplam});
            this.gridKasaGenelToplam.GridControl = this.gridContKasaGenelToplam;
            this.gridKasaGenelToplam.Name = "gridKasaGenelToplam";
            this.gridKasaGenelToplam.OptionsView.ShowGroupPanel = false;
            // 
            // ColGenelBılgı
            // 
            this.ColGenelBılgı.Caption = "BILGI";
            this.ColGenelBılgı.FieldName = "BILGI";
            this.ColGenelBılgı.Name = "ColGenelBılgı";
            this.ColGenelBılgı.OptionsColumn.AllowEdit = false;
            this.ColGenelBılgı.Visible = true;
            this.ColGenelBılgı.VisibleIndex = 0;
            // 
            // ColGenelKayıtSırası
            // 
            this.ColGenelKayıtSırası.Caption = "KAYITSAYISI";
            this.ColGenelKayıtSırası.FieldName = "KAYITSAYISI";
            this.ColGenelKayıtSırası.Name = "ColGenelKayıtSırası";
            this.ColGenelKayıtSırası.OptionsColumn.AllowEdit = false;
            this.ColGenelKayıtSırası.Visible = true;
            this.ColGenelKayıtSırası.VisibleIndex = 1;
            // 
            // GrpMenu
            // 
            this.GrpMenu.Controls.Add(this.BtnAra);
            this.GrpMenu.Controls.Add(this.BtnKapat);
            this.GrpMenu.Controls.Add(this.BtnGuncelle);
            this.GrpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GrpMenu.Location = new System.Drawing.Point(0, 595);
            this.GrpMenu.Name = "GrpMenu";
            this.GrpMenu.Size = new System.Drawing.Size(1558, 74);
            this.GrpMenu.TabIndex = 5;
            this.GrpMenu.Text = "groupControl1";
            // 
            // BtnAra
            // 
            this.BtnAra.ImageOptions.ImageIndex = 2;
            this.BtnAra.ImageOptions.ImageList = this.ımageList1;
            this.BtnAra.Location = new System.Drawing.Point(113, 27);
            this.BtnAra.Name = "BtnAra";
            this.BtnAra.Size = new System.Drawing.Size(108, 42);
            this.BtnAra.TabIndex = 5;
            this.BtnAra.Text = "ARA";
            this.BtnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "folder_out.png");
            this.ımageList1.Images.SetKeyName(1, "refresh.png");
            this.ımageList1.Images.SetKeyName(2, "view.png");
            // 
            // BtnKapat
            // 
            this.BtnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnKapat.ImageOptions.ImageIndex = 0;
            this.BtnKapat.ImageOptions.ImageList = this.ımageList1;
            this.BtnKapat.Location = new System.Drawing.Point(1451, 26);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(102, 42);
            this.BtnKapat.TabIndex = 6;
            this.BtnKapat.Text = "KAPAT";
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.ImageOptions.ImageIndex = 1;
            this.BtnGuncelle.ImageOptions.ImageList = this.ımageList1;
            this.BtnGuncelle.Location = new System.Drawing.Point(5, 26);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(102, 42);
            this.BtnGuncelle.TabIndex = 4;
            this.BtnGuncelle.Text = "GÜNCELLE";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
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
            this.LblBaslık.Size = new System.Drawing.Size(1558, 54);
            this.LblBaslık.TabIndex = 4;
            this.LblBaslık.Text = "Kasa Hareketleri";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 54);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1558, 615);
            this.splitContainerControl1.SplitterPosition = 229;
            this.splitContainerControl1.TabIndex = 6;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1558, 229);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colFISKOD,
            this.colHAREKET,
            this.colTOPLAMTUTAR,
            this.colTARIH,
            this.ColSaat,
            this.colACIKLAMA});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // colFISKOD
            // 
            this.colFISKOD.Caption = "FiŞ KODU";
            this.colFISKOD.FieldName = "FISKOD";
            this.colFISKOD.Name = "colFISKOD";
            this.colFISKOD.OptionsColumn.AllowEdit = false;
            this.colFISKOD.Visible = true;
            this.colFISKOD.VisibleIndex = 0;
            this.colFISKOD.Width = 99;
            // 
            // colHAREKET
            // 
            this.colHAREKET.Caption = "HAREKET";
            this.colHAREKET.FieldName = "HAREKET";
            this.colHAREKET.Name = "colHAREKET";
            this.colHAREKET.OptionsColumn.AllowEdit = false;
            this.colHAREKET.Visible = true;
            this.colHAREKET.VisibleIndex = 1;
            this.colHAREKET.Width = 99;
            // 
            // colTOPLAMTUTAR
            // 
            this.colTOPLAMTUTAR.Caption = "TOPLAMTUTAR";
            this.colTOPLAMTUTAR.DisplayFormat.FormatString = "C2";
            this.colTOPLAMTUTAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTOPLAMTUTAR.FieldName = "TUTAR";
            this.colTOPLAMTUTAR.Name = "colTOPLAMTUTAR";
            this.colTOPLAMTUTAR.OptionsColumn.AllowEdit = false;
            this.colTOPLAMTUTAR.Visible = true;
            this.colTOPLAMTUTAR.VisibleIndex = 5;
            this.colTOPLAMTUTAR.Width = 101;
            // 
            // colTARIH
            // 
            this.colTARIH.Caption = "TARİH";
            this.colTARIH.DisplayFormat.FormatString = "d";
            this.colTARIH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTARIH.FieldName = "TARIH";
            this.colTARIH.Name = "colTARIH";
            this.colTARIH.OptionsColumn.AllowEdit = false;
            this.colTARIH.Visible = true;
            this.colTARIH.VisibleIndex = 3;
            this.colTARIH.Width = 96;
            // 
            // ColSaat
            // 
            this.ColSaat.Caption = "SAAT";
            this.ColSaat.DisplayFormat.FormatString = "t";
            this.ColSaat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ColSaat.FieldName = "TARIH";
            this.ColSaat.Name = "ColSaat";
            this.ColSaat.Visible = true;
            this.ColSaat.VisibleIndex = 4;
            this.ColSaat.Width = 57;
            // 
            // colACIKLAMA
            // 
            this.colACIKLAMA.Caption = "AÇIKLAMA";
            this.colACIKLAMA.FieldName = "ACIKLAMA";
            this.colACIKLAMA.Name = "colACIKLAMA";
            this.colACIKLAMA.OptionsColumn.AllowEdit = false;
            this.colACIKLAMA.Visible = true;
            this.colACIKLAMA.VisibleIndex = 2;
            this.colACIKLAMA.Width = 149;
            // 
            // FrmKasaHareket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1558, 669);
            this.Controls.Add(this.GrpMenu);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.LblBaslık);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKasaHareket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKasaHareket";
            this.Load += new System.EventHandler(this.FrmKasaHareket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContOdemeTuruToplam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOdemeTuruToplam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContKasaGenelToplam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKasaGenelToplam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrpMenu)).EndInit();
            this.GrpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn ColGenelToplam;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridContOdemeTuruToplam;
        private DevExpress.XtraGrid.Views.Grid.GridView gridOdemeTuruToplam;
        private DevExpress.XtraGrid.Columns.GridColumn ColOdemeTur;
        private DevExpress.XtraGrid.Columns.GridColumn ColKasaGırıs;
        private DevExpress.XtraGrid.Columns.GridColumn ColKasaCıkıs;
        private DevExpress.XtraGrid.Columns.GridColumn ColBakıye;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridContKasaGenelToplam;
        private DevExpress.XtraGrid.Views.Grid.GridView gridKasaGenelToplam;
        private DevExpress.XtraGrid.Columns.GridColumn ColGenelBılgı;
        private DevExpress.XtraGrid.Columns.GridColumn ColGenelKayıtSırası;
        private DevExpress.XtraEditors.GroupControl GrpMenu;
        private DevExpress.XtraEditors.SimpleButton BtnAra;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.SimpleButton BtnKapat;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.LabelControl LblBaslık;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colFISKOD;
        private DevExpress.XtraGrid.Columns.GridColumn colHAREKET;
        private DevExpress.XtraGrid.Columns.GridColumn colTOPLAMTUTAR;
        private DevExpress.XtraGrid.Columns.GridColumn colTARIH;
        private DevExpress.XtraGrid.Columns.GridColumn ColSaat;
        private DevExpress.XtraGrid.Columns.GridColumn colACIKLAMA;
    }
}