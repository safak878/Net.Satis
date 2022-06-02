namespace NetSatıs.BackOffice.Tanım
{
    partial class FrmTanım
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTanım));
            DevExpress.Utils.Animation.PushTransition pushTransition1 = new DevExpress.Utils.Animation.PushTransition();
            this.LblBaslık = new DevExpress.XtraEditors.LabelControl();
            this.GrpMenu = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BtnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.BtnVazgec = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSıl = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.navigationFrame1 = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.TxtTanım = new System.Windows.Forms.TextBox();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.TxtAcıklama = new DevExpress.XtraEditors.MemoEdit();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.gridcontTanım = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColTANIM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColACIKLAMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.workspaceManager1 = new DevExpress.Utils.WorkspaceManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GrpMenu)).BeginInit();
            this.GrpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).BeginInit();
            this.navigationFrame1.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAcıklama.Properties)).BeginInit();
            this.navigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridcontTanım)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.LblBaslık.Size = new System.Drawing.Size(768, 54);
            this.LblBaslık.TabIndex = 7;
            this.LblBaslık.Text = "Tanımlar";
            // 
            // GrpMenu
            // 
            this.GrpMenu.Controls.Add(this.simpleButton1);
            this.GrpMenu.Controls.Add(this.BtnKapat);
            this.GrpMenu.Controls.Add(this.BtnVazgec);
            this.GrpMenu.Controls.Add(this.BtnKaydet);
            this.GrpMenu.Controls.Add(this.BtnSıl);
            this.GrpMenu.Controls.Add(this.BtnDuzenle);
            this.GrpMenu.Controls.Add(this.BtnEkle);
            this.GrpMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GrpMenu.Location = new System.Drawing.Point(0, 394);
            this.GrpMenu.Name = "GrpMenu";
            this.GrpMenu.Size = new System.Drawing.Size(768, 74);
            this.GrpMenu.TabIndex = 8;
            this.GrpMenu.Text = "Menü";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.ImageIndex = 1;
            this.simpleButton1.ImageOptions.ImageList = this.ımageList1;
            this.simpleButton1.Location = new System.Drawing.Point(9, 27);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(102, 42);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "SEÇ";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "add.png");
            this.ımageList1.Images.SetKeyName(1, "checkbox.png");
            this.ımageList1.Images.SetKeyName(2, "delete.png");
            this.ımageList1.Images.SetKeyName(3, "floppy_disk.png");
            this.ımageList1.Images.SetKeyName(4, "floppy_disk_delete.png");
            this.ımageList1.Images.SetKeyName(5, "folder_out.png");
            this.ımageList1.Images.SetKeyName(6, "pencil.png");
            // 
            // BtnKapat
            // 
            this.BtnKapat.ImageOptions.ImageIndex = 5;
            this.BtnKapat.ImageOptions.ImageList = this.ımageList1;
            this.BtnKapat.Location = new System.Drawing.Point(663, 27);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(102, 42);
            this.BtnKapat.TabIndex = 6;
            this.BtnKapat.Text = "KAPAT";
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // BtnVazgec
            // 
            this.BtnVazgec.Enabled = false;
            this.BtnVazgec.ImageOptions.ImageIndex = 4;
            this.BtnVazgec.ImageOptions.ImageList = this.ımageList1;
            this.BtnVazgec.Location = new System.Drawing.Point(549, 26);
            this.BtnVazgec.Name = "BtnVazgec";
            this.BtnVazgec.Size = new System.Drawing.Size(108, 42);
            this.BtnVazgec.TabIndex = 5;
            this.BtnVazgec.Text = "VAZGEÇ";
            this.BtnVazgec.Click += new System.EventHandler(this.BtnVazgec_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Enabled = false;
            this.BtnKaydet.ImageOptions.ImageIndex = 3;
            this.BtnKaydet.ImageOptions.ImageList = this.ımageList1;
            this.BtnKaydet.Location = new System.Drawing.Point(441, 26);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(102, 42);
            this.BtnKaydet.TabIndex = 4;
            this.BtnKaydet.Text = "KAYDET";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnSıl
            // 
            this.BtnSıl.ImageOptions.ImageIndex = 2;
            this.BtnSıl.ImageOptions.ImageList = this.ımageList1;
            this.BtnSıl.Location = new System.Drawing.Point(333, 26);
            this.BtnSıl.Name = "BtnSıl";
            this.BtnSıl.Size = new System.Drawing.Size(102, 42);
            this.BtnSıl.TabIndex = 2;
            this.BtnSıl.Text = "SİL";
            this.BtnSıl.Click += new System.EventHandler(this.BtnSıl_Click);
            // 
            // BtnDuzenle
            // 
            this.BtnDuzenle.ImageOptions.ImageIndex = 6;
            this.BtnDuzenle.ImageOptions.ImageList = this.ımageList1;
            this.BtnDuzenle.Location = new System.Drawing.Point(225, 26);
            this.BtnDuzenle.Name = "BtnDuzenle";
            this.BtnDuzenle.Size = new System.Drawing.Size(102, 42);
            this.BtnDuzenle.TabIndex = 1;
            this.BtnDuzenle.Text = "DÜZENLE";
            this.BtnDuzenle.Click += new System.EventHandler(this.BtnDuzenle_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.ImageOptions.ImageIndex = 0;
            this.BtnEkle.ImageOptions.ImageList = this.ımageList1;
            this.BtnEkle.Location = new System.Drawing.Point(117, 26);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(102, 42);
            this.BtnEkle.TabIndex = 0;
            this.BtnEkle.Text = "EKLE";
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // navigationFrame1
            // 
            this.navigationFrame1.Controls.Add(this.navigationPage1);
            this.navigationFrame1.Controls.Add(this.navigationPage2);
            this.navigationFrame1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame1.Location = new System.Drawing.Point(0, 54);
            this.navigationFrame1.Name = "navigationFrame1";
            this.navigationFrame1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1,
            this.navigationPage2});
            this.navigationFrame1.SelectedPage = this.navigationPage2;
            this.navigationFrame1.Size = new System.Drawing.Size(768, 340);
            this.navigationFrame1.TabIndex = 9;
            this.navigationFrame1.Text = "navigationFrame1";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "navigationPage1";
            this.navigationPage1.Controls.Add(this.groupControl1);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(768, 340);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.TxtTanım);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.TxtAcıklama);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(768, 340);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Tanım Bilgileri";
            // 
            // TxtTanım
            // 
            this.TxtTanım.Location = new System.Drawing.Point(113, 37);
            this.TxtTanım.Multiline = true;
            this.TxtTanım.Name = "TxtTanım";
            this.TxtTanım.Size = new System.Drawing.Size(613, 20);
            this.TxtTanım.TabIndex = 25;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.labelControl12.Appearance.Options.UseBorderColor = true;
            this.labelControl12.Appearance.Options.UseTextOptions = true;
            this.labelControl12.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl12.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl12.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl12.Location = new System.Drawing.Point(5, 36);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(102, 21);
            this.labelControl12.TabIndex = 24;
            this.labelControl12.Text = "Tanımı :";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.labelControl10.Appearance.Options.UseBorderColor = true;
            this.labelControl10.Appearance.Options.UseTextOptions = true;
            this.labelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl10.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl10.Location = new System.Drawing.Point(5, 67);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(102, 267);
            this.labelControl10.TabIndex = 23;
            this.labelControl10.Text = "Açıklama :";
            // 
            // TxtAcıklama
            // 
            this.TxtAcıklama.Location = new System.Drawing.Point(113, 63);
            this.TxtAcıklama.Name = "TxtAcıklama";
            this.TxtAcıklama.Size = new System.Drawing.Size(613, 271);
            this.TxtAcıklama.TabIndex = 26;
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "navigationPage2";
            this.navigationPage2.Controls.Add(this.gridcontTanım);
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(768, 340);
            // 
            // gridcontTanım
            // 
            this.gridcontTanım.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridcontTanım.Location = new System.Drawing.Point(0, 0);
            this.gridcontTanım.MainView = this.gridView1;
            this.gridcontTanım.Name = "gridcontTanım";
            this.gridcontTanım.Size = new System.Drawing.Size(768, 340);
            this.gridcontTanım.TabIndex = 2;
            this.gridcontTanım.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColID,
            this.ColTANIM,
            this.ColACIKLAMA});
            this.gridView1.GridControl = this.gridcontTanım;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // ColID
            // 
            this.ColID.Caption = "ID";
            this.ColID.FieldName = "ID";
            this.ColID.Name = "ColID";
            this.ColID.OptionsColumn.ShowInCustomizationForm = false;
            // 
            // ColTANIM
            // 
            this.ColTANIM.Caption = "TANIM";
            this.ColTANIM.FieldName = "TANIMI";
            this.ColTANIM.Name = "ColTANIM";
            this.ColTANIM.OptionsColumn.AllowEdit = false;
            this.ColTANIM.Visible = true;
            this.ColTANIM.VisibleIndex = 0;
            // 
            // ColACIKLAMA
            // 
            this.ColACIKLAMA.Caption = "ACIKLAMA";
            this.ColACIKLAMA.FieldName = "ACIKLAMA";
            this.ColACIKLAMA.Name = "ColACIKLAMA";
            this.ColACIKLAMA.OptionsColumn.AllowEdit = false;
            this.ColACIKLAMA.Visible = true;
            this.ColACIKLAMA.VisibleIndex = 1;
            // 
            // workspaceManager1
            // 
            this.workspaceManager1.TargetControl = this;
            this.workspaceManager1.TransitionType = pushTransition1;
            // 
            // FrmTanım
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 468);
            this.Controls.Add(this.navigationFrame1);
            this.Controls.Add(this.GrpMenu);
            this.Controls.Add(this.LblBaslık);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTanım";
            this.Text = "Tanımlar";
            this.Load += new System.EventHandler(this.FrmTanım_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrpMenu)).EndInit();
            this.GrpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame1)).EndInit();
            this.navigationFrame1.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAcıklama.Properties)).EndInit();
            this.navigationPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridcontTanım)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl LblBaslık;
        private DevExpress.XtraEditors.GroupControl GrpMenu;
        private DevExpress.XtraEditors.SimpleButton BtnKapat;
        private DevExpress.XtraEditors.SimpleButton BtnVazgec;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.SimpleButton BtnSıl;
        private DevExpress.XtraEditors.SimpleButton BtnDuzenle;
        private DevExpress.XtraEditors.SimpleButton BtnEkle;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox TxtTanım;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.MemoEdit TxtAcıklama;
        private DevExpress.XtraGrid.GridControl gridcontTanım;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ColTANIM;
        private DevExpress.XtraGrid.Columns.GridColumn ColACIKLAMA;
        private DevExpress.Utils.WorkspaceManager workspaceManager1;
        private DevExpress.XtraGrid.Columns.GridColumn ColID;
    }
}