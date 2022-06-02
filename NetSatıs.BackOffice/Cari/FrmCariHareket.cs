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

namespace NetSatıs.BackOffice.Cari
{

    public partial class FrmCariHareket : DevExpress.XtraEditors.XtraForm
    {
        CARIDAL CarıDal = new CARIDAL();
        NetSatısContext context = new NetSatısContext();
        private string _carıkod = null;
        public FrmCariHareket(string CarıKod,string CarıAd)
        {
      
            InitializeComponent();
            _carıkod = CarıKod;
            LblBaslık.Text = _carıkod + " - " + CarıAd + " Hareketleri";
        }

        private void FrmCariHareket_Load(object sender, EventArgs e)
        {
            Guncelle();
        }
        private void Guncelle()
        {

            GridcontFısToplam.DataSource = CarıDal.CariFisGenelToplam(context, _carıkod);
            GridcontBakiye.DataSource = CarıDal.CarıGenelToplam(context, _carıkod);
            GridcontCarıHareket.DataSource= CarıDal.CariFisAyrıntı(context, _carıkod);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            if (GridCarıHareket.OptionsView.ShowAutoFilterRow == true)
            {

                GridCarıHareket.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                GridCarıHareket.OptionsView.ShowAutoFilterRow = true;
            }

        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}