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

    public partial class FrmKasaHareket : DevExpress.XtraEditors.XtraForm
    {
        KASADAL KasaDal = new KASADAL();
        NetSatısContext context = new NetSatısContext();
        private string _KasaKod;
        public FrmKasaHareket(string KasaKodu, string KasaAdı)
        {
            InitializeComponent();
            _KasaKod = KasaKodu;

            LblBaslık.Text = KasaKodu + " - " + KasaAdı + " Hareketleri";
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmKasaHareket_Load(object sender, EventArgs e)
        {
            Guncelle();
        }
        public void Guncelle()
        {
            gridControl1.DataSource = KasaDal.GetAll(context, c => c.KASAKOD == _KasaKod);
            gridContOdemeTuruToplam.DataSource = KasaDal.OdemeTuruToplamLıstele(context, _KasaKod);
            gridContKasaGenelToplam.DataSource = KasaDal.GenelToplamLıstele(context, _KasaKod);

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            if (gridView1.OptionsView.ShowAutoFilterRow == true)
            {

                gridView1.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                gridView1.OptionsView.ShowAutoFilterRow = true;
            }

        }
    }
}