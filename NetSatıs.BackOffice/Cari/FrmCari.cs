using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NetSatıs.Entities.Context;
using NetSatıs.Entities.Data_Access;

namespace NetSatıs.BackOffice.Cari
{
    public partial class FrmCari : DevExpress.XtraEditors.XtraForm
    {
        NetSatısContext context = new NetSatısContext();
        CARIDAL CariDal = new CARIDAL();
        private string secilen=null;
        public FrmCari()
        {
            InitializeComponent();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
            
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            filterControl1.FilterString = null;
            filterControl1.ApplyFilter();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            filterControl1.ApplyFilter();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            GetAll();
        }
        public void GetAll()
        {
            gridControl1.DataSource = CariDal.GetCarıler(context);
        }

        private void FrmCari_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        private void BtnSıl_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string secilen = gridView1.GetFocusedRowCellValue(colCARIKOD).ToString();
                CariDal.Delete(context, c => c.CARIKOD == secilen);
                CariDal.Save(context);
                GetAll();
            }
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {

            FrmCarıİslem form = new FrmCarıİslem(new Entities.Tables.CARI());
            form.ShowDialog();
            if (form.saved)
            {
                GetAll();
            }
           
        }

        private void BtnDuzenle_Click(object sender, EventArgs e)
        {
            secilen = gridView1.GetFocusedRowCellValue(colCARIKOD).ToString();
            FrmCarıİslem form = new FrmCarıİslem(CariDal.GetByFilter(context, c => c.CARIKOD == secilen));
            form.ShowDialog();
            if (form.saved)
            {
                GetAll();
            }
        }

        private void BtnKopyala_Click(object sender, EventArgs e)
        {
           secilen = gridView1.GetFocusedRowCellValue(colCARIKOD).ToString();
            Entities.Tables.CARI carıEntitiy = new Entities.Tables.CARI();
            carıEntitiy = CariDal.GetByFilter(context, c => c.CARIKOD == secilen);
            carıEntitiy.ID = -1;
            carıEntitiy.CARIKOD = null;
            FrmCarıİslem form = new FrmCarıİslem(carıEntitiy);
            form.ShowDialog();
            if (form.saved)
            {
                GetAll();
            }
        }
        string Secilen;
        private void simpleButton4_Click(object sender, EventArgs e)
        {

            Secilen = gridView1.GetFocusedRowCellValue(colCARIKOD).ToString();
            string SecilenAd = gridView1.GetFocusedRowCellValue(colCARIAD).ToString();
            FrmCariHareket form = new FrmCariHareket(Secilen, SecilenAd);
            form.ShowDialog();
        }

        private void filterControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void GrpMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainerControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LblBaslık_Click(object sender, EventArgs e)
        {

        }
    }
    }
