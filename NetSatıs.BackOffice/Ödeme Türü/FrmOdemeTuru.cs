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
using NetSatıs.Entities.Tables;

namespace NetSatıs.BackOffice.Ödeme_Türü
{
    public partial class FrmOdemeTuru : DevExpress.XtraEditors.XtraForm
    {
        NetSatısContext context = new NetSatısContext();
        ODEMETURUDAL OdemeTurDal = new ODEMETURUDAL();
        public FrmOdemeTuru()
        {
            InitializeComponent();
        }

        private void FrmOdemeTuru_Load(object sender, EventArgs e)
        {
            Lıstele();
        }
        void Lıstele()
        {
            gridControl1.DataSource = OdemeTurDal.OdemeTuruLıste(context);

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            Lıstele();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
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

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSıl_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string secilen = gridView1.GetFocusedRowCellValue(colODEMETURKOD).ToString();
                OdemeTurDal.Delete(context, c => c.ODEMETURKOD == secilen);
                OdemeTurDal.Save(context);
                Lıstele();
            }
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            FrmOdemeTuruIslem form = new FrmOdemeTuruIslem(new ODEMETUR());
            form.ShowDialog();
        }

        private void BtnDuzenle_Click(object sender, EventArgs e)
        {
            string secilen = gridView1.GetFocusedRowCellValue(colODEMETURKOD).ToString();
            FrmOdemeTuruIslem form = new FrmOdemeTuruIslem(OdemeTurDal.GetByFilter(context,c=>c.ODEMETURKOD==secilen));
            form.ShowDialog();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            string secilen = gridView1.GetFocusedRowCellValue(colODEMETURKOD).ToString();
           string SecilenAd = gridView1.GetFocusedRowCellValue(colODEMETURAD).ToString();
            FrmOdemeTuruHareket form = new FrmOdemeTuruHareket(secilen, SecilenAd);
            form.ShowDialog();
        }
    }
}