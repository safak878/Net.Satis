namespace NetSatıs.BackOffice.Depo
{
    partial class FrmDepoHareket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDepoHareket));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFISKOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHAREKET = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBIRIM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMIKTAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBIRIMFIYAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINDIRIMORAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colINDIRIMTUTAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTOPLAMTUTAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTARIH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColSAAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACIKLAMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColSEMT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColBARKOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColSTOKAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColSTOKGIRIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColSTOKCIKIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColMEVCUTSTOK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColBILGI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColKAYITSAYISI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColGenelToplam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GrpMenu = new DevExpress.XtraEditors.GroupControl();
            this.BtnAra = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BtnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.LblBaslık = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrpMenu)).BeginInit();
            this.GrpMenu.SuspendLayout();
            this.SuspendLayout();
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
            this.splitContainerControl1.Size = new System.Drawing.Size(1558, 541);
            this.splitContainerControl1.SplitterPosition = 229;
            this.splitContainerControl1.TabIndex = 9;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1558, 229);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colFISKOD,
            this.colHAREKET,
            this.colBIRIM,
            this.colMIKTAR,
            this.colKDV,
            this.colBIRIMFIYAT,
            this.colINDIRIMORAN,
            this.colINDIRIMTUTAR,
            this.colTOPLAMTUTAR,
            this.colTARIH,
            this.ColSAAT,
            this.colACIKLAMA,
            this.ColSEMT});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            // 
            // colFISKOD
            // 
            this.colFISKOD.FieldName = "FISKOD";
            this.colFISKOD.Name = "colFISKOD";
            this.colFISKOD.OptionsColumn.AllowEdit = false;
            this.colFISKOD.Visible = true;
            this.colFISKOD.VisibleIndex = 0;
            // 
            // colHAREKET
            // 
            this.colHAREKET.FieldName = "HAREKET";
            this.colHAREKET.Name = "colHAREKET";
            this.colHAREKET.OptionsColumn.AllowEdit = false;
            this.colHAREKET.Visible = true;
            this.colHAREKET.VisibleIndex = 1;
            // 
            // colBIRIM
            // 
            this.colBIRIM.FieldName = "BIRIM";
            this.colBIRIM.Name = "colBIRIM";
            this.colBIRIM.OptionsColumn.AllowEdit = false;
            this.colBIRIM.Visible = true;
            this.colBIRIM.VisibleIndex = 2;
            // 
            // colMIKTAR
            // 
            this.colMIKTAR.FieldName = "MIKTAR";
            this.colMIKTAR.Name = "colMIKTAR";
            this.colMIKTAR.OptionsColumn.AllowEdit = false;
            this.colMIKTAR.Visible = true;
            this.colMIKTAR.VisibleIndex = 8;
            // 
            // colKDV
            // 
            this.colKDV.FieldName = "KDV";
            this.colKDV.Name = "colKDV";
            this.colKDV.OptionsColumn.AllowEdit = false;
            this.colKDV.Visible = true;
            this.colKDV.VisibleIndex = 7;
            // 
            // colBIRIMFIYAT
            // 
            this.colBIRIMFIYAT.FieldName = "BIRIMFIYAT";
            this.colBIRIMFIYAT.Name = "colBIRIMFIYAT";
            this.colBIRIMFIYAT.OptionsColumn.AllowEdit = false;
            this.colBIRIMFIYAT.Visible = true;
            this.colBIRIMFIYAT.VisibleIndex = 9;
            // 
            // colINDIRIMORAN
            // 
            this.colINDIRIMORAN.FieldName = "INDIRIMORAN";
            this.colINDIRIMORAN.Name = "colINDIRIMORAN";
            this.colINDIRIMORAN.OptionsColumn.AllowEdit = false;
            this.colINDIRIMORAN.Visible = true;
            this.colINDIRIMORAN.VisibleIndex = 10;
            // 
            // colINDIRIMTUTAR
            // 
            this.colINDIRIMTUTAR.FieldName = "INDIRIMTUTAR";
            this.colINDIRIMTUTAR.Name = "colINDIRIMTUTAR";
            this.colINDIRIMTUTAR.OptionsColumn.AllowEdit = false;
            this.colINDIRIMTUTAR.Visible = true;
            this.colINDIRIMTUTAR.VisibleIndex = 11;
            // 
            // colTOPLAMTUTAR
            // 
            this.colTOPLAMTUTAR.FieldName = "TOPLAMTUTAR";
            this.colTOPLAMTUTAR.Name = "colTOPLAMTUTAR";
            this.colTOPLAMTUTAR.OptionsColumn.AllowEdit = false;
            this.colTOPLAMTUTAR.Visible = true;
            this.colTOPLAMTUTAR.VisibleIndex = 12;
            // 
            // colTARIH
            // 
            this.colTARIH.FieldName = "TARIH";
            this.colTARIH.GroupFormat.FormatString = "d";
            this.colTARIH.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTARIH.Name = "colTARIH";
            this.colTARIH.OptionsColumn.AllowEdit = false;
            this.colTARIH.Visible = true;
            this.colTARIH.VisibleIndex = 3;
            // 
            // ColSAAT
            // 
            this.ColSAAT.Caption = "SAAT";
            this.ColSAAT.FieldName = "TARIH";
            this.ColSAAT.GroupFormat.FormatString = "t";
            this.ColSAAT.GroupFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ColSAAT.Name = "ColSAAT";
            this.ColSAAT.OptionsColumn.AllowEdit = false;
            this.ColSAAT.Visible = true;
            this.ColSAAT.VisibleIndex = 4;
            // 
            // colACIKLAMA
            // 
            this.colACIKLAMA.FieldName = "ACIKLAMA";
            this.colACIKLAMA.Name = "colACIKLAMA";
            this.colACIKLAMA.OptionsColumn.AllowEdit = false;
            this.colACIKLAMA.Visible = true;
            this.colACIKLAMA.VisibleIndex = 6;
            // 
            // ColSEMT
            // 
            this.ColSEMT.Caption = "SEMT";
            this.ColSEMT.FieldName = "SEMT";
            this.ColSEMT.Name = "ColSEMT";
            this.ColSEMT.OptionsColumn.AllowEdit = false;
            this.ColSEMT.Visible = true;
            this.ColSEMT.VisibleIndex = 5;
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
            this.splitContainerControl2.Size = new System.Drawing.Size(1558, 302);
            this.splitContainerControl2.SplitterPosition = 806;
            this.splitContainerControl2.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(806, 302);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Depodaki Stok Miktarı";
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(2, 23);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(802, 277);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColBARKOD,
            this.ColSTOKAD,
            this.ColSTOKGIRIS,
            this.ColSTOKCIKIS,
            this.ColMEVCUTSTOK});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // ColBARKOD
            // 
            this.ColBARKOD.Caption = "BARKOD";
            this.ColBARKOD.FieldName = "BARKOD";
            this.ColBARKOD.Name = "ColBARKOD";
            this.ColBARKOD.OptionsColumn.AllowEdit = false;
            this.ColBARKOD.Visible = true;
            this.ColBARKOD.VisibleIndex = 0;
            // 
            // ColSTOKAD
            // 
            this.ColSTOKAD.Caption = "STOKAD";
            this.ColSTOKAD.FieldName = "STOKAD";
            this.ColSTOKAD.Name = "ColSTOKAD";
            this.ColSTOKAD.OptionsColumn.AllowEdit = false;
            this.ColSTOKAD.Visible = true;
            this.ColSTOKAD.VisibleIndex = 1;
            // 
            // ColSTOKGIRIS
            // 
            this.ColSTOKGIRIS.Caption = "STOKGIRIS";
            this.ColSTOKGIRIS.FieldName = "STOKGIRIS";
            this.ColSTOKGIRIS.Name = "ColSTOKGIRIS";
            this.ColSTOKGIRIS.OptionsColumn.AllowEdit = false;
            this.ColSTOKGIRIS.Visible = true;
            this.ColSTOKGIRIS.VisibleIndex = 2;
            // 
            // ColSTOKCIKIS
            // 
            this.ColSTOKCIKIS.Caption = "STOKCIKIS";
            this.ColSTOKCIKIS.FieldName = "STOKCIKIS";
            this.ColSTOKCIKIS.Name = "ColSTOKCIKIS";
            this.ColSTOKCIKIS.OptionsColumn.AllowEdit = false;
            this.ColSTOKCIKIS.Visible = true;
            this.ColSTOKCIKIS.VisibleIndex = 3;
            // 
            // ColMEVCUTSTOK
            // 
            this.ColMEVCUTSTOK.Caption = "MEVCUTSTOK";
            this.ColMEVCUTSTOK.FieldName = "MEVCUTSTOK";
            this.ColMEVCUTSTOK.Name = "ColMEVCUTSTOK";
            this.ColMEVCUTSTOK.OptionsColumn.AllowEdit = false;
            this.ColMEVCUTSTOK.Visible = true;
            this.ColMEVCUTSTOK.VisibleIndex = 4;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl3);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(742, 302);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Depo İstatistikleri";
            // 
            // gridControl3
            // 
            this.gridControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl3.Location = new System.Drawing.Point(2, 23);
            this.gridControl3.MainView = this.gridView3;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(738, 277);
            this.gridControl3.TabIndex = 0;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColBILGI,
            this.ColKAYITSAYISI,
            this.ColGenelToplam});
            this.gridView3.GridControl = this.gridControl3;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // ColBILGI
            // 
            this.ColBILGI.Caption = "BILGI";
            this.ColBILGI.FieldName = "BILGI";
            this.ColBILGI.Name = "ColBILGI";
            this.ColBILGI.Visible = true;
            this.ColBILGI.VisibleIndex = 0;
            // 
            // ColKAYITSAYISI
            // 
            this.ColKAYITSAYISI.Caption = "KAYITSAYISI";
            this.ColKAYITSAYISI.FieldName = "KAYITSAYISI";
            this.ColKAYITSAYISI.Name = "ColKAYITSAYISI";
            this.ColKAYITSAYISI.Visible = true;
            this.ColKAYITSAYISI.VisibleIndex = 1;
            // 
            // ColGenelToplam
            // 
            this.ColGenelToplam.Caption = "TOPLAMTUTAR";
            this.ColGenelToplam.FieldName = "TUTAR";
            this.ColGenelToplam.Name = "ColGenelToplam";
            this.ColGenelToplam.Visible = true;
            this.ColGenelToplam.VisibleIndex = 2;
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
            this.GrpMenu.TabIndex = 8;
            this.GrpMenu.Text = "Menü";
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
            this.LblBaslık.TabIndex = 7;
            this.LblBaslık.Text = "Depo Hareketleri";
            // 
            // FrmDepoHareket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1558, 669);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.GrpMenu);
            this.Controls.Add(this.LblBaslık);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDepoHareket";
            this.Text = "FrmDepoHareket";
            this.Load += new System.EventHandler(this.FrmDepoHareket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrpMenu)).EndInit();
            this.GrpMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colFISKOD;
        private DevExpress.XtraGrid.Columns.GridColumn colHAREKET;
        private DevExpress.XtraGrid.Columns.GridColumn colBIRIM;
        private DevExpress.XtraGrid.Columns.GridColumn colMIKTAR;
        private DevExpress.XtraGrid.Columns.GridColumn colKDV;
        private DevExpress.XtraGrid.Columns.GridColumn colBIRIMFIYAT;
        private DevExpress.XtraGrid.Columns.GridColumn colINDIRIMORAN;
        private DevExpress.XtraGrid.Columns.GridColumn colINDIRIMTUTAR;
        private DevExpress.XtraGrid.Columns.GridColumn colTOPLAMTUTAR;
        private DevExpress.XtraGrid.Columns.GridColumn colTARIH;
        private DevExpress.XtraGrid.Columns.GridColumn ColSAAT;
        private DevExpress.XtraGrid.Columns.GridColumn colACIKLAMA;
        private DevExpress.XtraGrid.Columns.GridColumn ColSEMT;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn ColBARKOD;
        private DevExpress.XtraGrid.Columns.GridColumn ColSTOKAD;
        private DevExpress.XtraGrid.Columns.GridColumn ColMEVCUTSTOK;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn ColBILGI;
        private DevExpress.XtraGrid.Columns.GridColumn ColKAYITSAYISI;
        private DevExpress.XtraGrid.Columns.GridColumn ColGenelToplam;
        private DevExpress.XtraEditors.GroupControl GrpMenu;
        private DevExpress.XtraEditors.SimpleButton BtnAra;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.SimpleButton BtnKapat;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.LabelControl LblBaslık;
        private DevExpress.XtraGrid.Columns.GridColumn ColSTOKGIRIS;
        private DevExpress.XtraGrid.Columns.GridColumn ColSTOKCIKIS;
    }
}