using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace NetSatıs.BackOffice
{
    public partial class NetSatıs : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public NetSatıs()
        {
            InitializeComponent();
        }
       Stok.FrmStok  a;
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (a == null || a.IsDisposed)
            {
                a = new Stok.FrmStok();
                a.MdiParent = this;
                a.Show();
            }
        }
        Cari.FrmCari b;
        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (b == null || b.IsDisposed)
            {
                b = new Cari.FrmCari();
                b.MdiParent = this;
                b.Show();
            }
        }
        Kasa.FrmKasa c;
        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (c == null || c.IsDisposed)
            {
                c = new Kasa.FrmKasa();
                c.MdiParent = this;
                c.Show();
            }
        }
        Ödeme_Türü.FrmOdemeTuru d;
        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (d == null || d.IsDisposed)
            {
                d = new Ödeme_Türü.FrmOdemeTuru();
                d.MdiParent = this;
                d.Show();
            }
        }
        Depo.FrmDepo z;
        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (z == null || z.IsDisposed)
            {
                z = new Depo.FrmDepo();
                z.MdiParent = this;
                z.Show();
            }
        }
      
        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
        }
        Ana_Menu.FrmAnaMenuBılgı p;
        private void NetSatıs_Load(object sender, EventArgs e)
        {
            if (p == null || p.IsDisposed)
            {
                p = new Ana_Menu.FrmAnaMenuBılgı();
                p.MdiParent = this;
                p.Show();
            }
        }

        private void barButtonItem40_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (p == null || p.IsDisposed)
            {
                p = new Ana_Menu.FrmAnaMenuBılgı();
                p.MdiParent = this;
                p.Show();
            }
        }
        Fis.FrmFısIslem u;
        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (u == null || u.IsDisposed)
            {
                u = new Fis.FrmFısIslem();
         
                u.Show();
            }
        }
        Stok_Hareketleri.FrmStokHareketlerı ut;
        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (ut == null || ut.IsDisposed)
            {
                ut = new Stok_Hareketleri.FrmStokHareketlerı();
                ut.MdiParent = this;
                ut.Show();
            }
        }
    }
}