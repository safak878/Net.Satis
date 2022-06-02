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
using NetSatıs.BackOffice.Fis;

namespace NetSatıs.BackOffice.Stok_Hareketleri
{
    public partial class FrmStokHareketlerı : DevExpress.XtraEditors.XtraForm
    {

        NetSatısContext context = new NetSatısContext();
        STOKHAREKETDAL StokHareketDal = new STOKHAREKETDAL();
        public FrmStokHareketlerı()
        {
            InitializeComponent();

        }
        private void Lıstele()
        {

          gridControl1.DataSource=  StokHareketDal.GetAll(context);
        }

        private void FrmStokHareketlerı_Load(object sender, EventArgs e)
        {
            Lıstele();
        }

        private void BtnDuzenle_Click(object sender, EventArgs e)
        {
            Lıstele();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Both;
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel2;
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            filterControl1.ApplyFilter();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            filterControl1.FilterString = null;
            filterControl1.ApplyFilter();
        }

        private void RepoSerıNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string Verı = Convert.ToString(gridView1.GetFocusedRowCellValue(colSERINO));
            FrmSerıNoGır form = new FrmSerıNoGır(Verı);
            form.Kilitli = true;
            form.ShowDialog();
            //gridView1.SetFocusedRowCellValue(colSERINO, form.VerıSerıNo);
        }
    }
}