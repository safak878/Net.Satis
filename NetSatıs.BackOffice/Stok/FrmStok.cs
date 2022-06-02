using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using NetSatıs.Entities.Context;
using NetSatıs.Entities.Data_Access;

namespace NetSatıs.BackOffice.Stok
{
    public partial class FrmStok : DevExpress.XtraEditors.XtraForm
    {
        NetSatısContext context = new NetSatısContext();
        STOKDAL StokDal = new STOKDAL();
        string Secilen;
        string SecilenAd;
        public FrmStok()
        {
            InitializeComponent();
        }

        private void FrmStok_Load(object sender, EventArgs e)
        {
            GetAll();
        }
        private void GetAll()
        {
            gridControl1.DataSource= StokDal.GetAllJoin(context);
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            filterControl1.ApplyFilter();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            filterControl1.FilterString = null;
            filterControl1.ApplyFilter();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            GetAll();
        }

        private void BtnSıl_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {string secilen = gridView1.GetFocusedRowCellValue(colSTOKKODU).ToString();
                StokDal.Delete(context, c => c.STOKKODU == secilen);
                StokDal.Save(context);
                GetAll();

            }
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            FrmStokİslem form = new FrmStokİslem(new Entities.Tables.STOK());
            form.ShowDialog();
            if (form.saved)
            {
                GetAll();
            }
        }

        private void BtnDuzenle_Click(object sender, EventArgs e)
        {
       Secilen = gridView1.GetFocusedRowCellValue(colSTOKKODU).ToString(); 
            FrmStokİslem form = new FrmStokİslem(StokDal.GetByFilter(context,c=>c.STOKKODU==Secilen));
            form.ShowDialog();
            if (form.saved)
            {
                GetAll();
            }
        }

        private void BtnKopyala_Click(object sender, EventArgs e)
        {
            Secilen = gridView1.GetFocusedRowCellValue(colSTOKKODU).ToString();
            Entities.Tables.STOK stokEntitiy = new Entities.Tables.STOK();
            stokEntitiy = StokDal.GetByFilter(context, c => c.STOKKODU == Secilen);
            stokEntitiy.ID = -1;
            stokEntitiy.STOKKODU = null;
            FrmStokİslem form = new FrmStokİslem(stokEntitiy);
            form.ShowDialog();
            if (form.saved)
            {
                GetAll();
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Secilen = gridView1.GetFocusedRowCellValue(colSTOKKODU).ToString();
            SecilenAd = gridView1.GetFocusedRowCellValue(colSTOKAD).ToString();
            FrmStokHareket form = new FrmStokHareket(Secilen,SecilenAd);
            form.ShowDialog();
        }
    }
}