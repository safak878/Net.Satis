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
using NetSatıs.Entities.Data_Access;
using NetSatıs.Entities.Context;

namespace NetSatıs.BackOffice.Kasa
{
    public partial class FrmKasa : DevExpress.XtraEditors.XtraForm
    {
        KASADAL KasaDal = new KASADAL();
        NetSatısContext context = new NetSatısContext();
        string Secilen = null;
        public FrmKasa()
        {
            InitializeComponent();
        }
        public void Guncelle()
        {

            gridControl1.DataSource= KasaDal.KasaListe(context);

        }

        private void FrmKasa_Load(object sender, EventArgs e)
        {
            Guncelle();
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
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
            Guncelle();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            FrmKasaIslem form = new FrmKasaIslem(new Entities.Tables.KASA());
            form.ShowDialog();
            if (form.Kaydedildi)
            {
                Guncelle();
            }
        }

        private void BtnDuzenle_Click(object sender, EventArgs e)
        {
            Secilen = layoutView1.GetFocusedRowCellValue(colKASAKOD).ToString();
            FrmKasaIslem form = new FrmKasaIslem(KasaDal.GetByFilter(context, c => c.KASAKOD == Secilen));
            form.ShowDialog();
            if (form.Kaydedildi)
            {
                Guncelle();
            }
        }

        private void BtnSıl_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string Secilen = layoutView1.GetFocusedRowCellValue(colKASAKOD).ToString();
                KasaDal.Delete(context, c => c.KASAKOD == Secilen);
                KasaDal.Save(context);
                Guncelle();

            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            Secilen = layoutView1.GetFocusedRowCellValue(colKASAKOD).ToString();
            string SecilenAd = layoutView1.GetFocusedRowCellValue(colKASAAD).ToString();
            FrmKasaHareket form = new FrmKasaHareket(Secilen, SecilenAd);
            form.ShowDialog();
        }
    }
}