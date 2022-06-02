using NetSatıs.Entities.Context;
using NetSatıs.Entities.Data_Access;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetSatıs.BackOffice.Stok
{
    public partial class FrmStokİslem : Form
    {
        private Entities.Tables.STOK _entitiy;
        private STOKDAL StokDal = new STOKDAL();
        private NetSatısContext context  = new NetSatısContext();
        public bool saved = false;
        public FrmStokİslem(Entities.Tables.STOK entitiy)
        {
            InitializeComponent();
            _entitiy = entitiy;

            toggleDurum.DataBindings.Add("EditValue", _entitiy, "DURUM", false, DataSourceUpdateMode.OnPropertyChanged);
            TxtStokKodu.DataBindings.Add("Text", _entitiy, "STOKKODU", false, DataSourceUpdateMode.OnPropertyChanged);
            TxtBarkod.DataBindings.Add("Text", _entitiy, "BARKOD", false, DataSourceUpdateMode.OnPropertyChanged);
            CmbBarkodTuru.DataBindings.Add("Text", _entitiy, "BARKODTUR", false, DataSourceUpdateMode.OnPropertyChanged);
            TxtStokAd.DataBindings.Add("Text", _entitiy, "STOKAD", false, DataSourceUpdateMode.OnPropertyChanged);
            BtnBirimi.DataBindings.Add("Text", _entitiy, "BIRIM", false, DataSourceUpdateMode.OnPropertyChanged);
            TxtUretıcıKod.DataBindings.Add("Text", _entitiy, "URETICIKOD", false, DataSourceUpdateMode.OnPropertyChanged);
            TxtGarantiSüresi.DataBindings.Add("Text", _entitiy, "GARANTISURE", false, DataSourceUpdateMode.OnPropertyChanged);
            CalcMaxStokMiktar.DataBindings.Add("EditValue", _entitiy, "MAXSTOKMIKTAR", true, DataSourceUpdateMode.OnPropertyChanged);
            CalcMaxStokMiktar.DataBindings[0].FormattingEnabled = true;
            CalcMaxStokMiktar.DataBindings[0].FormatString = "N3";
            CalcMinStokMiktar.DataBindings.Add("EditValue", _entitiy, "MINSTOKMIKTAR", true, DataSourceUpdateMode.OnPropertyChanged);
            CalcMinStokMiktar.DataBindings[0].FormattingEnabled = true;
            CalcMinStokMiktar.DataBindings[0].FormatString = "N3";
            TxtAcıklama.DataBindings.Add("Text", _entitiy, "ACIKLAMA", false, DataSourceUpdateMode.OnPropertyChanged);
            BtnStokGrup.DataBindings.Add("Text", _entitiy, "STOKGRUP", false, DataSourceUpdateMode.OnPropertyChanged);
            BtntStokAltGrup.DataBindings.Add("Text", _entitiy, "STOKALTGRUP", false, DataSourceUpdateMode.OnPropertyChanged);
            BtnMarka.DataBindings.Add("Text", _entitiy, "MARKA", false, DataSourceUpdateMode.OnPropertyChanged);
            BtnModel.DataBindings.Add("Text", _entitiy, "MODEL");
            BtnOzelKod1.DataBindings.Add("Text", _entitiy, "OZELKOD1", false, DataSourceUpdateMode.OnPropertyChanged);
            BtnOzelKod2.DataBindings.Add("Text", _entitiy, "OZELKOD2", false, DataSourceUpdateMode.OnPropertyChanged);
            BtnOzelKod3.DataBindings.Add("Text", _entitiy, "OZELKOD3", false, DataSourceUpdateMode.OnPropertyChanged);
            BtnOzelKod4.DataBindings.Add("Text", _entitiy, "OZELKOD4", false, DataSourceUpdateMode.OnPropertyChanged);

            CalcAlısKdv.DataBindings.Add("EditValue", _entitiy, "ALISKDV", true, DataSourceUpdateMode.OnPropertyChanged);
            CalcAlısKdv.DataBindings[0].FormattingEnabled = true;
            CalcAlısKdv.DataBindings[0].FormatString = "'%'0";
            CalcAlısKdv.DataBindings[0].DataSourceNullValue = "0";

            CalcSatısKdv.DataBindings.Add("EditValue", _entitiy, "SATISKDV", true, DataSourceUpdateMode.OnPropertyChanged);
            CalcSatısKdv.DataBindings[0].FormattingEnabled = true;
            CalcSatısKdv.DataBindings[0].FormatString = "'%'0";
            CalcSatısKdv.DataBindings[0].DataSourceNullValue = "0";

            CalcAlısFıyat1.DataBindings.Add("EditValue", _entitiy, "ALISFIYAT1", true, DataSourceUpdateMode.OnPropertyChanged);
            CalcAlısFıyat1.DataBindings[0].FormattingEnabled = true;
            CalcAlısFıyat1.DataBindings[0].FormatString = "C2";

            CalcAlısFıyat2.DataBindings.Add("EditValue", _entitiy, "ALISFIYAT2", true, DataSourceUpdateMode.OnPropertyChanged);
            CalcAlısFıyat2.DataBindings[0].FormattingEnabled = true;
            CalcAlısFıyat2.DataBindings[0].FormatString = "C2";

            CalcAlısFıyat3.DataBindings.Add("EditValue", _entitiy, "ALISFIYAT3", true, DataSourceUpdateMode.OnPropertyChanged);
            CalcAlısFıyat3.DataBindings[0].FormattingEnabled = true;
            CalcAlısFıyat3.DataBindings[0].FormatString = "C2";

            CalcSatısFıyat1.DataBindings.Add("EditValue", _entitiy, "SATISFIYAT1", true, DataSourceUpdateMode.OnPropertyChanged);
            CalcSatısFıyat1.DataBindings[0].FormattingEnabled = true;
            CalcSatısFıyat1.DataBindings[0].FormatString = "C2";

            CalcSatısFıyat2.DataBindings.Add("EditValue", _entitiy, "SATISFIYAT2", true, DataSourceUpdateMode.OnPropertyChanged);
            CalcSatısFıyat2.DataBindings[0].FormattingEnabled = true;
            CalcSatısFıyat2.DataBindings[0].FormatString = "C2";

            CalcSatısFıyat3.DataBindings.Add("EditValue", _entitiy, "SATISFIYAT3", true, DataSourceUpdateMode.OnPropertyChanged);
            CalcSatısFıyat3.DataBindings[0].FormattingEnabled = true;
            CalcSatısFıyat3.DataBindings[0].FormatString = "C2";
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmStokİslem_Load(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
        //    StokDal.AddDropUpdate(context,_entitiy);
        //    StokDal.Save(context);
        //    this.Close();
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmStokİslem_Load_1(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click_1(object sender, EventArgs e)
        {
            if (StokDal.AddDropUpdate(context, _entitiy))
            {
                StokDal.Save(context);
                saved = true;
                this.Close();
            }
         
        }

        private void BtnKapat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
