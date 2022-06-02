namespace NetSatıs.BackOffice.Cari
{
    partial class FrmCariHareket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCariHareket));
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.GridcontFısToplam = new DevExpress.XtraGrid.GridControl();
            this.GridFisToplam = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColFışTuruKayıtSayısı = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColFısTuruToplamTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColFısturuBılgı = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.GridcontBakiye = new DevExpress.XtraGrid.GridControl();
            this.GridBakıye = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColGenelBılgı = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColGenelToplam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GrpMenu = new DevExpress.XtraEditors.GroupControl();
            this.BtnAra = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BtnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.LblBaslık = new DevExpress.XtraEditors.LabelControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.GridcontCarıHareket = new DevExpress.XtraGrid.GridControl();
            this.GridCarıHareket = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFISKOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFISTUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBELGENO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTARIH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColSaat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLASIYERKOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPLASIYERAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colISKONTOORAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colISKONTUTAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTOPLAMTUTAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACIKLAMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColOdenen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColKalanTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridcontFısToplam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridFisToplam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridcontBakiye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridBakıye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrpMenu)).BeginInit();
            this.GrpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridcontCarıHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCarıHareket)).BeginInit();
            this.SuspendLayout();
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
            this.groupControl1.Controls.Add(this.GridcontFısToplam);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(806, 376);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Fiş Türlerine Göre Toplamlar";
            // 
            // GridcontFısToplam
            // 
            this.GridcontFısToplam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridcontFısToplam.Location = new System.Drawing.Point(2, 23);
            this.GridcontFısToplam.MainView = this.GridFisToplam;
            this.GridcontFısToplam.Name = "GridcontFısToplam";
            this.GridcontFısToplam.Size = new System.Drawing.Size(802, 351);
            this.GridcontFısToplam.TabIndex = 2;
            this.GridcontFısToplam.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridFisToplam});
            // 
            // GridFisToplam
            // 
            this.GridFisToplam.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColFışTuruKayıtSayısı,
            this.ColFısTuruToplamTutar,
            this.ColFısturuBılgı});
            this.GridFisToplam.GridControl = this.GridcontFısToplam;
            this.GridFisToplam.Name = "GridFisToplam";
            this.GridFisToplam.OptionsView.ShowGroupPanel = false;
            // 
            // ColFışTuruKayıtSayısı
            // 
            this.ColFışTuruKayıtSayısı.Caption = "KAYITSAYISI";
            this.ColFışTuruKayıtSayısı.FieldName = "KAYITSAYISI";
            this.ColFışTuruKayıtSayısı.Name = "ColFışTuruKayıtSayısı";
            this.ColFışTuruKayıtSayısı.Visible = true;
            this.ColFışTuruKayıtSayısı.VisibleIndex = 0;
            // 
            // ColFısTuruToplamTutar
            // 
            this.ColFısTuruToplamTutar.Caption = "TOPLAMTUTAR";
            this.ColFısTuruToplamTutar.DisplayFormat.FormatString = "C2";
            this.ColFısTuruToplamTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ColFısTuruToplamTutar.FieldName = "TUTAR";
            this.ColFısTuruToplamTutar.Name = "ColFısTuruToplamTutar";
            this.ColFısTuruToplamTutar.Visible = true;
            this.ColFısTuruToplamTutar.VisibleIndex = 1;
            // 
            // ColFısturuBılgı
            // 
            this.ColFısturuBılgı.Caption = "BILGI";
            this.ColFısturuBılgı.DisplayFormat.FormatString = "C2";
            this.ColFısturuBılgı.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ColFısturuBılgı.FieldName = "BILGI";
            this.ColFısturuBılgı.Name = "ColFısturuBılgı";
            this.ColFısturuBılgı.Visible = true;
            this.ColFısturuBılgı.VisibleIndex = 2;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.GridcontBakiye);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(742, 376);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Cari Ekstreleri";
            // 
            // GridcontBakiye
            // 
            this.GridcontBakiye.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridcontBakiye.Location = new System.Drawing.Point(2, 23);
            this.GridcontBakiye.MainView = this.GridBakıye;
            this.GridcontBakiye.Name = "GridcontBakiye";
            this.GridcontBakiye.Size = new System.Drawing.Size(738, 351);
            this.GridcontBakiye.TabIndex = 2;
            this.GridcontBakiye.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridBakıye});
            // 
            // GridBakıye
            // 
            this.GridBakıye.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColGenelBılgı,
            this.ColGenelToplam});
            this.GridBakıye.GridControl = this.GridcontBakiye;
            this.GridBakıye.Name = "GridBakıye";
            this.GridBakıye.OptionsView.ShowGroupPanel = false;
            // 
            // ColGenelBılgı
            // 
            this.ColGenelBılgı.Caption = "BILGI";
            this.ColGenelBılgı.FieldName = "BILGI";
            this.ColGenelBılgı.Name = "ColGenelBılgı";
            this.ColGenelBılgı.Visible = true;
            this.ColGenelBılgı.VisibleIndex = 0;
            // 
            // ColGenelToplam
            // 
            this.ColGenelToplam.Caption = "TOPLAM";
            this.ColGenelToplam.DisplayFormat.FormatString = "C2";
            this.ColGenelToplam.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ColGenelToplam.FieldName = "TUTAR";
            this.ColGenelToplam.Name = "ColGenelToplam";
            this.ColGenelToplam.Visible = true;
            this.ColGenelToplam.VisibleIndex = 1;
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
            this.LblBaslık.TabIndex = 4;
            this.LblBaslık.Text = "Cari Hareketleri";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 54);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.GridcontCarıHareket);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1558, 615);
            this.splitContainerControl1.SplitterPosition = 229;
            this.splitContainerControl1.TabIndex = 6;
            // 
            // GridcontCarıHareket
            // 
            this.GridcontCarıHareket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridcontCarıHareket.Location = new System.Drawing.Point(0, 0);
            this.GridcontCarıHareket.MainView = this.GridCarıHareket;
            this.GridcontCarıHareket.Name = "GridcontCarıHareket";
            this.GridcontCarıHareket.Size = new System.Drawing.Size(1558, 229);
            this.GridcontCarıHareket.TabIndex = 1;
            this.GridcontCarıHareket.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridCarıHareket});
            // 
            // GridCarıHareket
            // 
            this.GridCarıHareket.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colFISKOD,
            this.colFISTUR,
            this.colBELGENO,
            this.colTARIH,
            this.ColSaat,
            this.colPLASIYERKOD,
            this.colPLASIYERAD,
            this.colISKONTOORAN,
            this.colISKONTUTAR,
            this.colTOPLAMTUTAR,
            this.colACIKLAMA,
            this.ColOdenen,
            this.ColKalanTutar});
            this.GridCarıHareket.GridControl = this.GridcontCarıHareket;
            this.GridCarıHareket.Name = "GridCarıHareket";
            this.GridCarıHareket.OptionsView.ShowGroupPanel = false;
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
            this.colFISKOD.Caption = "FISKODU";
            this.colFISKOD.FieldName = "FISKOD";
            this.colFISKOD.Name = "colFISKOD";
            this.colFISKOD.OptionsColumn.AllowEdit = false;
            this.colFISKOD.Visible = true;
            this.colFISKOD.VisibleIndex = 0;
            this.colFISKOD.Width = 139;
            // 
            // colFISTUR
            // 
            this.colFISTUR.Caption = "FISTUR";
            this.colFISTUR.FieldName = "FISTUR";
            this.colFISTUR.Name = "colFISTUR";
            this.colFISTUR.OptionsColumn.AllowEdit = false;
            this.colFISTUR.Visible = true;
            this.colFISTUR.VisibleIndex = 1;
            this.colFISTUR.Width = 139;
            // 
            // colBELGENO
            // 
            this.colBELGENO.Caption = "BELGENO";
            this.colBELGENO.FieldName = "BELGENO";
            this.colBELGENO.Name = "colBELGENO";
            this.colBELGENO.OptionsColumn.AllowEdit = false;
            this.colBELGENO.Visible = true;
            this.colBELGENO.VisibleIndex = 2;
            this.colBELGENO.Width = 139;
            // 
            // colTARIH
            // 
            this.colTARIH.DisplayFormat.FormatString = "d";
            this.colTARIH.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTARIH.FieldName = "TARIH";
            this.colTARIH.Name = "colTARIH";
            this.colTARIH.OptionsColumn.AllowEdit = false;
            this.colTARIH.Visible = true;
            this.colTARIH.VisibleIndex = 3;
            this.colTARIH.Width = 139;
            // 
            // ColSaat
            // 
            this.ColSaat.Caption = "SAAT";
            this.ColSaat.DisplayFormat.FormatString = "t";
            this.ColSaat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.ColSaat.FieldName = "TARIH";
            this.ColSaat.Name = "ColSaat";
            this.ColSaat.OptionsColumn.AllowEdit = false;
            this.ColSaat.Visible = true;
            this.ColSaat.VisibleIndex = 4;
            this.ColSaat.Width = 139;
            // 
            // colPLASIYERKOD
            // 
            this.colPLASIYERKOD.Caption = "PLASIYERKOD";
            this.colPLASIYERKOD.FieldName = "PLASIYERKOD";
            this.colPLASIYERKOD.Name = "colPLASIYERKOD";
            this.colPLASIYERKOD.OptionsColumn.AllowEdit = false;
            this.colPLASIYERKOD.Visible = true;
            this.colPLASIYERKOD.VisibleIndex = 5;
            // 
            // colPLASIYERAD
            // 
            this.colPLASIYERAD.Caption = "PLASIYERAD";
            this.colPLASIYERAD.FieldName = "PLASIYERAD";
            this.colPLASIYERAD.Name = "colPLASIYERAD";
            this.colPLASIYERAD.OptionsColumn.AllowEdit = false;
            this.colPLASIYERAD.Visible = true;
            this.colPLASIYERAD.VisibleIndex = 6;
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
            this.colISKONTOORAN.VisibleIndex = 7;
            this.colISKONTOORAN.Width = 139;
            // 
            // colISKONTUTAR
            // 
            this.colISKONTUTAR.Caption = "ISKONTOTUTAR";
            this.colISKONTUTAR.DisplayFormat.FormatString = "C2";
            this.colISKONTUTAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colISKONTUTAR.FieldName = "ISKONTOTUTAR";
            this.colISKONTUTAR.Name = "colISKONTUTAR";
            this.colISKONTUTAR.OptionsColumn.AllowEdit = false;
            this.colISKONTUTAR.Visible = true;
            this.colISKONTUTAR.VisibleIndex = 8;
            this.colISKONTUTAR.Width = 139;
            // 
            // colTOPLAMTUTAR
            // 
            this.colTOPLAMTUTAR.Caption = "TOPLAMTUTAR";
            this.colTOPLAMTUTAR.DisplayFormat.FormatString = "C2";
            this.colTOPLAMTUTAR.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTOPLAMTUTAR.FieldName = "TOPLAMTUTAR";
            this.colTOPLAMTUTAR.Name = "colTOPLAMTUTAR";
            this.colTOPLAMTUTAR.OptionsColumn.AllowEdit = false;
            this.colTOPLAMTUTAR.Visible = true;
            this.colTOPLAMTUTAR.VisibleIndex = 9;
            this.colTOPLAMTUTAR.Width = 101;
            // 
            // colACIKLAMA
            // 
            this.colACIKLAMA.Caption = "ACIKLAMA";
            this.colACIKLAMA.FieldName = "ACIKLAMA";
            this.colACIKLAMA.Name = "colACIKLAMA";
            this.colACIKLAMA.OptionsColumn.AllowEdit = false;
            this.colACIKLAMA.Visible = true;
            this.colACIKLAMA.VisibleIndex = 10;
            this.colACIKLAMA.Width = 254;
            // 
            // ColOdenen
            // 
            this.ColOdenen.Caption = "ODENENTUTAR";
            this.ColOdenen.DisplayFormat.FormatString = "C2";
            this.ColOdenen.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ColOdenen.FieldName = "Odenen";
            this.ColOdenen.Name = "ColOdenen";
            this.ColOdenen.OptionsColumn.AllowEdit = false;
            this.ColOdenen.Visible = true;
            this.ColOdenen.VisibleIndex = 11;
            this.ColOdenen.Width = 104;
            // 
            // ColKalanTutar
            // 
            this.ColKalanTutar.Caption = "KALANTUTAR";
            this.ColKalanTutar.DisplayFormat.FormatString = "C2";
            this.ColKalanTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ColKalanTutar.FieldName = "KalanOdeme";
            this.ColKalanTutar.Name = "ColKalanTutar";
            this.ColKalanTutar.OptionsColumn.AllowEdit = false;
            this.ColKalanTutar.Visible = true;
            this.ColKalanTutar.VisibleIndex = 12;
            this.ColKalanTutar.Width = 101;
            // 
            // FrmCariHareket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1558, 669);
            this.Controls.Add(this.GrpMenu);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.LblBaslık);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCariHareket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCariHareket";
            this.Load += new System.EventHandler(this.FrmCariHareket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridcontFısToplam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridFisToplam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridcontBakiye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridBakıye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrpMenu)).EndInit();
            this.GrpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridcontCarıHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCarıHareket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl GridcontFısToplam;
        private DevExpress.XtraGrid.Views.Grid.GridView GridFisToplam;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl GridcontBakiye;
        private DevExpress.XtraGrid.Views.Grid.GridView GridBakıye;
        private DevExpress.XtraEditors.GroupControl GrpMenu;
        private DevExpress.XtraEditors.SimpleButton BtnAra;
        private DevExpress.XtraEditors.SimpleButton BtnKapat;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.LabelControl LblBaslık;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl GridcontCarıHareket;
        private DevExpress.XtraGrid.Views.Grid.GridView GridCarıHareket;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colFISKOD;
        private DevExpress.XtraGrid.Columns.GridColumn colFISTUR;
        private DevExpress.XtraGrid.Columns.GridColumn colBELGENO;
        private DevExpress.XtraGrid.Columns.GridColumn colTARIH;
        private DevExpress.XtraGrid.Columns.GridColumn ColSaat;
        private DevExpress.XtraGrid.Columns.GridColumn colPLASIYERKOD;
        private DevExpress.XtraGrid.Columns.GridColumn colPLASIYERAD;
        private DevExpress.XtraGrid.Columns.GridColumn colISKONTOORAN;
        private DevExpress.XtraGrid.Columns.GridColumn colISKONTUTAR;
        private DevExpress.XtraGrid.Columns.GridColumn colTOPLAMTUTAR;
        private DevExpress.XtraGrid.Columns.GridColumn colACIKLAMA;
        private DevExpress.XtraGrid.Columns.GridColumn ColOdenen;
        private DevExpress.XtraGrid.Columns.GridColumn ColKalanTutar;
        private DevExpress.XtraGrid.Columns.GridColumn ColFışTuruKayıtSayısı;
        private DevExpress.XtraGrid.Columns.GridColumn ColFısTuruToplamTutar;
        private DevExpress.XtraGrid.Columns.GridColumn ColFısturuBılgı;
        private DevExpress.XtraGrid.Columns.GridColumn ColGenelBılgı;
        private DevExpress.XtraGrid.Columns.GridColumn ColGenelToplam;
    }
}