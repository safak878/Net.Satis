namespace NetSatıs.BackOffice.Cari
{
    partial class FrmCari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCari));
            this.panel1 = new System.Windows.Forms.Panel();
            this.filterControl1 = new DevExpress.XtraEditors.FilterControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDURUM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCARITUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCARIKOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCARIAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYETKILIKISI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFATURAUNVAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCEPTELEFON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTELEFON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFAX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMAIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWEB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colILCE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSEMT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADRES = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCARIGRUP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCARIALTGRUBU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOZELKOD1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOZELKOD2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOZELKOD3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOZELKOD4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVERGIDAIRE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVERGINO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colISKONTOORAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRISKLIMIT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colALISOZELFIYAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSATISOZELFIYAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACIKLAMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColAlacak = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cOLbIRC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColBakıye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GrpMenu = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BtnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAra = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKopyala = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSıl = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.LblBaslık = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrpMenu)).BeginInit();
            this.GrpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(399, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(8, 8);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // filterControl1
            // 
            this.filterControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.filterControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.filterControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterControl1.Location = new System.Drawing.Point(0, 0);
            this.filterControl1.Name = "filterControl1";
            this.filterControl1.Size = new System.Drawing.Size(1596, 168);
            this.filterControl1.SortFilterColumns = false;
            this.filterControl1.SourceControl = this.gridControl1;
            this.filterControl1.TabIndex = 0;
            this.filterControl1.Text = "filterControl1";
            this.filterControl1.Click += new System.EventHandler(this.filterControl1_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1596, 484);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colDURUM,
            this.colCARITUR,
            this.colCARIKOD,
            this.colCARIAD,
            this.colYETKILIKISI,
            this.colFATURAUNVAN,
            this.colCEPTELEFON,
            this.colTELEFON,
            this.colFAX,
            this.colEMAIL,
            this.colWEB,
            this.colIL,
            this.colILCE,
            this.colSEMT,
            this.colADRES,
            this.colCARIGRUP,
            this.colCARIALTGRUBU,
            this.colOZELKOD1,
            this.colOZELKOD2,
            this.colOZELKOD3,
            this.colOZELKOD4,
            this.colVERGIDAIRE,
            this.colVERGINO,
            this.colISKONTOORAN,
            this.colRISKLIMIT,
            this.colALISOZELFIYAT,
            this.colSATISOZELFIYAT,
            this.colACIKLAMA,
            this.ColAlacak,
            this.cOLbIRC,
            this.ColBakıye});
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
            // colDURUM
            // 
            this.colDURUM.FieldName = "DURUM";
            this.colDURUM.Name = "colDURUM";
            this.colDURUM.OptionsColumn.AllowEdit = false;
            this.colDURUM.Visible = true;
            this.colDURUM.VisibleIndex = 0;
            // 
            // colCARITUR
            // 
            this.colCARITUR.Caption = "CARITUR";
            this.colCARITUR.FieldName = "CARITUR";
            this.colCARITUR.Name = "colCARITUR";
            this.colCARITUR.OptionsColumn.AllowEdit = false;
            this.colCARITUR.Visible = true;
            this.colCARITUR.VisibleIndex = 1;
            // 
            // colCARIKOD
            // 
            this.colCARIKOD.Caption = "CARIKODU";
            this.colCARIKOD.FieldName = "CARIKOD";
            this.colCARIKOD.Name = "colCARIKOD";
            this.colCARIKOD.OptionsColumn.AllowEdit = false;
            this.colCARIKOD.Visible = true;
            this.colCARIKOD.VisibleIndex = 2;
            // 
            // colCARIAD
            // 
            this.colCARIAD.Caption = "CARIADI";
            this.colCARIAD.FieldName = "CARIAD";
            this.colCARIAD.Name = "colCARIAD";
            this.colCARIAD.OptionsColumn.AllowEdit = false;
            this.colCARIAD.Visible = true;
            this.colCARIAD.VisibleIndex = 3;
            // 
            // colYETKILIKISI
            // 
            this.colYETKILIKISI.Caption = "YETKILIKISI";
            this.colYETKILIKISI.FieldName = "YETKILIKISI";
            this.colYETKILIKISI.Name = "colYETKILIKISI";
            this.colYETKILIKISI.OptionsColumn.AllowEdit = false;
            this.colYETKILIKISI.Visible = true;
            this.colYETKILIKISI.VisibleIndex = 4;
            // 
            // colFATURAUNVAN
            // 
            this.colFATURAUNVAN.Caption = "FATURAUNVANI";
            this.colFATURAUNVAN.FieldName = "FATURAUNVAN";
            this.colFATURAUNVAN.Name = "colFATURAUNVAN";
            this.colFATURAUNVAN.OptionsColumn.AllowEdit = false;
            this.colFATURAUNVAN.Visible = true;
            this.colFATURAUNVAN.VisibleIndex = 5;
            // 
            // colCEPTELEFON
            // 
            this.colCEPTELEFON.Caption = "CEPTELEFONU";
            this.colCEPTELEFON.FieldName = "CEPTELEFON";
            this.colCEPTELEFON.Name = "colCEPTELEFON";
            this.colCEPTELEFON.OptionsColumn.AllowEdit = false;
            this.colCEPTELEFON.Visible = true;
            this.colCEPTELEFON.VisibleIndex = 6;
            // 
            // colTELEFON
            // 
            this.colTELEFON.Caption = "SABITTELEFON";
            this.colTELEFON.FieldName = "TELEFON";
            this.colTELEFON.Name = "colTELEFON";
            this.colTELEFON.OptionsColumn.AllowEdit = false;
            this.colTELEFON.Visible = true;
            this.colTELEFON.VisibleIndex = 7;
            // 
            // colFAX
            // 
            this.colFAX.Caption = "FAX";
            this.colFAX.FieldName = "FAX";
            this.colFAX.Name = "colFAX";
            this.colFAX.OptionsColumn.AllowEdit = false;
            // 
            // colEMAIL
            // 
            this.colEMAIL.Caption = "EMAIL";
            this.colEMAIL.FieldName = "EMAIL";
            this.colEMAIL.Name = "colEMAIL";
            this.colEMAIL.OptionsColumn.AllowEdit = false;
            // 
            // colWEB
            // 
            this.colWEB.Caption = "WEB";
            this.colWEB.FieldName = "WEB";
            this.colWEB.Name = "colWEB";
            this.colWEB.OptionsColumn.AllowEdit = false;
            // 
            // colIL
            // 
            this.colIL.Caption = "IL";
            this.colIL.FieldName = "IL";
            this.colIL.Name = "colIL";
            this.colIL.OptionsColumn.AllowEdit = false;
            // 
            // colILCE
            // 
            this.colILCE.Caption = "ILCE";
            this.colILCE.FieldName = "ILCE";
            this.colILCE.Name = "colILCE";
            this.colILCE.OptionsColumn.AllowEdit = false;
            // 
            // colSEMT
            // 
            this.colSEMT.Caption = "SEMPT";
            this.colSEMT.FieldName = "SEMT";
            this.colSEMT.Name = "colSEMT";
            this.colSEMT.OptionsColumn.AllowEdit = false;
            // 
            // colADRES
            // 
            this.colADRES.Caption = "ADRES";
            this.colADRES.FieldName = "ADRES";
            this.colADRES.Name = "colADRES";
            this.colADRES.OptionsColumn.AllowEdit = false;
            // 
            // colCARIGRUP
            // 
            this.colCARIGRUP.Caption = "CARIGRUP";
            this.colCARIGRUP.FieldName = "CARIGRUP";
            this.colCARIGRUP.Name = "colCARIGRUP";
            this.colCARIGRUP.OptionsColumn.AllowEdit = false;
            // 
            // colCARIALTGRUBU
            // 
            this.colCARIALTGRUBU.Caption = "CARIALTGRUBU";
            this.colCARIALTGRUBU.FieldName = "CARIALTGRUBU";
            this.colCARIALTGRUBU.Name = "colCARIALTGRUBU";
            this.colCARIALTGRUBU.OptionsColumn.AllowEdit = false;
            // 
            // colOZELKOD1
            // 
            this.colOZELKOD1.Caption = "OZELKOD1";
            this.colOZELKOD1.FieldName = "OZELKOD1";
            this.colOZELKOD1.Name = "colOZELKOD1";
            this.colOZELKOD1.OptionsColumn.AllowEdit = false;
            // 
            // colOZELKOD2
            // 
            this.colOZELKOD2.Caption = "OZELKOD2";
            this.colOZELKOD2.FieldName = "OZELKOD2";
            this.colOZELKOD2.Name = "colOZELKOD2";
            this.colOZELKOD2.OptionsColumn.AllowEdit = false;
            // 
            // colOZELKOD3
            // 
            this.colOZELKOD3.Caption = "OZELKOD3";
            this.colOZELKOD3.FieldName = "OZELKOD3";
            this.colOZELKOD3.Name = "colOZELKOD3";
            this.colOZELKOD3.OptionsColumn.AllowEdit = false;
            // 
            // colOZELKOD4
            // 
            this.colOZELKOD4.Caption = "OZELKOD4";
            this.colOZELKOD4.FieldName = "OZELKOD4";
            this.colOZELKOD4.Name = "colOZELKOD4";
            this.colOZELKOD4.OptionsColumn.AllowEdit = false;
            // 
            // colVERGIDAIRE
            // 
            this.colVERGIDAIRE.Caption = "VERGIDAIRESI";
            this.colVERGIDAIRE.FieldName = "VERGIDAIRE";
            this.colVERGIDAIRE.Name = "colVERGIDAIRE";
            this.colVERGIDAIRE.OptionsColumn.AllowEdit = false;
            // 
            // colVERGINO
            // 
            this.colVERGINO.Caption = "VERGINUMARASI";
            this.colVERGINO.FieldName = "VERGINO";
            this.colVERGINO.Name = "colVERGINO";
            this.colVERGINO.OptionsColumn.AllowEdit = false;
            // 
            // colISKONTOORAN
            // 
            this.colISKONTOORAN.Caption = "ISKONTOORANI";
            this.colISKONTOORAN.DisplayFormat.FormatString = "\'%\'0";
            this.colISKONTOORAN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colISKONTOORAN.FieldName = "ISKONTOORAN";
            this.colISKONTOORAN.Name = "colISKONTOORAN";
            this.colISKONTOORAN.OptionsColumn.AllowEdit = false;
            this.colISKONTOORAN.Visible = true;
            this.colISKONTOORAN.VisibleIndex = 8;
            // 
            // colRISKLIMIT
            // 
            this.colRISKLIMIT.Caption = "RISKLIMITI";
            this.colRISKLIMIT.DisplayFormat.FormatString = "C2";
            this.colRISKLIMIT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRISKLIMIT.FieldName = "RISKLIMIT";
            this.colRISKLIMIT.Name = "colRISKLIMIT";
            this.colRISKLIMIT.OptionsColumn.AllowEdit = false;
            this.colRISKLIMIT.Visible = true;
            this.colRISKLIMIT.VisibleIndex = 9;
            // 
            // colALISOZELFIYAT
            // 
            this.colALISOZELFIYAT.Caption = "ALISOZELFIYAT";
            this.colALISOZELFIYAT.FieldName = "ALISOZELFIYAT";
            this.colALISOZELFIYAT.Name = "colALISOZELFIYAT";
            this.colALISOZELFIYAT.OptionsColumn.AllowEdit = false;
            // 
            // colSATISOZELFIYAT
            // 
            this.colSATISOZELFIYAT.Caption = "SATISOZELFIYAT";
            this.colSATISOZELFIYAT.FieldName = "SATISOZELFIYAT";
            this.colSATISOZELFIYAT.Name = "colSATISOZELFIYAT";
            this.colSATISOZELFIYAT.OptionsColumn.AllowEdit = false;
            // 
            // colACIKLAMA
            // 
            this.colACIKLAMA.FieldName = "ACIKLAMA";
            this.colACIKLAMA.Name = "colACIKLAMA";
            this.colACIKLAMA.OptionsColumn.AllowEdit = false;
            this.colACIKLAMA.Visible = true;
            this.colACIKLAMA.VisibleIndex = 10;
            // 
            // ColAlacak
            // 
            this.ColAlacak.Caption = "ALACAK";
            this.ColAlacak.FieldName = "ALACAK";
            this.ColAlacak.Name = "ColAlacak";
            this.ColAlacak.OptionsColumn.AllowEdit = false;
            this.ColAlacak.Visible = true;
            this.ColAlacak.VisibleIndex = 13;
            // 
            // cOLbIRC
            // 
            this.cOLbIRC.Caption = "BORC";
            this.cOLbIRC.FieldName = "BORC";
            this.cOLbIRC.Name = "cOLbIRC";
            this.cOLbIRC.OptionsColumn.AllowEdit = false;
            this.cOLbIRC.Visible = true;
            this.cOLbIRC.VisibleIndex = 12;
            // 
            // ColBakıye
            // 
            this.ColBakıye.Caption = "BAKIYE";
            this.ColBakıye.FieldName = "BAKIYE";
            this.ColBakıye.Name = "ColBakıye";
            this.ColBakıye.OptionsColumn.AllowEdit = false;
            this.ColBakıye.Visible = true;
            this.ColBakıye.VisibleIndex = 11;
            // 
            // GrpMenu
            // 
            this.GrpMenu.Controls.Add(this.simpleButton4);
            this.GrpMenu.Controls.Add(this.BtnKapat);
            this.GrpMenu.Controls.Add(this.BtnAra);
            this.GrpMenu.Controls.Add(this.BtnGuncelle);
            this.GrpMenu.Controls.Add(this.BtnKopyala);
            this.GrpMenu.Controls.Add(this.BtnSıl);
            this.GrpMenu.Controls.Add(this.BtnDuzenle);
            this.GrpMenu.Controls.Add(this.BtnEkle);
            this.GrpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GrpMenu.Location = new System.Drawing.Point(0, 642);
            this.GrpMenu.Name = "GrpMenu";
            this.GrpMenu.Size = new System.Drawing.Size(1596, 74);
            this.GrpMenu.TabIndex = 4;
            this.GrpMenu.Text = "groupControl1";
            this.GrpMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.GrpMenu_Paint);
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageOptions.ImageIndex = 3;
            this.simpleButton4.ImageOptions.ImageList = this.ımageList1;
            this.simpleButton4.Location = new System.Drawing.Point(437, 26);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(102, 42);
            this.simpleButton4.TabIndex = 7;
            this.simpleButton4.Text = "CARİ \r\nHAREKET";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Cari Bilgi.png");
            this.ımageList1.Images.SetKeyName(1, "Cari Düzenle.png");
            this.ımageList1.Images.SetKeyName(2, "Cari Ekle.png");
            this.ımageList1.Images.SetKeyName(3, "Cari Hareket.png");
            this.ımageList1.Images.SetKeyName(4, "cari kpyala.png");
            this.ımageList1.Images.SetKeyName(5, "Cari Sil.png");
            this.ımageList1.Images.SetKeyName(6, "folder_out.png");
            this.ımageList1.Images.SetKeyName(7, "funnel.png");
            this.ımageList1.Images.SetKeyName(8, "funnel_delete.png");
            this.ımageList1.Images.SetKeyName(9, "information.png");
            this.ımageList1.Images.SetKeyName(10, "redo.png");
            this.ımageList1.Images.SetKeyName(11, "refresh.png");
            this.ımageList1.Images.SetKeyName(12, "replace2.png");
            this.ımageList1.Images.SetKeyName(13, "user.png");
            this.ımageList1.Images.SetKeyName(14, "view.png");
            // 
            // BtnKapat
            // 
            this.BtnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnKapat.ImageOptions.ImageIndex = 6;
            this.BtnKapat.ImageOptions.ImageList = this.ımageList1;
            this.BtnKapat.Location = new System.Drawing.Point(1489, 26);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(102, 42);
            this.BtnKapat.TabIndex = 6;
            this.BtnKapat.Text = "KAPAT";
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // BtnAra
            // 
            this.BtnAra.ImageOptions.ImageIndex = 14;
            this.BtnAra.ImageOptions.ImageList = this.ımageList1;
            this.BtnAra.Location = new System.Drawing.Point(653, 26);
            this.BtnAra.Name = "BtnAra";
            this.BtnAra.Size = new System.Drawing.Size(108, 42);
            this.BtnAra.TabIndex = 5;
            this.BtnAra.Text = "ARA";
            this.BtnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.ImageOptions.ImageIndex = 11;
            this.BtnGuncelle.ImageOptions.ImageList = this.ımageList1;
            this.BtnGuncelle.Location = new System.Drawing.Point(545, 26);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(102, 42);
            this.BtnGuncelle.TabIndex = 4;
            this.BtnGuncelle.Text = "GÜNCELLE";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnKopyala
            // 
            this.BtnKopyala.ImageOptions.ImageIndex = 4;
            this.BtnKopyala.ImageOptions.ImageList = this.ımageList1;
            this.BtnKopyala.Location = new System.Drawing.Point(329, 26);
            this.BtnKopyala.Name = "BtnKopyala";
            this.BtnKopyala.Size = new System.Drawing.Size(102, 42);
            this.BtnKopyala.TabIndex = 3;
            this.BtnKopyala.Text = "KOPYALA";
            this.BtnKopyala.Click += new System.EventHandler(this.BtnKopyala_Click);
            // 
            // BtnSıl
            // 
            this.BtnSıl.ImageOptions.ImageIndex = 5;
            this.BtnSıl.ImageOptions.ImageList = this.ımageList1;
            this.BtnSıl.Location = new System.Drawing.Point(221, 26);
            this.BtnSıl.Name = "BtnSıl";
            this.BtnSıl.Size = new System.Drawing.Size(102, 42);
            this.BtnSıl.TabIndex = 2;
            this.BtnSıl.Text = "SİL";
            this.BtnSıl.Click += new System.EventHandler(this.BtnSıl_Click);
            // 
            // BtnDuzenle
            // 
            this.BtnDuzenle.ImageOptions.ImageIndex = 1;
            this.BtnDuzenle.ImageOptions.ImageList = this.ımageList1;
            this.BtnDuzenle.Location = new System.Drawing.Point(113, 26);
            this.BtnDuzenle.Name = "BtnDuzenle";
            this.BtnDuzenle.Size = new System.Drawing.Size(102, 42);
            this.BtnDuzenle.TabIndex = 1;
            this.BtnDuzenle.Text = "DÜZENLE";
            this.BtnDuzenle.Click += new System.EventHandler(this.BtnDuzenle_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.ImageOptions.ImageIndex = 2;
            this.BtnEkle.ImageOptions.ImageList = this.ımageList1;
            this.BtnEkle.Location = new System.Drawing.Point(5, 26);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(102, 42);
            this.BtnEkle.TabIndex = 0;
            this.BtnEkle.Text = "EKLE";
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton3.ImageOptions.ImageIndex = 6;
            this.simpleButton3.ImageOptions.ImageList = this.ımageList1;
            this.simpleButton3.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton3.Location = new System.Drawing.Point(1530, 124);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(61, 42);
            this.simpleButton3.TabIndex = 8;
            this.simpleButton3.Text = "ARA";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.ImageOptions.ImageIndex = 8;
            this.simpleButton2.ImageOptions.ImageList = this.ımageList1;
            this.simpleButton2.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton2.Location = new System.Drawing.Point(1463, 124);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(61, 42);
            this.simpleButton2.TabIndex = 7;
            this.simpleButton2.Text = "ARA";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.ImageOptions.ImageIndex = 7;
            this.simpleButton1.ImageOptions.ImageList = this.ımageList1;
            this.simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton1.Location = new System.Drawing.Point(1396, 124);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(61, 42);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "ARA";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 54);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.simpleButton3);
            this.splitContainerControl1.Panel1.Controls.Add(this.simpleButton2);
            this.splitContainerControl1.Panel1.Controls.Add(this.simpleButton1);
            this.splitContainerControl1.Panel1.Controls.Add(this.filterControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.panel1);
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1596, 662);
            this.splitContainerControl1.SplitterPosition = 168;
            this.splitContainerControl1.TabIndex = 5;
            this.splitContainerControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainerControl1_Paint);
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
            this.LblBaslık.Size = new System.Drawing.Size(1596, 54);
            this.LblBaslık.TabIndex = 3;
            this.LblBaslık.Text = "Cari Kartları";
            this.LblBaslık.Click += new System.EventHandler(this.LblBaslık_Click);
            // 
            // FrmCari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1596, 716);
            this.Controls.Add(this.GrpMenu);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.LblBaslık);
            this.Name = "FrmCari";
            this.Text = "FrmCari";
            this.Load += new System.EventHandler(this.FrmCari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrpMenu)).EndInit();
            this.GrpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.FilterControl filterControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl GrpMenu;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton BtnKapat;
        private DevExpress.XtraEditors.SimpleButton BtnAra;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnKopyala;
        private DevExpress.XtraEditors.SimpleButton BtnSıl;
        private DevExpress.XtraEditors.SimpleButton BtnDuzenle;
        private DevExpress.XtraEditors.SimpleButton BtnEkle;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colDURUM;
        private DevExpress.XtraGrid.Columns.GridColumn colCARITUR;
        private DevExpress.XtraGrid.Columns.GridColumn colCARIKOD;
        private DevExpress.XtraGrid.Columns.GridColumn colCARIAD;
        private DevExpress.XtraGrid.Columns.GridColumn colYETKILIKISI;
        private DevExpress.XtraGrid.Columns.GridColumn colFATURAUNVAN;
        private DevExpress.XtraGrid.Columns.GridColumn colCEPTELEFON;
        private DevExpress.XtraGrid.Columns.GridColumn colTELEFON;
        private DevExpress.XtraGrid.Columns.GridColumn colFAX;
        private DevExpress.XtraGrid.Columns.GridColumn colEMAIL;
        private DevExpress.XtraGrid.Columns.GridColumn colWEB;
        private DevExpress.XtraGrid.Columns.GridColumn colIL;
        private DevExpress.XtraGrid.Columns.GridColumn colILCE;
        private DevExpress.XtraGrid.Columns.GridColumn colSEMT;
        private DevExpress.XtraGrid.Columns.GridColumn colADRES;
        private DevExpress.XtraGrid.Columns.GridColumn colCARIGRUP;
        private DevExpress.XtraGrid.Columns.GridColumn colCARIALTGRUBU;
        private DevExpress.XtraGrid.Columns.GridColumn colOZELKOD1;
        private DevExpress.XtraGrid.Columns.GridColumn colOZELKOD2;
        private DevExpress.XtraGrid.Columns.GridColumn colOZELKOD3;
        private DevExpress.XtraGrid.Columns.GridColumn colOZELKOD4;
        private DevExpress.XtraGrid.Columns.GridColumn colVERGIDAIRE;
        private DevExpress.XtraGrid.Columns.GridColumn colVERGINO;
        private DevExpress.XtraGrid.Columns.GridColumn colISKONTOORAN;
        private DevExpress.XtraGrid.Columns.GridColumn colRISKLIMIT;
        private DevExpress.XtraGrid.Columns.GridColumn colALISOZELFIYAT;
        private DevExpress.XtraGrid.Columns.GridColumn colSATISOZELFIYAT;
        private DevExpress.XtraGrid.Columns.GridColumn colACIKLAMA;
        private DevExpress.XtraGrid.Columns.GridColumn ColAlacak;
        private DevExpress.XtraGrid.Columns.GridColumn cOLbIRC;
        private DevExpress.XtraGrid.Columns.GridColumn ColBakıye;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.LabelControl LblBaslık;
    }
}