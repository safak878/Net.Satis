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
using NetSatıs.Entities.Tables;
namespace NetSatıs.BackOffice.Ödeme_Türü
{
    public partial class FrmOdemeTuruIslem : DevExpress.XtraEditors.XtraForm
    {
        ODEMETURUDAL OdemeTuruDal = new ODEMETURUDAL();
        NetSatısContext context = new NetSatısContext();
         private ODEMETUR _entitiy;
        public FrmOdemeTuruIslem(ODEMETUR entitiy)
        {
            InitializeComponent();
            _entitiy = entitiy;

        }

        private void FrmOdemeTuruIslem_Load(object sender, EventArgs e)
        {
            TxtOdemeKodu.DataBindings.Add("Text", _entitiy, "ODEMETURKOD");
            TxtOdemeAdı.DataBindings.Add("Text", _entitiy, "ODEMETURAD");
            TxtAcıklama.DataBindings.Add("Text", _entitiy, "ACIKLAMA");
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (OdemeTuruDal.AddDropUpdate(context, _entitiy))
            {
                OdemeTuruDal.Save(context);
                this.Close();

            }
        }
    }
}