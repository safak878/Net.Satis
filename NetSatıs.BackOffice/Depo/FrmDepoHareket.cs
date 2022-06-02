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
    public partial class FrmDepoHareket : DevExpress.XtraEditors.XtraForm
    {
        NetSatısContext context = new NetSatısContext();
        STOKHAREKETDAL StokHareketDal = new STOKHAREKETDAL();
        private string _DepoKodu;
        public FrmDepoHareket(string DepoKodu,string DepoAdı)
        {
            InitializeComponent();
            _DepoKodu = DepoKodu;
            LblBaslık.Text = DepoKodu + " - " + DepoAdı + " Hareketleri";
        }

        private void FrmDepoHareket_Load(object sender, EventArgs e)
        {
            Guncelle();
        }
        private void Guncelle()
        {
            gridControl1.DataSource = StokHareketDal.GetAll(context, c => c.DEPOKOD == _DepoKodu);
            gridControl2.DataSource = StokHareketDal.DepoStokLıstele(context,_DepoKodu);
            gridControl3.DataSource = StokHareketDal.DepoIstatıskLıstele(context, _DepoKodu);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
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