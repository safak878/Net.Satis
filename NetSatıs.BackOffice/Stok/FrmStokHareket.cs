using System;
using NetSatıs.Entities.Data_Access;
using NetSatıs.Entities.Context;

namespace NetSatıs.BackOffice.Stok
{
    public partial class FrmStokHareket : DevExpress.XtraEditors.XtraForm
    {
  
        STOKHAREKETDAL StokHareketDal = new STOKHAREKETDAL();
        NetSatısContext context = new NetSatısContext();
        private string _stokKodu;
        
        public FrmStokHareket(string stokKodu,string StokAdı)
        {
            InitializeComponent();
            _stokKodu = stokKodu;
            LblBaslık.Text = _stokKodu + " - " + StokAdı+ " Hareketleri" ;
        }

     
        private void FrmStokHareket_Load(object sender, EventArgs e)
        {
            Guncelle();
        }
        private void Guncelle()
        {

            gridControl1.DataSource = StokHareketDal.GetAll(context, c => c.STOKKODU == _stokKodu);
            gridControl3.DataSource = StokHareketDal.GetGenelStok(context, _stokKodu);
            gridControl2.DataSource = StokHareketDal.GetDepoStok(context, _stokKodu);

        }
        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            if (gridView1.OptionsView.ShowAutoFilterRow ==true)
            {

                gridView1.OptionsView.ShowAutoFilterRow = false;
            }
            else
            {
                gridView1.OptionsView.ShowAutoFilterRow = true;
            }

        }
    }
}