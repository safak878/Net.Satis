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

namespace NetSatıs.BackOffice.Fis
{
    public partial class FrmSerıNoGır : DevExpress.XtraEditors.XtraForm
    {
        public string VerıSerıNo;
        public bool Kilitli=true;
        public FrmSerıNoGır(string Verı)
        {
            InitializeComponent();
            if (Verı != null)
            {
                string[] VerıLıstesı = Verı.Split(new[] { System.Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var Item in VerıLıstesı)
                {
                    listBoxControl1.Items.Add(Item);
                }
            }
            if (Kilitli)
            {

                GrupMenu.Enabled = false;
            }
        }
        void KayıtAc()
        {
            BtnYenı.Enabled = false;
            BtnSıl.Enabled = false;
            BtnKaydet.Enabled = true;
            BtnVazgec.Enabled = true;
            GrupBılgı.Enabled = true;
            TxtSerı.Focus();

        }
        void KayıtKapat()
        {
            BtnYenı.Enabled = true;
            BtnSıl.Enabled = true;
            BtnKaydet.Enabled = false;
            BtnVazgec.Enabled = false;
            GrupBılgı.Enabled = false;
            TxtSerı.Text = null;

        }
        private void FrmSerıNoGır_Load(object sender, EventArgs e)
        {

        }

        private void BtnYenı_Click(object sender, EventArgs e)
        {
            KayıtAc();
            
        }

        private void BtnSıl_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                listBoxControl1.Items.Remove(listBoxControl1.SelectedItem);
            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            listBoxControl1.Items.Add(TxtSerı.Text);
            KayıtKapat();
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            KayıtKapat();
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSerıNoGır_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (listBoxControl1.Items.Count != 0)
            {
                foreach (var Item in listBoxControl1.Items)
                {
                    VerıSerıNo += Item + System.Environment.NewLine;
                }
            }
        }
    }
}