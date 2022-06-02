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

namespace NetSatıs.BackOffice.Stok
{
    public partial class FrmStokSec : DevExpress.XtraEditors.XtraForm
    {
        STOKDAL StokDal = new STOKDAL();
        NetSatısContext context = new NetSatısContext();
        public List<Entities.Tables.STOK> _secilen = new List<Entities.Tables.STOK>
        {

        };
        public bool Secıldı = false;
        public FrmStokSec(bool CokluSecim=false)
        {
            InitializeComponent();
            if (CokluSecim)
            {
                lblUyarı.Visible = true;
                gridstoklar.OptionsSelection.MultiSelect = true;

            }
          
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            if (gridstoklar.GetSelectedRows().Length != 0)
            {
                foreach (var row in gridstoklar.GetSelectedRows())
                {
                    string stokkodu = gridstoklar.GetRowCellValue(row, colSTOKKODU).ToString();
                    _secilen.Add(context.STOKLAR.SingleOrDefault(c => c.STOKKODU == stokkodu));
                }
                Secıldı = true;
                this.Close();
            }
            else
            {

                MessageBox.Show("Seçilen Bir Ürün Bulunamadı");
            }
           
        }

        private void FrmStokSec_Load(object sender, EventArgs e)
        {
            gridcontStoklar.DataSource = StokDal.GetAllJoin(context);
        }
    }
}