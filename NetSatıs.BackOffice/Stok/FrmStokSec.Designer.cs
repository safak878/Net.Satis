namespace NetSatıs.BackOffice.Stok
{
    partial class FrmStokSec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStokSec));
            this.LblBaslık = new DevExpress.XtraEditors.LabelControl();
            this.GrupMenu = new DevExpress.XtraEditors.GroupControl();
            this.lblUyarı = new DevExpress.XtraEditors.LabelControl();
            this.BtnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BtnSec = new DevExpress.XtraEditors.SimpleButton();
            this.gridcontStoklar = new DevExpress.XtraGrid.GridControl();
            this.gridstoklar = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDURUM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTOKKODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTOKAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBARKOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBARKODTUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBIRIM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTOKGRUP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTOKALTGRUP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMARKA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMODEL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOZELKOD1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOZELKOD2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOZELKOD3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOZELKOD4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGARANTISURE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colURETICIKOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colALISKDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSATISKDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colALISFIYAT1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colALISFIYAT2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colALISFIYAT3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSATISFIYAT1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSATISFIYAT2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSATISFIYAT3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMINSTOKMIKTAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAXSTOKMIKTAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACIKLAMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GrupMenu)).BeginInit();
            this.GrupMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridcontStoklar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridstoklar)).BeginInit();
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
            this.LblBaslık.Location = new System.Drawing.Point(0, 0);
            this.LblBaslık.Name = "LblBaslık";
            this.LblBaslık.Size = new System.Drawing.Size(1673, 54);
            this.LblBaslık.TabIndex = 2;
            this.LblBaslık.Text = "Stok Seçim Ekranı";
            // 
            // GrupMenu
            // 
            this.GrupMenu.Controls.Add(this.lblUyarı);
            this.GrupMenu.Controls.Add(this.BtnKapat);
            this.GrupMenu.Controls.Add(this.BtnSec);
            this.GrupMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GrupMenu.Location = new System.Drawing.Point(0, 470);
            this.GrupMenu.Name = "GrupMenu";
            this.GrupMenu.Size = new System.Drawing.Size(1673, 75);
            this.GrupMenu.TabIndex = 3;
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
            // 
            // BtnKapat
            // 
            this.BtnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnKapat.ImageOptions.ImageIndex = 1;
            this.BtnKapat.ImageOptions.ImageList = this.ımageList1;
            this.BtnKapat.Location = new System.Drawing.Point(1564, 32);
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
            this.BtnSec.ImageOptions.ImageIndex = 0;
            this.BtnSec.ImageOptions.ImageList = this.ımageList1;
            this.BtnSec.Location = new System.Drawing.Point(1450, 32);
            this.BtnSec.Name = "BtnSec";
            this.BtnSec.Size = new System.Drawing.Size(108, 31);
            this.BtnSec.TabIndex = 5;
            this.BtnSec.Text = "SEÇ";
            this.BtnSec.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // gridcontStoklar
            // 
            this.gridcontStoklar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridcontStoklar.Location = new System.Drawing.Point(0, 54);
            this.gridcontStoklar.MainView = this.gridstoklar;
            this.gridcontStoklar.Name = "gridcontStoklar";
            this.gridcontStoklar.Size = new System.Drawing.Size(1673, 416);
            this.gridcontStoklar.TabIndex = 4;
            this.gridcontStoklar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridstoklar});
            // 
            // gridstoklar
            // 
            this.gridstoklar.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colDURUM,
            this.colSTOKKODU,
            this.colSTOKAD,
            this.colBARKOD,
            this.colBARKODTUR,
            this.colBIRIM,
            this.colSTOKGRUP,
            this.colSTOKALTGRUP,
            this.colMARKA,
            this.colMODEL,
            this.colOZELKOD1,
            this.colOZELKOD2,
            this.colOZELKOD3,
            this.colOZELKOD4,
            this.colGARANTISURE,
            this.colURETICIKOD,
            this.colALISKDV,
            this.colSATISKDV,
            this.colALISFIYAT1,
            this.colALISFIYAT2,
            this.colALISFIYAT3,
            this.colSATISFIYAT1,
            this.colSATISFIYAT2,
            this.colSATISFIYAT3,
            this.colMINSTOKMIKTAR,
            this.colMAXSTOKMIKTAR,
            this.colACIKLAMA,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridstoklar.GridControl = this.gridcontStoklar;
            this.gridstoklar.Name = "gridstoklar";
            this.gridstoklar.OptionsView.ShowAutoFilterRow = true;
            this.gridstoklar.OptionsView.ShowGroupPanel = false;
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
            this.colDURUM.Caption = "DURUMU";
            this.colDURUM.FieldName = "DURUM";
            this.colDURUM.Name = "colDURUM";
            this.colDURUM.OptionsColumn.AllowEdit = false;
            this.colDURUM.Visible = true;
            this.colDURUM.VisibleIndex = 0;
            this.colDURUM.Width = 59;
            // 
            // colSTOKKODU
            // 
            this.colSTOKKODU.Caption = "STOK KODU";
            this.colSTOKKODU.FieldName = "STOKKODU";
            this.colSTOKKODU.Name = "colSTOKKODU";
            this.colSTOKKODU.OptionsColumn.AllowEdit = false;
            this.colSTOKKODU.Visible = true;
            this.colSTOKKODU.VisibleIndex = 1;
            this.colSTOKKODU.Width = 85;
            // 
            // colSTOKAD
            // 
            this.colSTOKAD.Caption = "STOK ADI";
            this.colSTOKAD.FieldName = "STOKAD";
            this.colSTOKAD.Name = "colSTOKAD";
            this.colSTOKAD.OptionsColumn.AllowEdit = false;
            this.colSTOKAD.Visible = true;
            this.colSTOKAD.VisibleIndex = 2;
            this.colSTOKAD.Width = 209;
            // 
            // colBARKOD
            // 
            this.colBARKOD.Caption = "BARKOD";
            this.colBARKOD.FieldName = "BARKOD";
            this.colBARKOD.Name = "colBARKOD";
            this.colBARKOD.OptionsColumn.AllowEdit = false;
            this.colBARKOD.Visible = true;
            this.colBARKOD.VisibleIndex = 3;
            this.colBARKOD.Width = 217;
            // 
            // colBARKODTUR
            // 
            this.colBARKODTUR.Caption = "BARKOD TÜRÜ";
            this.colBARKODTUR.FieldName = "BARKODTUR";
            this.colBARKODTUR.Name = "colBARKODTUR";
            this.colBARKODTUR.OptionsColumn.AllowEdit = false;
            this.colBARKODTUR.Visible = true;
            this.colBARKODTUR.VisibleIndex = 4;
            this.colBARKODTUR.Width = 140;
            // 
            // colBIRIM
            // 
            this.colBIRIM.Caption = "BİRİMİ";
            this.colBIRIM.FieldName = "BIRIM";
            this.colBIRIM.Name = "colBIRIM";
            this.colBIRIM.OptionsColumn.AllowEdit = false;
            this.colBIRIM.Visible = true;
            this.colBIRIM.VisibleIndex = 5;
            this.colBIRIM.Width = 140;
            // 
            // colSTOKGRUP
            // 
            this.colSTOKGRUP.Caption = "STOK GRUBU";
            this.colSTOKGRUP.FieldName = "STOKGRUP";
            this.colSTOKGRUP.Name = "colSTOKGRUP";
            this.colSTOKGRUP.OptionsColumn.AllowEdit = false;
            this.colSTOKGRUP.Visible = true;
            this.colSTOKGRUP.VisibleIndex = 6;
            this.colSTOKGRUP.Width = 140;
            // 
            // colSTOKALTGRUP
            // 
            this.colSTOKALTGRUP.Caption = "STOK ALT GRUBU";
            this.colSTOKALTGRUP.FieldName = "STOKALTGRUP";
            this.colSTOKALTGRUP.Name = "colSTOKALTGRUP";
            this.colSTOKALTGRUP.OptionsColumn.AllowEdit = false;
            this.colSTOKALTGRUP.Visible = true;
            this.colSTOKALTGRUP.VisibleIndex = 7;
            this.colSTOKALTGRUP.Width = 140;
            // 
            // colMARKA
            // 
            this.colMARKA.Caption = "MARKASI";
            this.colMARKA.FieldName = "MARKA";
            this.colMARKA.Name = "colMARKA";
            this.colMARKA.OptionsColumn.AllowEdit = false;
            // 
            // colMODEL
            // 
            this.colMODEL.Caption = "MODELİ";
            this.colMODEL.FieldName = "MODEL";
            this.colMODEL.Name = "colMODEL";
            this.colMODEL.OptionsColumn.AllowEdit = false;
            // 
            // colOZELKOD1
            // 
            this.colOZELKOD1.Caption = "ÖZEL KOD 1";
            this.colOZELKOD1.FieldName = "OZELKOD1";
            this.colOZELKOD1.Name = "colOZELKOD1";
            this.colOZELKOD1.OptionsColumn.AllowEdit = false;
            // 
            // colOZELKOD2
            // 
            this.colOZELKOD2.Caption = "ÖZEL KOD 2";
            this.colOZELKOD2.FieldName = "OZELKOD2";
            this.colOZELKOD2.Name = "colOZELKOD2";
            this.colOZELKOD2.OptionsColumn.AllowEdit = false;
            // 
            // colOZELKOD3
            // 
            this.colOZELKOD3.Caption = "ÖZEL KOD 3";
            this.colOZELKOD3.FieldName = "OZELKOD3";
            this.colOZELKOD3.Name = "colOZELKOD3";
            this.colOZELKOD3.OptionsColumn.AllowEdit = false;
            // 
            // colOZELKOD4
            // 
            this.colOZELKOD4.Caption = "ÖZEL KOD 4";
            this.colOZELKOD4.FieldName = "OZELKOD4";
            this.colOZELKOD4.Name = "colOZELKOD4";
            this.colOZELKOD4.OptionsColumn.AllowEdit = false;
            // 
            // colGARANTISURE
            // 
            this.colGARANTISURE.Caption = "GARANTİ SÜRESİ";
            this.colGARANTISURE.FieldName = "GARANTISURE";
            this.colGARANTISURE.Name = "colGARANTISURE";
            this.colGARANTISURE.OptionsColumn.AllowEdit = false;
            // 
            // colURETICIKOD
            // 
            this.colURETICIKOD.Caption = "ÜRETİCİ KODU";
            this.colURETICIKOD.FieldName = "URETICIKOD";
            this.colURETICIKOD.Name = "colURETICIKOD";
            this.colURETICIKOD.OptionsColumn.AllowEdit = false;
            // 
            // colALISKDV
            // 
            this.colALISKDV.Caption = "ALIŞ KDV";
            this.colALISKDV.FieldName = "ALISKDV";
            this.colALISKDV.Name = "colALISKDV";
            this.colALISKDV.OptionsColumn.AllowEdit = false;
            // 
            // colSATISKDV
            // 
            this.colSATISKDV.Caption = "SATIŞ KDV";
            this.colSATISKDV.FieldName = "SATISKDV";
            this.colSATISKDV.Name = "colSATISKDV";
            this.colSATISKDV.OptionsColumn.AllowEdit = false;
            // 
            // colALISFIYAT1
            // 
            this.colALISFIYAT1.Caption = "ALIŞ FİYAT 1";
            this.colALISFIYAT1.FieldName = "ALISFIYAT1";
            this.colALISFIYAT1.Name = "colALISFIYAT1";
            this.colALISFIYAT1.OptionsColumn.AllowEdit = false;
            // 
            // colALISFIYAT2
            // 
            this.colALISFIYAT2.Caption = "ALIŞ FİYAT 2";
            this.colALISFIYAT2.FieldName = "ALISFIYAT2";
            this.colALISFIYAT2.Name = "colALISFIYAT2";
            this.colALISFIYAT2.OptionsColumn.AllowEdit = false;
            // 
            // colALISFIYAT3
            // 
            this.colALISFIYAT3.Caption = "ALIŞ FİYAT 3";
            this.colALISFIYAT3.FieldName = "ALISFIYAT3";
            this.colALISFIYAT3.Name = "colALISFIYAT3";
            this.colALISFIYAT3.OptionsColumn.AllowEdit = false;
            // 
            // colSATISFIYAT1
            // 
            this.colSATISFIYAT1.Caption = "SATIŞ FİYAT 1";
            this.colSATISFIYAT1.FieldName = "SATISFIYAT1";
            this.colSATISFIYAT1.Name = "colSATISFIYAT1";
            this.colSATISFIYAT1.OptionsColumn.AllowEdit = false;
            // 
            // colSATISFIYAT2
            // 
            this.colSATISFIYAT2.Caption = "SATIŞ FİYAT 2";
            this.colSATISFIYAT2.FieldName = "SATISFIYAT2";
            this.colSATISFIYAT2.Name = "colSATISFIYAT2";
            this.colSATISFIYAT2.OptionsColumn.AllowEdit = false;
            // 
            // colSATISFIYAT3
            // 
            this.colSATISFIYAT3.Caption = "SATIŞ FİYAT 3";
            this.colSATISFIYAT3.FieldName = "SATISFIYAT3";
            this.colSATISFIYAT3.Name = "colSATISFIYAT3";
            this.colSATISFIYAT3.OptionsColumn.AllowEdit = false;
            // 
            // colMINSTOKMIKTAR
            // 
            this.colMINSTOKMIKTAR.Caption = "MİNİMUM STOK MİKTARI";
            this.colMINSTOKMIKTAR.FieldName = "MINSTOKMIKTAR";
            this.colMINSTOKMIKTAR.Name = "colMINSTOKMIKTAR";
            this.colMINSTOKMIKTAR.OptionsColumn.AllowEdit = false;
            this.colMINSTOKMIKTAR.Visible = true;
            this.colMINSTOKMIKTAR.VisibleIndex = 8;
            this.colMINSTOKMIKTAR.Width = 140;
            // 
            // colMAXSTOKMIKTAR
            // 
            this.colMAXSTOKMIKTAR.Caption = "MAKSİMUM STOK MİKTARI";
            this.colMAXSTOKMIKTAR.FieldName = "MAXSTOKMIKTAR";
            this.colMAXSTOKMIKTAR.Name = "colMAXSTOKMIKTAR";
            this.colMAXSTOKMIKTAR.OptionsColumn.AllowEdit = false;
            this.colMAXSTOKMIKTAR.Visible = true;
            this.colMAXSTOKMIKTAR.VisibleIndex = 9;
            this.colMAXSTOKMIKTAR.Width = 155;
            // 
            // colACIKLAMA
            // 
            this.colACIKLAMA.Caption = "AÇIKLAMA";
            this.colACIKLAMA.FieldName = "ACIKLAMA";
            this.colACIKLAMA.Name = "colACIKLAMA";
            this.colACIKLAMA.OptionsColumn.AllowEdit = false;
            this.colACIKLAMA.Visible = true;
            this.colACIKLAMA.VisibleIndex = 10;
            this.colACIKLAMA.Width = 146;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "MEVCUT GİRİŞ";
            this.gridColumn1.FieldName = "STOKGIRIS";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 11;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "MEVCUT ÇIKIŞ";
            this.gridColumn2.FieldName = "STOKCIKIS";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 12;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "MEVCUT STOK";
            this.gridColumn3.FieldName = "MEVCUTSTOK";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 13;
            // 
            // FrmStokSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1673, 545);
            this.Controls.Add(this.gridcontStoklar);
            this.Controls.Add(this.GrupMenu);
            this.Controls.Add(this.LblBaslık);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStokSec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Seç";
            this.Load += new System.EventHandler(this.FrmStokSec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrupMenu)).EndInit();
            this.GrupMenu.ResumeLayout(false);
            this.GrupMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridcontStoklar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridstoklar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl LblBaslık;
        private DevExpress.XtraEditors.GroupControl GrupMenu;
        private DevExpress.XtraEditors.SimpleButton BtnKapat;
        private DevExpress.XtraEditors.SimpleButton BtnSec;
        private DevExpress.XtraGrid.GridControl gridcontStoklar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridstoklar;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colDURUM;
        private DevExpress.XtraGrid.Columns.GridColumn colSTOKKODU;
        private DevExpress.XtraGrid.Columns.GridColumn colSTOKAD;
        private DevExpress.XtraGrid.Columns.GridColumn colBARKOD;
        private DevExpress.XtraGrid.Columns.GridColumn colBARKODTUR;
        private DevExpress.XtraGrid.Columns.GridColumn colBIRIM;
        private DevExpress.XtraGrid.Columns.GridColumn colSTOKGRUP;
        private DevExpress.XtraGrid.Columns.GridColumn colSTOKALTGRUP;
        private DevExpress.XtraGrid.Columns.GridColumn colMARKA;
        private DevExpress.XtraGrid.Columns.GridColumn colMODEL;
        private DevExpress.XtraGrid.Columns.GridColumn colOZELKOD1;
        private DevExpress.XtraGrid.Columns.GridColumn colOZELKOD2;
        private DevExpress.XtraGrid.Columns.GridColumn colOZELKOD3;
        private DevExpress.XtraGrid.Columns.GridColumn colOZELKOD4;
        private DevExpress.XtraGrid.Columns.GridColumn colGARANTISURE;
        private DevExpress.XtraGrid.Columns.GridColumn colURETICIKOD;
        private DevExpress.XtraGrid.Columns.GridColumn colALISKDV;
        private DevExpress.XtraGrid.Columns.GridColumn colSATISKDV;
        private DevExpress.XtraGrid.Columns.GridColumn colALISFIYAT1;
        private DevExpress.XtraGrid.Columns.GridColumn colALISFIYAT2;
        private DevExpress.XtraGrid.Columns.GridColumn colALISFIYAT3;
        private DevExpress.XtraGrid.Columns.GridColumn colSATISFIYAT1;
        private DevExpress.XtraGrid.Columns.GridColumn colSATISFIYAT2;
        private DevExpress.XtraGrid.Columns.GridColumn colSATISFIYAT3;
        private DevExpress.XtraGrid.Columns.GridColumn colMINSTOKMIKTAR;
        private DevExpress.XtraGrid.Columns.GridColumn colMAXSTOKMIKTAR;
        private DevExpress.XtraGrid.Columns.GridColumn colACIKLAMA;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.LabelControl lblUyarı;
    }
}