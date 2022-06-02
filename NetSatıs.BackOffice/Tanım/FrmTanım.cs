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
using NetSatıs.Entities.Tables;
using NetSatıs.Entities.Data_Access;

namespace NetSatıs.BackOffice.Tanım
{
    public partial class FrmTanım : DevExpress.XtraEditors.XtraForm
    {
        NetSatısContext context = new NetSatısContext();
        TANIMDAL TanımDal = new TANIMDAL();
        private TanımTuru _TanımTuru;
        public TANIM _entitiy;
        public bool Secıldı = false;
        public FrmTanım(TanımTuru TanımTur)
        {
            InitializeComponent();
            _TanımTuru = TanımTur;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(ColID));
            _entitiy = context.TANIMLAR.Where(c => c.ID == secilen).SingleOrDefault();
            Secıldı = true;
            this.Close();
        }
        public enum TanımTuru
        {
            CarıGrubu,
            CarıAltGrubu,
            CarıOzelKod1,
            CarıOzelKod2,
            CarıOzelKod3,
            CarıOzelKod4
        }
        private void FrmTanım_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void KayıtAc()
        {

            gridcontTanım.Enabled = false;
            BtnEkle.Enabled = false;
            BtnDuzenle.Enabled = false;
            BtnSıl.Enabled = false;
            BtnKaydet.Enabled = true;
            BtnVazgec.Enabled = true;
            navigationFrame1.SelectedPage = navigationPage1;

          
            TxtTanım.DataBindings.Add("Text", _entitiy, "TANIMI");
            TxtAcıklama.DataBindings.Add("Text", _entitiy, "ACIKLAMA");

        }
        void KayıtKapat()
        {

            gridcontTanım.Enabled = true;
            BtnEkle.Enabled = true;
            BtnDuzenle.Enabled = true;
            BtnSıl.Enabled = true;
            BtnKaydet.Enabled = false;
            BtnVazgec.Enabled = false;
            navigationFrame1.SelectedPage = navigationPage2;
            TxtTanım.DataBindings.Clear();
            TxtAcıklama.DataBindings.Clear();
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            _entitiy = new TANIM();
            KayıtAc();

        }

        private void BtnDuzenle_Click(object sender, EventArgs e)
        {
            int secilen=Convert.ToInt32(gridView1.GetFocusedRowCellValue(ColID));
            _entitiy = context.TANIMLAR.Where(c => c.ID == secilen).SingleOrDefault();
             KayıtAc();

        }
        void Listele()
        {
            gridcontTanım.DataSource = TanımDal.GetAll(context, c => c.TUR == _TanımTuru.ToString());
           
        }

        private void BtnSıl_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int secilen = Convert.ToInt32(gridView1.GetFocusedRowCellValue(ColID));
                TanımDal.Delete(context, c => c.ID == secilen);
                TanımDal.Save(context);
                Listele();

            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            _entitiy.TUR = _TanımTuru.ToString();
            if (TanımDal.AddDropUpdate(context, _entitiy))
            {
             
                TanımDal.Save(context);
                KayıtKapat();
                Listele();
            }
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            KayıtKapat();
        }
    }
}