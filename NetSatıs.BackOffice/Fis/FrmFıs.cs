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

namespace NetSatıs.BackOffice.Fis
{
    public partial class BarAlısFaturası : DevExpress.XtraEditors.XtraForm
    {
        NetSatısContext context = new NetSatısContext();
        FISDAL FısDal = new FISDAL();
        KASAHAREKETDAL KasaHareketDal = new KASAHAREKETDAL();
        STOKHAREKETDAL StokHareketDal = new STOKHAREKETDAL();
        public BarAlısFaturası()
        {
            InitializeComponent();
        }

        private void FrmFıs_Load(object sender, EventArgs e)
        {
            Lıstele();

        }
        private void Lıstele()
        {

            gridControl1.DataSource = FısDal.GetAll(context);

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            Lıstele();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
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

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void BtnSıl_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string secilen = gridView1.GetFocusedRowCellValue(colFISKOD).ToString();
                FısDal.Delete(context, c => c.FISKOD == secilen);
                KasaHareketDal.Delete(context, c => c.FISKOD == secilen);
                StokHareketDal.Delete(context, c => c.FISKOD == secilen);
                FısDal.Save(context);
                Lıstele();
            }
        }
    }
}