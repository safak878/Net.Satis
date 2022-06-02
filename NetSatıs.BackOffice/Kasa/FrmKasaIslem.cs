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
    public partial class FrmKasaIslem : DevExpress.XtraEditors.XtraForm
    {
        KASADAL KasaDal = new KASADAL();
        NetSatısContext context = new NetSatısContext();
        public bool Kaydedildi = false;
        private Entities.Tables.KASA _entitiy;
        public FrmKasaIslem(Entities.Tables.KASA entitiy)
        {
            InitializeComponent();
            _entitiy = entitiy;
            TxtKasaKodu.DataBindings.Add("Text", _entitiy, "KASAKOD");
            TxtKasaAdı.DataBindings.Add("Text", _entitiy, "KASAAD");
            TxtYetkılıKodu.DataBindings.Add("Text", _entitiy, "YETKILIKOD");
            TxtYetkılıAdı.DataBindings.Add("Text", _entitiy, "YETKILIAD");
            TxtAcıklama.DataBindings.Add("Text", _entitiy, "ACIKLAMA");

        }

        private void FrmKasaIslem_Load(object sender, EventArgs e)
        {

        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (KasaDal.AddDropUpdate(context, _entitiy))
            {
                KasaDal.Save(context);
                Kaydedildi = true;
                this.Close();
            }
        }
    }
}