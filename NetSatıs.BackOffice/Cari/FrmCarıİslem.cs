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
using NetSatıs.BackOffice.Tanım;

namespace NetSatıs.BackOffice.Cari
{
    public partial class FrmCarıİslem : DevExpress.XtraEditors.XtraForm
    {
        private Entities.Tables.CARI _entitiy;
        private CARIDAL CarıDal = new CARIDAL();
        private NetSatısContext context = new NetSatısContext();
        public bool saved = false;
        public FrmCarıİslem(Entities.Tables.CARI entity)
        {
            InitializeComponent();
            _entitiy = entity;
            toggleDurum.DataBindings.Add("EditValue", _entitiy, "DURUM");
            TxtCarıKodu.DataBindings.Add("Text", _entitiy, "CARIKOD");
            TxtCarıAd.DataBindings.Add("Text", _entitiy, "CARIAD");
            CmbCarıTuru.DataBindings.Add("Text", _entitiy, "CARITUR");
            TxtYetkılıKısı.DataBindings.Add("Text", _entitiy, "YETKILIKISI");
            TxtFaturaUnvanı.DataBindings.Add("Text", _entitiy, "FATURAUNVAN");
            TxtVergiDaıre.DataBindings.Add("Text", _entitiy, "VERGIDAIRE");
            TxtVergıNo.DataBindings.Add("Text", _entitiy, "VERGINO");
            TxtAcıklama.DataBindings.Add("Text", _entitiy, "ACIKLAMA");
            TxtCepTel.DataBindings.Add("Text", _entitiy, "CEPTELEFON");
            TxtSabıtTel.DataBindings.Add("Text", _entitiy, "TELEFON");
            TxtFax.DataBindings.Add("Text", _entitiy, "FAX");
            TxtEmaıl.DataBindings.Add("Text", _entitiy, "EMAIL");
            TxtWeb.DataBindings.Add("Text", _entitiy, "WEB");
            TxtIl.DataBindings.Add("Text", _entitiy, "IL");
            TxtIlce.DataBindings.Add("Text", _entitiy, "ILCE");
            TxtSempt.DataBindings.Add("Text", _entitiy, "SEMT");
            mmAdres.DataBindings.Add("Text", _entitiy, "ADRES");
            BtnCarıGrup.DataBindings.Add("Text", _entitiy, "CARIGRUP");
            BtntCarıAltGrup.DataBindings.Add("Text", _entitiy, "CARIALTGRUBU");
            BtnOzelKod1.DataBindings.Add("Text", _entitiy, "OZELKOD1");
            BtnOzelKod2.DataBindings.Add("Text", _entitiy, "OZELKOD2");
            BtnOzelKod3.DataBindings.Add("Text", _entitiy, "OZELKOD3");
            BtnOzelKod4.DataBindings.Add("Text", _entitiy, "OZELKOD4");
            CmbAlısOzelFıyat.DataBindings.Add("Text", _entitiy, "ALISOZELFIYAT");
            CmbSatısOzelFıyat.DataBindings.Add("Text", _entitiy, "SATISOZELFIYAT");


            CalcIskontoOranı.DataBindings.Add("Text", _entitiy, "ISKONTOORAN");
            CalcIskontoOranı.DataBindings[0].FormattingEnabled = true;
            CalcIskontoOranı.DataBindings[0].FormatString = "'%'0";
            CalcIskontoOranı.DataBindings[0].DataSourceNullValue = "0";



            CalcRıskLımıtı.DataBindings.Add("Text", _entitiy, "RISKLIMIT");
            CalcRıskLımıtı.DataBindings[0].FormattingEnabled = true;
            CalcRıskLımıtı.DataBindings[0].FormatString = "C2";
            CalcRıskLımıtı.DataBindings[0].DataSourceNullValue = "0";
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (CarıDal.AddDropUpdate(context, _entitiy))
            {
                CarıDal.Save(context);
                saved = true;
                this.Close();

            }
        }

        private void LBLBASLIK_Click(object sender, EventArgs e)
        {

        }

        private void FrmCarıİslem_Load(object sender, EventArgs e)
        {

        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnStokGrup_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
           
        }

        private void BtnCarıGrup_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    FrmTanım form = new FrmTanım(FrmTanım.TanımTuru.CarıGrubu);
                    form.ShowDialog();
                    if (form.Secıldı)
                    {
                        BtnCarıGrup.Text = form._entitiy.TANIMI;
                    }
                    
                    break;

                case 1:
                    BtnCarıGrup.Text = null;
                    break;
            }
        }

        private void BtnOzelKod1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    FrmTanım form = new FrmTanım(FrmTanım.TanımTuru.CarıOzelKod1);
                    form.ShowDialog();
                    if (form.Secıldı)
                    {
                        BtnOzelKod1.Text = form._entitiy.TANIMI;
                    }

                    break;

                case 1:
                    BtnOzelKod1.Text = null;
                    break;
            }
        }
    }
}