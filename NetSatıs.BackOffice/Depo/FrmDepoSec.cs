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
    
    public partial class FrmDepoSec : DevExpress.XtraEditors.XtraForm
    {
        NetSatısContext context = new NetSatısContext();
        DEPODAL DepoDal = new DEPODAL();
        public Entities.Tables.DEPO entitiy = new Entities.Tables.DEPO();
        string _StokKodu;
        public bool secildi = false;
        public FrmDepoSec(string StokKodu)
        {
            InitializeComponent();
            _StokKodu = StokKodu;

        }

        private void FrmDepoSec_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = DepoDal.DepoBazındaStokLıstele(context, _StokKodu);

        }

        private void BtnSec_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount != 0)
            {
                string DepoKodu = gridView1.GetFocusedRowCellValue(colDEPOKOD).ToString();
                entitiy = context.DEPOLAR.SingleOrDefault(c => c.DEPOKOD == DepoKodu);
                secildi = true;
                this.Close();
            }
        }
    }
}