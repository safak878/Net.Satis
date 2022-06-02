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
    public partial class FrmKasaSec : DevExpress.XtraEditors.XtraForm
    { KASADAL KaasaDal = new KASADAL();
        NetSatısContext context = new NetSatısContext();
        public Entities.Tables.KASA _entitiy = new Entities.Tables.KASA();
        public bool Secıldı = false;

        public FrmKasaSec()
        {
            InitializeComponent();
        }

        private void FrmKasaSec_Load(object sender, EventArgs e)
        {
            gridcontKasa.DataSource = KaasaDal.KasaListe(context);
        }

        private void BtnSec_Click(object sender, EventArgs e)
        {
            if (gridKasa.GetSelectedRows().Length != 0)
            {


                string KasaKod = gridKasa.GetFocusedRowCellValue(ColKasaKod).ToString();
                _entitiy = context.KASALAR.SingleOrDefault(c => c.KASAKOD == KasaKod);
                Secıldı = true;
                this.Close();
            }
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}