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

namespace NetSatıs.BackOffice.Depo
{
    public partial class FrmDepoIslem : DevExpress.XtraEditors.XtraForm
    {
        DEPODAL DepoDal = new DEPODAL();
        NetSatısContext context = new NetSatısContext();
        private Entities.Tables.DEPO _entitiy;
        public bool Kaydedildi = false;
        public FrmDepoIslem(Entities.Tables.DEPO entitiy)
        {
            InitializeComponent();
            _entitiy = entitiy;
            TxtDepoKodu.DataBindings.Add("Text", _entitiy, "DEPOKOD");
            TxtDepoAdı.DataBindings.Add("Text", _entitiy, "DEPOAD");
            TxtYetkılıKodu.DataBindings.Add("Text", _entitiy, "YETKILIKOD");
            TxtYetkılıAdı.DataBindings.Add("Text", _entitiy, "YETKILIAD");
            TxtTelefon.DataBindings.Add("Text", _entitiy, "TELEFON");
            TxtIl.DataBindings.Add("Text", _entitiy, "IL");
            TxtIlce.DataBindings.Add("Text", _entitiy, "ILCE");
            TxtSemt.DataBindings.Add("Text", _entitiy, "SEMT");
            TxtAdres.DataBindings.Add("Text", _entitiy, "ADRES");
            TxtAcıklama.DataBindings.Add("Text", _entitiy, "ACIKLAMA");
        }

        private void FrmDepoIslem_Load(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {

            if (DepoDal.AddDropUpdate(context, _entitiy))
            {
                DepoDal.Save(context);
                this.Close();
            }
        }

        private void GrupMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}