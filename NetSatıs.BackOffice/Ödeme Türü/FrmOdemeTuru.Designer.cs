namespace NetSatıs.BackOffice.Ödeme_Türü
{
    partial class FrmOdemeTuru
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOdemeTuru));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.filterControl1 = new DevExpress.XtraEditors.FilterControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colODEMETURKOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colODEMETURAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACIKLAMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColKASAGIRIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColKASACIKIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColBAKIYE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GrpMenu = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAra = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSıl = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.LblBaslık = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.splitContainerControl1.Panel1.Controls.Add(this.simpleButton3);
            this.splitContainerControl1.Panel1.Controls.Add(this.simpleButton2);
            this.splitContainerControl1.Panel1.Controls.Add(this.simpleButton1);
            this.splitContainerControl1.Panel1.Controls.Add(this.filterControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1594, 586);
            this.splitContainerControl1.SplitterPosition = 168;
            this.splitContainerControl1.TabIndex = 8;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton3.ImageOptions.ImageIndex = 6;
            this.simpleButton3.ImageOptions.ImageList = this.ımageList1;
            this.simpleButton3.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton3.Location = new System.Drawing.Point(1528, 124);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(61, 42);
            this.simpleButton3.TabIndex = 8;
            this.simpleButton3.Text = "ARA";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Hareketler.png");
            this.ımageList1.Images.SetKeyName(1, "replace2.png");
            this.ımageList1.Images.SetKeyName(2, "wallet_closed.png");
            this.ımageList1.Images.SetKeyName(3, "wallet_closed_add.png");
            this.ımageList1.Images.SetKeyName(4, "wallet_closed_delete.png");
            this.ımageList1.Images.SetKeyName(5, "wallet_closed_edit.png");
            this.ımageList1.Images.SetKeyName(6, "folder_out.png");
            this.ımageList1.Images.SetKeyName(7, "funnel.png");
            this.ımageList1.Images.SetKeyName(8, "funnel_delete.png");
            this.ımageList1.Images.SetKeyName(9, "refresh.png");
            this.ımageList1.Images.SetKeyName(10, "view.png");
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton2.ImageOptions.ImageIndex = 8;
            this.simpleButton2.ImageOptions.ImageList = this.ımageList1;
            this.simpleButton2.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.simpleButton2.Location = new System.Drawing.Point(1461, 124);
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
            this.simpleButton1.Location = new System.Drawing.Point(1394, 124);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(61, 42);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "ARA";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // filterControl1
            // 
            this.filterControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.filterControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.filterControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterControl1.Location = new System.Drawing.Point(0, 0);
            this.filterControl1.Name = "filterControl1";
            this.filterControl1.Size = new System.Drawing.Size(1594, 168);
            this.filterControl1.SortFilterColumns = false;
            this.filterControl1.SourceControl = this.gridControl1;
            this.filterControl1.TabIndex = 0;
            this.filterControl1.Text = "filterControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1594, 408);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colODEMETURKOD,
            this.colODEMETURAD,
            this.colACIKLAMA,
            this.ColKASAGIRIS,
            this.ColKASACIKIS,
            this.ColBAKIYE});
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
            // colODEMETURKOD
            // 
            this.colODEMETURKOD.Caption = "ODEMETURKOD";
            this.colODEMETURKOD.FieldName = "ODEMETURKOD";
            this.colODEMETURKOD.Name = "colODEMETURKOD";
            this.colODEMETURKOD.OptionsColumn.AllowEdit = false;
            this.colODEMETURKOD.Visible = true;
            this.colODEMETURKOD.VisibleIndex = 0;
            // 
            // colODEMETURAD
            // 
            this.colODEMETURAD.FieldName = "ODEMETURAD";
            this.colODEMETURAD.Name = "colODEMETURAD";
            this.colODEMETURAD.OptionsColumn.AllowEdit = false;
            this.colODEMETURAD.Visible = true;
            this.colODEMETURAD.VisibleIndex = 1;
            // 
            // colACIKLAMA
            // 
            this.colACIKLAMA.FieldName = "ACIKLAMA";
            this.colACIKLAMA.Name = "colACIKLAMA";
            this.colACIKLAMA.OptionsColumn.AllowEdit = false;
            this.colACIKLAMA.Visible = true;
            this.colACIKLAMA.VisibleIndex = 2;
            // 
            // ColKASAGIRIS
            // 
            this.ColKASAGIRIS.Caption = "KASAGIRIS";
            this.ColKASAGIRIS.FieldName = "KASAGIRIS";
            this.ColKASAGIRIS.Name = "ColKASAGIRIS";
            this.ColKASAGIRIS.OptionsColumn.AllowEdit = false;
            this.ColKASAGIRIS.Visible = true;
            this.ColKASAGIRIS.VisibleIndex = 3;
            // 
            // ColKASACIKIS
            // 
            this.ColKASACIKIS.Caption = "KASACIKIS";
            this.ColKASACIKIS.FieldName = "KASACIKIS";
            this.ColKASACIKIS.Name = "ColKASACIKIS";
            this.ColKASACIKIS.OptionsColumn.AllowEdit = false;
            this.ColKASACIKIS.Visible = true;
            this.ColKASACIKIS.VisibleIndex = 4;
            // 
            // ColBAKIYE
            // 
            this.ColBAKIYE.Caption = "BAKIYE";
            this.ColBAKIYE.FieldName = "BAKIYE";
            this.ColBAKIYE.Name = "ColBAKIYE";
            this.ColBAKIYE.OptionsColumn.AllowEdit = false;
            this.ColBAKIYE.Visible = true;
            this.ColBAKIYE.VisibleIndex = 5;
            // 
            // GrpMenu
            // 
            this.GrpMenu.Controls.Add(this.simpleButton4);
            this.GrpMenu.Controls.Add(this.BtnKapat);
            this.GrpMenu.Controls.Add(this.BtnAra);
            this.GrpMenu.Controls.Add(this.BtnGuncelle);
            this.GrpMenu.Controls.Add(this.BtnSıl);
            this.GrpMenu.Controls.Add(this.BtnDuzenle);
            this.GrpMenu.Controls.Add(this.BtnEkle);
            this.GrpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GrpMenu.Location = new System.Drawing.Point(0, 640);
            this.GrpMenu.Name = "GrpMenu";
            this.GrpMenu.Size = new System.Drawing.Size(1594, 76);
            this.GrpMenu.TabIndex = 7;
            this.GrpMenu.Text = "Menü";
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageOptions.ImageIndex = 0;
            this.simpleButton4.ImageOptions.ImageList = this.ımageList1;
            this.simpleButton4.Location = new System.Drawing.Point(329, 26);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(102, 42);
            this.simpleButton4.TabIndex = 7;
            this.simpleButton4.Text = "ÖDEME\r\n HAREKET";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // BtnKapat
            // 
            this.BtnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnKapat.ImageOptions.ImageIndex = 6;
            this.BtnKapat.ImageOptions.ImageList = this.ımageList1;
            this.BtnKapat.Location = new System.Drawing.Point(1492, 22);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(102, 42);
            this.BtnKapat.TabIndex = 6;
            this.BtnKapat.Text = "KAPAT";
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // BtnAra
            // 
            this.BtnAra.ImageOptions.ImageIndex = 10;
            this.BtnAra.ImageOptions.ImageList = this.ımageList1;
            this.BtnAra.Location = new System.Drawing.Point(545, 26);
            this.BtnAra.Name = "BtnAra";
            this.BtnAra.Size = new System.Drawing.Size(108, 42);
            this.BtnAra.TabIndex = 5;
            this.BtnAra.Text = "ARA";
            this.BtnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.ImageOptions.ImageIndex = 9;
            this.BtnGuncelle.ImageOptions.ImageList = this.ımageList1;
            this.BtnGuncelle.Location = new System.Drawing.Point(437, 26);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(102, 42);
            this.BtnGuncelle.TabIndex = 4;
            this.BtnGuncelle.Text = "GÜNCELLE";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSıl
            // 
            this.BtnSıl.ImageOptions.ImageIndex = 4;
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
            this.BtnDuzenle.ImageOptions.ImageIndex = 5;
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
            this.BtnEkle.ImageOptions.ImageIndex = 3;
            this.BtnEkle.ImageOptions.ImageList = this.ımageList1;
            this.BtnEkle.Location = new System.Drawing.Point(5, 26);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(102, 42);
            this.BtnEkle.TabIndex = 0;
            this.BtnEkle.Text = "EKLE";
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
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
            this.LblBaslık.Size = new System.Drawing.Size(1594, 54);
            this.LblBaslık.TabIndex = 6;
            this.LblBaslık.Text = "Ödeme Kartları";
            // 
            // FrmOdemeTuru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1594, 716);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.GrpMenu);
            this.Controls.Add(this.LblBaslık);
            this.Name = "FrmOdemeTuru";
            this.Text = "FrmOdemeTuru";
            this.Load += new System.EventHandler(this.FrmOdemeTuru_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrpMenu)).EndInit();
            this.GrpMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.FilterControl filterControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colODEMETURAD;
        private DevExpress.XtraGrid.Columns.GridColumn colACIKLAMA;
        private DevExpress.XtraGrid.Columns.GridColumn ColKASAGIRIS;
        private DevExpress.XtraGrid.Columns.GridColumn ColKASACIKIS;
        private DevExpress.XtraGrid.Columns.GridColumn ColBAKIYE;
        private DevExpress.XtraEditors.GroupControl GrpMenu;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton BtnKapat;
        private DevExpress.XtraEditors.SimpleButton BtnAra;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnSıl;
        private DevExpress.XtraEditors.SimpleButton BtnDuzenle;
        private DevExpress.XtraEditors.SimpleButton BtnEkle;
        private DevExpress.XtraEditors.LabelControl LblBaslık;
        private DevExpress.XtraGrid.Columns.GridColumn colODEMETURKOD;
    }
}