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
using NetSatıs.Entities.Tables;

namespace NetSatıs.BackOffice.Cari
{
       
        public partial class FrmCariSec : DevExpress.XtraEditors.XtraForm
        { CARIDAL CarıDal = new CARIDAL();
        NetSatısContext context = new NetSatısContext();
        public List<Entities.Tables.CARI> _secilen = new List<Entities.Tables.CARI>();
     
        public bool secildi = false;
            public FrmCariSec(bool CokluSecim = false)
            {
                InitializeComponent();
                if (CokluSecim)
                {
                    lblUyarı.Visible = true;
                    gridView1.OptionsSelection.MultiSelect = true;

                }

            }

            private void FrmCariSec_Load(object sender, EventArgs e)
            {

                gridControl1.DataSource = CarıDal.GetCarıler(context);
            }

        private void BtnSec_Click(object sender, EventArgs e)
        {
            if (gridView1.GetSelectedRows().Length!=0){



                foreach (var row in gridView1.GetSelectedRows())
                {
                    string carıkodu = gridView1.GetRowCellValue(row, colCARIKOD).ToString();
                    _secilen.Add(context.CARİLER.SingleOrDefault(c => c.CARIKOD == carıkodu));
                   
                }
                secildi = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Seçilen Bir Cari Bulunamadı");
            }

        }
        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }