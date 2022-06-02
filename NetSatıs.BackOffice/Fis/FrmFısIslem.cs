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
using System.Data.Entity;
using NetSatıs.BackOffice.Stok;
using NetSatıs.BackOffice.Cari;
using NetSatıs.BackOffice.Depo;
using NetSatıs.BackOffice.Kasa;

namespace NetSatıs.BackOffice.Fis
{
    public partial class FrmFısIslem : DevExpress.XtraEditors.XtraForm
    {
        NetSatısContext context = new NetSatısContext();
        FISDAL FısDal = new FISDAL();
        STOKHAREKETDAL StokHareketDal = new STOKHAREKETDAL();
        KASAHAREKETDAL KasaHareketDal = new KASAHAREKETDAL();
        CARIDAL CarıDal = new CARIDAL();
        FIS _FısEntitiy = new FIS();
        CARIBAKIYE entitiyBakıye = new CARIBAKIYE();
        public FrmFısIslem(string FısKodu=null )
        {
            InitializeComponent();
            if (FısKodu != null)
            {
                _FısEntitiy = context.FISLER.Where(c => c.FISKOD == FısKodu).SingleOrDefault();
                context.STOKHAREKET.Where(c => c.FISKOD == FısKodu).Load();
                context.KASAHAREKET.Where(c => c.FISKOD == FısKodu).Load();


                entitiyBakıye = this.CarıDal.CarıBakıyesı(context,_FısEntitiy.CARIKOD);

         
                LblAlacak.Text = entitiyBakıye.ALACAK.ToString("C2");
                LblBorc.Text = entitiyBakıye.BORC.ToString("C2");
                LblBakıye.Text = entitiyBakıye.BAKIYE.ToString("C2");



            }
   
            _FısEntitiy.FISTUR = "Alış Faturası";
            TxtFısKodu.DataBindings.Add("Text", _FısEntitiy, "FISKOD", false, DataSourceUpdateMode.OnPropertyChanged);
            TxtFısTuru.DataBindings.Add("Text", _FısEntitiy, "FISTUR", false, DataSourceUpdateMode.OnPropertyChanged);
            TxtTarıh.DataBindings.Add("EditValue", _FısEntitiy, "TARIH", false, DataSourceUpdateMode.OnPropertyChanged);
            TxtBelgeNo.DataBindings.Add("Text", _FısEntitiy, "BELGENO", false, DataSourceUpdateMode.OnPropertyChanged);
            CalcOdenenTutar.DataBindings.Add("Text", _FısEntitiy, "ACIKLAMA", false, DataSourceUpdateMode.OnPropertyChanged);
            LblCarıKodu.DataBindings.Add("Text", _FısEntitiy, "CARIKOD", false, DataSourceUpdateMode.OnPropertyChanged);
            LblCarıAd.DataBindings.Add("Text", _FısEntitiy, "CARIAD", false, DataSourceUpdateMode.OnPropertyChanged);
            TxtFaturaUnvanı.DataBindings.Add("Text", _FısEntitiy, "FATURAUNVANI", false, DataSourceUpdateMode.OnPropertyChanged);
            TxtCepTelefonu.DataBindings.Add("Text", _FısEntitiy, "CEPTELEFONU", false, DataSourceUpdateMode.OnPropertyChanged);
            TxtIl.DataBindings.Add("Text", _FısEntitiy, "IL", false, DataSourceUpdateMode.OnPropertyChanged);
            TxtIlce.DataBindings.Add("Text", _FısEntitiy, "ILCE", false, DataSourceUpdateMode.OnPropertyChanged);
            TxtSemt.DataBindings.Add("Text", _FısEntitiy, "SEMT", false, DataSourceUpdateMode.OnPropertyChanged);
            TxtAdres.DataBindings.Add("Text", _FısEntitiy, "ADRES", false, DataSourceUpdateMode.OnPropertyChanged);
            TxtVergıDaıresı.DataBindings.Add("Text", _FısEntitiy, "VERGIDAIRESI", false, DataSourceUpdateMode.OnPropertyChanged);
            TxtVergıNo.DataBindings.Add("Text", _FısEntitiy, "VERGINO", false, DataSourceUpdateMode.OnPropertyChanged);


            gridControl1.DataSource = context.KASAHAREKET.Local.ToBindingList();
            gridControl2.DataSource = context.STOKHAREKET.Local.ToBindingList();

            Toplamlar();
            OdenenTutarGuncelle();

            foreach (var Item in context.ODEMETURLERI.ToList())
            {

                var button = new SimpleButton
                {

                    Name = Item.ODEMETURKOD,
                    Text = Item.ODEMETURAD,
                    Height = 35,
                    Width = 100,
                    ForeColor = Color.Red



                };
                button.Click += OdemeEkle_Clıck;
                flowLayoutPanel1.Controls.Add(button);
            }

        }
        private void OdemeEkle_Clıck(object sender, EventArgs e)
        {
            var button = (sender as SimpleButton);
            KASA_HAREKET EntitiyKasaHareket = new KASA_HAREKET
            {
                ODEMETURKOD = button.Name,
                ODEMETURUAD = button.Text,
                TUTAR = CalcOdenmesıgereken.Value

            };
            if (CalcOdenmesıgereken.Value <= 0)
            {
                MessageBox.Show("Ödenmesi Gereken Tutar Zaten Ödenmiş Durumdadır");
            }
            else
            {

                KasaHareketDal.AddDropUpdate(context, EntitiyKasaHareket);
                OdenenTutarGuncelle();
            }
        }
        private void OdenenTutarGuncelle()
        {
            gridView1.UpdateSummary();
            CalcOdenen.Value = Convert.ToDecimal(colTUTAR.SummaryItem.SummaryValue);
            CalcOdenmesıgereken.Value = CalcGenelToplam.Value - CalcOdenen.Value;


        }
        private void FrmFısIslem_Load(object sender, EventArgs e)
        {


        }
        private STOKHAREKET StokSec(Entities.Tables.STOK entitiy)
        {

            STOKHAREKET StokHareket = new STOKHAREKET();
            StokHareket.STOKKODU = entitiy.STOKKODU;
            StokHareket.STOKAD = entitiy.STOKAD;
            StokHareket.BARKOD = entitiy.BARKOD;
            StokHareket.BARKODTUR = entitiy.BARKODTUR;
            StokHareket.BIRIMFIYAT = TxtFısTuru.Text == "Alış Faturası" ? entitiy.ALISFIYAT1 : entitiy.SATISFIYAT1;
            StokHareket.BIRIM = entitiy.BIRIM;
            StokHareket.KDV = entitiy.SATISKDV;
            StokHareket.MIKTAR = TxtMıktar.Value;
            StokHareket.INDIRIMORAN = 0;

            return StokHareket;


        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            FrmStokSec form = new FrmStokSec();
            form.ShowDialog();
            if (form.Secıldı)
            {
                StokHareketDal.AddDropUpdate(context, StokSec(form._secilen.First()));
                Toplamlar();
            }

        }

        private void TxtBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)

            {
                Entities.Tables.STOK entitiy;
                entitiy = context.STOKLAR.Where(c => c.BARKOD == TxtBarkod.Text).SingleOrDefault();
                if (entitiy != null)
                {
                    StokHareketDal.AddDropUpdate(context, StokSec(entitiy));
                    Toplamlar();

                }
                else
                {
                    MessageBox.Show("Aradığınız Barkod Numarası Ürünler Arasında Bulunamadı");
                }
                TxtBarkod.Text = null;

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmCariSec form = new FrmCariSec();
            form.ShowDialog();
            if (form.secildi)
            {
                Entities.Tables.CARI entitiy = form._secilen.FirstOrDefault();
                entitiyBakıye = this.CarıDal.CarıBakıyesı(context, entitiy.CARIKOD);

                LblCarıKodu.Text = entitiy.CARIKOD;
                LblCarıAd.Text = entitiy.CARIAD;
                TxtFaturaUnvanı.Text = entitiy.FATURAUNVAN;
                TxtVergıDaıresı.Text = entitiy.VERGIDAIRE;
                TxtVergıNo.Text = entitiy.VERGINO;
                TxtCepTelefonu.Text = entitiy.CEPTELEFON;
                TxtIl.Text = entitiy.IL;
                TxtIlce.Text = entitiy.ILCE;
                TxtSemt.Text = entitiy.SEMT;
                TxtAdres.Text = entitiy.ADRES;
                LblAlacak.Text = entitiyBakıye.ALACAK.ToString("C2");
                LblBorc.Text = entitiyBakıye.BORC.ToString("C2");
                LblBakıye.Text = entitiyBakıye.BAKIYE.ToString("C2");



            }
            CARIDAL CarıDal = new CARIDAL();
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LblBaslık_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            LblCarıKodu.Text = null;
            LblCarıAd.Text = null;
            TxtFaturaUnvanı.Text = null;
            TxtVergıDaıresı.Text = null;
            TxtVergıNo.Text = null;
            TxtCepTelefonu.Text = null;
            TxtIl.Text = null;
            TxtIlce.Text = null;
            TxtSemt.Text = null;
            TxtAdres.Text = null;
            LblAlacak.Text = "Görüntülenemiyor";
            LblBorc.Text = "Görüntülenemiyor";
            LblBakıye.Text = "Görüntülenemiyor";
        }


        private void gridView2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {

            Toplamlar();


        }
        private void Toplamlar()
        {
            gridView2.UpdateSummary();
            CalcIskontoTutar.Value = (Convert.ToDecimal(ColTOPLAMTUTAR.SummaryItem.SummaryValue) / 100) * (CalcIskontoOran.Value);
            CalcGenelToplam.Value = Convert.ToDecimal(ColTOPLAMTUTAR.SummaryItem.SummaryValue) - CalcIskontoTutar.Value;
            CalcKdvToplam.Value = Convert.ToDecimal(ColKDVTOPLAM.SummaryItem.SummaryValue);
            CalcIndırımTop.Value = Convert.ToDecimal(ColINDIRIMTUTAR.SummaryItem.SummaryValue);
            CalcOdenmesıgereken.Value = CalcGenelToplam.Value - CalcOdenen.Value;

        }

        private void CalcGenelToplam_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void CalcIskontoOran_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void CalcIskontoOran_Validated(object sender, EventArgs e)
        {
            Toplamlar();
        }

        private void RepoDepoSecım_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 0)
            {
                FrmDepoSec form = new FrmDepoSec(gridView2.GetFocusedRowCellValue(colSTOKKODU).ToString());
                form.ShowDialog();
                if (form.secildi)
                {
                    gridView2.SetFocusedRowCellValue(ColDEPOKOD, form.entitiy.DEPOKOD);
                    gridView2.SetFocusedRowCellValue(colDEPOAD, form.entitiy.DEPOAD);
                }
            }
        }

        private void RepoBırımFıyat_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string FıyatSecilen = gridView2.GetFocusedRowCellValue(colSTOKKODU).ToString();
            STOK FıyatEntitiy = context.STOKLAR.Where(c => c.STOKKODU == FıyatSecilen).SingleOrDefault();
            BarFıyat1.Tag =TxtFısTuru.Text=="Alış Faturası" ? FıyatEntitiy.ALISFIYAT1  ?? 0 : FıyatEntitiy.SATISFIYAT1 ?? 0;
            BarFıyat2.Tag = TxtFısTuru.Text == "Alış Faturası" ? FıyatEntitiy.ALISFIYAT2 ?? 0 : FıyatEntitiy.SATISFIYAT2 ?? 0; 
            BarFıyat3.Tag = TxtFısTuru.Text == "Alış Faturası" ? FıyatEntitiy.ALISFIYAT3 ?? 0 : FıyatEntitiy.SATISFIYAT3 ?? 0;
            BarFıyat1.Caption = string.Format("{0:C2} ", BarFıyat1.Tag);
            BarFıyat2.Caption = string.Format("{0:C2} ", BarFıyat2.Tag);
            BarFıyat3.Caption = string.Format("{0:C2} ", BarFıyat3.Tag);
            radialMenu1.ShowPopup(MousePosition);
        }

        private void FiyatSec(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridView2.SetFocusedRowCellValue(colBIRIMFIYAT, Convert.ToDecimal(e.Item.Tag));
        }

        private void RepoSerıNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            string Verı = Convert.ToString(gridView2.GetFocusedRowCellValue(colSERINO));
            FrmSerıNoGır form = new FrmSerıNoGır(Verı);
            form.ShowDialog();
            gridView2.SetFocusedRowCellValue(colSERINO, form.VerıSerıNo);

        }

        private void RepoSıl_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gridView2.DeleteSelectedRows();
            }
        }

        private void RepoKasa_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FrmKasaSec form = new FrmKasaSec();
            form.ShowDialog();
            if (form.Secıldı)
            {
                gridView1.SetFocusedRowCellValue(colKASAKOD, form._entitiy.KASAKOD);
                gridView1.SetFocusedRowCellValue(colKASAAD, form._entitiy.KASAAD);
            }
        }

        private void RepoKasaSıl_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
            //    gridView1.DeleteSelectedRows();
            //    OdenenTutarGuncelle();
            //}
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {




        }

        private void BtnKaydet_Click_1(object sender, EventArgs e)
        {

            int StokHata = context.STOKHAREKET.Local.Where(c => c.DEPOKOD == null).Count();
            int KasaHata = context.KASAHAREKET.Local.Where(c => c.KASAKOD == null).Count();
            if (StokHata == 0 && KasaHata == 0)
            {
                foreach (var StokVerı in context.STOKHAREKET.Local.ToList())
                {
                    StokVerı.TARIH = StokVerı.TARIH == null ? Convert.ToDateTime(TxtTarıh.DateTime) : Convert.ToDateTime(StokVerı.TARIH);
                    StokVerı.FISKOD = TxtFısKodu.Text;
                    StokVerı.HAREKET = _FısEntitiy.FISTUR == "Alış Faturası" ? "Stok Giriş" : "Stok Çıkış";
                }
                foreach (var KasaVerı in context.KASAHAREKET.Local.ToList())
                {
                    KasaVerı.TARIH = KasaVerı.TARIH == null ? Convert.ToDateTime(TxtTarıh.DateTime) : Convert.ToDateTime(KasaVerı.TARIH);
                    KasaVerı.FISKOD = TxtFısKodu.Text;
                    KasaVerı.HAREKET = _FısEntitiy.FISTUR == "Alış Faturası" ? "Kasa Çıkış" : "Kasa Giriş";
                    KasaVerı.CARIKOD = LblCarıKodu.Text;
                    KasaVerı.CARIAD = LblCarıAd.Text;
                }

                _FısEntitiy.TOPLAMTUTAR = CalcGenelToplam.Value;
                _FısEntitiy.ISKONTOORAN = CalcIskontoOran.Value;
                _FısEntitiy.ISKONTUTAR = CalcIskontoTutar.Value;
                FısDal.AddDropUpdate(context, _FısEntitiy);
            }
 
            context.SaveChanges();
        }
    }
}