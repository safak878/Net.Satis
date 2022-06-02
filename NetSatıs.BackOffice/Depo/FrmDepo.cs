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

namespace NetSatıs.BackOffice.Depo
{
    public partial class FrmDepo : DevExpress.XtraEditors.XtraForm
    {
        NetSatısContext context = new NetSatısContext();
        DEPODAL DepoDal = new DEPODAL();
        string secilen = null;
        public FrmDepo()
        {
            InitializeComponent();
        }

        private void FrmDepo_Load(object sender, EventArgs e)
        {
            Listele();
        }
        public void Listele()
        {

            gridControl1.DataSource = DepoDal.GetAll(context);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void BtnSıl_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string secilen = gridView1.GetFocusedRowCellValue(colDEPOKOD).ToString();
                DepoDal.Delete(context, c => c.DEPOKOD == secilen);
                DepoDal.Save(context);
                Listele();
            }
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            FrmDepoIslem form = new FrmDepoIslem(new Entities.Tables.DEPO());
            form.ShowDialog();
            if (form.Kaydedildi)
            {
                Listele();
            }
        }

        private void BtnDuzenle_Click(object sender, EventArgs e)
        {
            secilen = gridView1.GetFocusedRowCellValue(colDEPOKOD).ToString();
            FrmDepoIslem form = new FrmDepoIslem(DepoDal.GetByFilter(context, c => c.DEPOKOD == secilen));
            form.ShowDialog();
            if (form.Kaydedildi)
            {
                Listele();
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            secilen = gridView1.GetFocusedRowCellValue(colDEPOKOD).ToString();
            string SecilenAd = gridView1.GetFocusedRowCellValue(colDEPOAD).ToString();
            FrmDepoHareket form = new FrmDepoHareket(secilen, SecilenAd);
            form.ShowDialog();
        }
    }
}