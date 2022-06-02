namespace NetSatıs.BackOffice.Depo
{
    partial class FrmDepoSec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDepoSec));
            this.GrupMenu = new DevExpress.XtraEditors.GroupControl();
            this.BtnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BtnSec = new DevExpress.XtraEditors.SimpleButton();
            this.LblBaslık = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDEPOKOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDEPOAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYETKILIKOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYETKILIAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colILCE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSEMT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADRES = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTELEFON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACIKLAMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColSTOKGIRIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColSTOKCIKIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColMEVCUTSTOK = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GrupMenu)).BeginInit();
            this.GrupMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GrupMenu
            // 
            this.GrupMenu.Controls.Add(this.BtnKapat);
            this.GrupMenu.Controls.Add(this.BtnSec);
            this.GrupMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GrupMenu.Location = new System.Drawing.Point(0, 470);
            this.GrupMenu.Name = "GrupMenu";
            this.GrupMenu.Size = new System.Drawing.Size(1673, 75);
            this.GrupMenu.TabIndex = 9;
            this.GrupMenu.Text = "Menü";
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
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "check.png");
            this.ımageList1.Images.SetKeyName(1, "folder_out.png");
            this.ımageList1.Images.SetKeyName(2, "Cari Hareket.png");
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
            this.LblBaslık.Size = new System.Drawing.Size(1673, 54);
            this.LblBaslık.TabIndex = 8;
            this.LblBaslık.Text = "Depo Seçim Ekranı";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 54);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1673, 416);
            this.gridControl1.TabIndex = 10;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDEPOKOD,
            this.colDEPOAD,
            this.colYETKILIKOD,
            this.colYETKILIAD,
            this.colIL,
            this.colILCE,
            this.colSEMT,
            this.colADRES,
            this.colTELEFON,
            this.colACIKLAMA,
            this.ColSTOKGIRIS,
            this.ColSTOKCIKIS,
            this.ColMEVCUTSTOK});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colDEPOKOD
            // 
            this.colDEPOKOD.FieldName = "DEPOKOD";
            this.colDEPOKOD.Name = "colDEPOKOD";
            this.colDEPOKOD.OptionsColumn.AllowEdit = false;
            this.colDEPOKOD.Visible = true;
            this.colDEPOKOD.VisibleIndex = 0;
            // 
            // colDEPOAD
            // 
            this.colDEPOAD.FieldName = "DEPOAD";
            this.colDEPOAD.Name = "colDEPOAD";
            this.colDEPOAD.OptionsColumn.AllowEdit = false;
            this.colDEPOAD.Visible = true;
            this.colDEPOAD.VisibleIndex = 1;
            // 
            // colYETKILIKOD
            // 
            this.colYETKILIKOD.FieldName = "YETKILIKOD";
            this.colYETKILIKOD.Name = "colYETKILIKOD";
            this.colYETKILIKOD.OptionsColumn.AllowEdit = false;
            this.colYETKILIKOD.Visible = true;
            this.colYETKILIKOD.VisibleIndex = 2;
            // 
            // colYETKILIAD
            // 
            this.colYETKILIAD.FieldName = "YETKILIAD";
            this.colYETKILIAD.Name = "colYETKILIAD";
            this.colYETKILIAD.OptionsColumn.AllowEdit = false;
            this.colYETKILIAD.Visible = true;
            this.colYETKILIAD.VisibleIndex = 3;
            // 
            // colIL
            // 
            this.colIL.FieldName = "IL";
            this.colIL.Name = "colIL";
            this.colIL.OptionsColumn.AllowEdit = false;
            this.colIL.Visible = true;
            this.colIL.VisibleIndex = 5;
            // 
            // colILCE
            // 
            this.colILCE.FieldName = "ILCE";
            this.colILCE.Name = "colILCE";
            this.colILCE.OptionsColumn.AllowEdit = false;
            this.colILCE.Visible = true;
            this.colILCE.VisibleIndex = 6;
            // 
            // colSEMT
            // 
            this.colSEMT.FieldName = "SEMT";
            this.colSEMT.Name = "colSEMT";
            this.colSEMT.OptionsColumn.AllowEdit = false;
            this.colSEMT.Visible = true;
            this.colSEMT.VisibleIndex = 7;
            // 
            // colADRES
            // 
            this.colADRES.FieldName = "ADRES";
            this.colADRES.Name = "colADRES";
            this.colADRES.OptionsColumn.AllowEdit = false;
            this.colADRES.Visible = true;
            this.colADRES.VisibleIndex = 8;
            // 
            // colTELEFON
            // 
            this.colTELEFON.FieldName = "TELEFON";
            this.colTELEFON.Name = "colTELEFON";
            this.colTELEFON.OptionsColumn.AllowEdit = false;
            this.colTELEFON.Visible = true;
            this.colTELEFON.VisibleIndex = 4;
            // 
            // colACIKLAMA
            // 
            this.colACIKLAMA.FieldName = "ACIKLAMA";
            this.colACIKLAMA.Name = "colACIKLAMA";
            this.colACIKLAMA.OptionsColumn.AllowEdit = false;
            this.colACIKLAMA.Visible = true;
            this.colACIKLAMA.VisibleIndex = 9;
            // 
            // ColSTOKGIRIS
            // 
            this.ColSTOKGIRIS.Caption = "STOKGIRIS";
            this.ColSTOKGIRIS.FieldName = "STOKGIRIS";
            this.ColSTOKGIRIS.Name = "ColSTOKGIRIS";
            this.ColSTOKGIRIS.OptionsColumn.AllowEdit = false;
            this.ColSTOKGIRIS.Visible = true;
            this.ColSTOKGIRIS.VisibleIndex = 10;
            // 
            // ColSTOKCIKIS
            // 
            this.ColSTOKCIKIS.Caption = "STOKCIKIS";
            this.ColSTOKCIKIS.FieldName = "STOKCIKIS";
            this.ColSTOKCIKIS.Name = "ColSTOKCIKIS";
            this.ColSTOKCIKIS.OptionsColumn.AllowEdit = false;
            this.ColSTOKCIKIS.Visible = true;
            this.ColSTOKCIKIS.VisibleIndex = 11;
            // 
            // ColMEVCUTSTOK
            // 
            this.ColMEVCUTSTOK.Caption = "MEVCUTSTOK";
            this.ColMEVCUTSTOK.FieldName = "MEVCUTSTOK";
            this.ColMEVCUTSTOK.Name = "ColMEVCUTSTOK";
            this.ColMEVCUTSTOK.OptionsColumn.AllowEdit = false;
            this.ColMEVCUTSTOK.Visible = true;
            this.ColMEVCUTSTOK.VisibleIndex = 12;
            // 
            // FrmDepoSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1673, 545);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.GrupMenu);
            this.Controls.Add(this.LblBaslık);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDepoSec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDepoSec";
            this.Load += new System.EventHandler(this.FrmDepoSec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrupMenu)).EndInit();
            this.GrupMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl GrupMenu;
        private DevExpress.XtraEditors.SimpleButton BtnKapat;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.SimpleButton BtnSec;
        private DevExpress.XtraEditors.LabelControl LblBaslık;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colDEPOKOD;
        private DevExpress.XtraGrid.Columns.GridColumn colDEPOAD;
        private DevExpress.XtraGrid.Columns.GridColumn colYETKILIKOD;
        private DevExpress.XtraGrid.Columns.GridColumn colYETKILIAD;
        private DevExpress.XtraGrid.Columns.GridColumn colIL;
        private DevExpress.XtraGrid.Columns.GridColumn colILCE;
        private DevExpress.XtraGrid.Columns.GridColumn colSEMT;
        private DevExpress.XtraGrid.Columns.GridColumn colADRES;
        private DevExpress.XtraGrid.Columns.GridColumn colTELEFON;
        private DevExpress.XtraGrid.Columns.GridColumn colACIKLAMA;
        private DevExpress.XtraGrid.Columns.GridColumn ColSTOKGIRIS;
        private DevExpress.XtraGrid.Columns.GridColumn ColSTOKCIKIS;
        private DevExpress.XtraGrid.Columns.GridColumn ColMEVCUTSTOK;
    }
}