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

namespace NetSatıs.BackOffice.Ödeme_Türü
{
    public partial class FrmOdemeTuruHareket : DevExpress.XtraEditors.XtraForm
    {
        NetSatısContext context = new NetSatısContext();
        ODEMETURUDAL OdemeTurDal = new ODEMETURUDAL();
        private string _OdemeTuruKod;
        public FrmOdemeTuruHareket(string OdemeTuruKod, string OdemeTuruAd)
        {
            InitializeComponent();
            _OdemeTuruKod = OdemeTuruKod;
            LblBaslık.Text = OdemeTuruKod + " - " + OdemeTuruAd + " Hareketleri";
        }

        private void FrmOdemeTuruHareket_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {

            GridcontKasaHareket.DataSource = OdemeTurDal.GetAll(context, c => c.ODEMETURKOD == _OdemeTuruKod);
            gridContBakıye.DataSource = OdemeTurDal.OdemeTuruToplamLıstele(context, _OdemeTuruKod);
            gridContGenelToplam.DataSource = OdemeTurDal.GenelToplamLıstele(context, _OdemeTuruKod);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
          
           GridKasaHareket.OptionsView.ShowAutoFilterRow = false?true:false;

        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GridcontKasaHareket_Click(object sender, EventArgs e)
        {

        }
    }
}