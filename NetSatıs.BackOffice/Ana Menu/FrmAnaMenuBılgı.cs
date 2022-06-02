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

namespace NetSatıs.BackOffice.Ana_Menu
{
    public partial class FrmAnaMenuBılgı : DevExpress.XtraEditors.XtraForm
    {
        public FrmAnaMenuBılgı()
        {
            InitializeComponent();
        }

        private void tileControl1_Click(object sender, EventArgs e)
        {

        }
        Depo.FrmDepo z;
        private void tileItem18_ItemClick(object sender, TileItemEventArgs e)
        {
            
            if (z == null || z.IsDisposed)
            {
                z = new Depo.FrmDepo();
                //z.MdiParent = this;
                z.Show();
            }
        }
        Kasa.FrmKasa c;
        private void tileItem19_ItemClick(object sender, TileItemEventArgs e)
        {
            if (c == null || c.IsDisposed)
            {
                c = new Kasa.FrmKasa();
                //c.MdiParent = this;
                c.Show();
            }
        }
        Ödeme_Türü.FrmOdemeTuru d;
        private void tileItem20_ItemClick(object sender, TileItemEventArgs e)
        {
            if (d == null || d.IsDisposed)
            {
                d = new Ödeme_Türü.FrmOdemeTuru();
                //d.MdiParent = this;
                d.Show();
            }
        }

        private void tileItem21_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void tileItem11_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void tileItem22_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void tileItem23_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void tileItem12_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void tileItem15_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void tileItem24_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void tileItem25_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void tileItem16_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void tileItem17_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void tileItem26_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void tileItem29_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void tileItem27_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void tileItem2_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void tileItem5_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void tileItem3_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void tileItem4_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void tileItem6_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void tileItem28_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void tileItem31_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void tileItem10_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void tileItem9_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void tileItem36_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void tileItem33_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void tileItem8_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void tileItem7_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void tileItem30_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void tileItem32_ItemClick(object sender, TileItemEventArgs e)
        {

        }

        private void tileItem35_ItemClick(object sender, TileItemEventArgs e)
        {

        }
        Stok.FrmStok a;
        private void Stoklar_ItemClick(object sender, TileItemEventArgs e)
        {
            if (a == null || a.IsDisposed)
            {
                a = new Stok.FrmStok();
                //a.MdiParent = this;
                a.Show();
            }
        }
        Cari.FrmCari b;
        private void Cariler_ItemClick(object sender, TileItemEventArgs e)
        {
            if (b == null || b.IsDisposed)
            {
                b = new Cari.FrmCari();
                //b.MdiParent = this;
                b.Show();
            }
        }
        Fis.FrmFısIslem q;
        private void cdewdwedw_ItemClick(object sender, TileItemEventArgs e)
        {
            if (q == null || q.IsDisposed)
            {
                q = new Fis.FrmFısIslem();
                //b.MdiParent = this;
                q.Show();
            }
        }
    }
}