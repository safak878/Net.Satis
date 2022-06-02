using NetSatıs.Entities.Interfacess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetSatıs.Entities.Context;
using NetSatıs.Entities.Tables;
using System.Linq.Expressions;
using System.Data.Entity.Migrations;
using NetSatıs.Entities.Rapositories;
using NetSatıs.Entities.Validations;

namespace NetSatıs.Entities.Data_Access
{
    public class CARIDAL : EntitiyRapostoryBase<NetSatısContext, CARI, CARIVALİDATOR>
    {
        public object GetCarıler(NetSatısContext context)
        {
            var result = context.CARİLER.GroupJoin(context.FISLER, c => c.CARIKOD, c => c.CARIKOD, (cariler, fisler) => new
            {
                cariler.ID,
                cariler.DURUM,
                cariler.CARITUR,
                cariler.CARIKOD,
                cariler.CARIAD,
                cariler.YETKILIKISI,
                cariler.FATURAUNVAN,
                cariler.CEPTELEFON,
                cariler.TELEFON,
                cariler.FAX,
                cariler.EMAIL,
                cariler.WEB,
                cariler.IL,
                cariler.ILCE,
                cariler.SEMT,
                cariler.ADRES,
                cariler.CARIGRUP,
                cariler.CARIALTGRUBU,
                cariler.OZELKOD1,
                cariler.OZELKOD2,
                cariler.OZELKOD3,
                cariler.OZELKOD4,
                cariler.VERGINO,
                cariler.VERGIDAIRE,
                cariler.ISKONTOORAN,
                cariler.RISKLIMIT,
                cariler.ALISOZELFIYAT,
                cariler.SATISOZELFIYAT,
                cariler.ACIKLAMA,
                AlısToplam = (fisler.Where(c => c.FISTUR == "Alış Faturası").Sum(c => c.TOPLAMTUTAR) ?? 0),
                SatısToplam = (fisler.Where(c => c.FISTUR == "Perakende Satış Faturası").Sum(c => c.TOPLAMTUTAR) ?? 0)




            }).GroupJoin(context.KASAHAREKET, c => c.CARIKOD, c => c.CARIKOD, (cariler, KasaHareket) => new
            {
                cariler.ID,
                cariler.DURUM,
                cariler.CARITUR,
                cariler.CARIKOD,
                cariler.CARIAD,
                cariler.YETKILIKISI,
                cariler.FATURAUNVAN,
                cariler.CEPTELEFON,
                cariler.TELEFON,
                cariler.FAX,
                cariler.EMAIL,
                cariler.WEB,
                cariler.IL,
                cariler.ILCE,
                cariler.SEMT,
                cariler.ADRES,
                cariler.CARIGRUP,
                cariler.CARIALTGRUBU,
                cariler.OZELKOD1,
                cariler.OZELKOD2,
                cariler.OZELKOD3,
                cariler.OZELKOD4,
                cariler.VERGINO,
                cariler.VERGIDAIRE,
                cariler.ISKONTOORAN,
                cariler.RISKLIMIT,
                cariler.ALISOZELFIYAT,
                cariler.SATISOZELFIYAT,
                cariler.ACIKLAMA,
                ALACAK = (cariler.AlısToplam + KasaHareket.Where(c => c.HAREKET == "Kasa Giriş").Sum(c => c.TUTAR) ?? 0),
                BORC = (cariler.SatısToplam + KasaHareket.Where(c => c.HAREKET == "Kasa Çıkış").Sum(c => c.TUTAR) ?? 0),
                BAKIYE = ((cariler.AlısToplam + KasaHareket.Where(c => c.HAREKET == "Kasa Giriş").Sum(c => c.TUTAR) ?? 0)) - ((cariler.SatısToplam + KasaHareket.Where(c => c.HAREKET == "Kasa Çıkış").Sum(c => c.TUTAR) ?? 0))


            }).ToList();
            return result;
        }

        public object GetAllJoin(NetSatısContext context)
        {
            throw new NotImplementedException();
        }

        public object CariFisAyrıntı(NetSatısContext context, string CarıKod)
        {

            var result = context.FISLER.Where(c => c.CARIKOD == CarıKod).GroupJoin(
                context.KASAHAREKET.Where(c => c.CARIKOD == CarıKod), c => c.CARIKOD, c => c.CARIKOD,
                (fisler, kasahareket) => new
                {

                    fisler.ID,
                    fisler.FISKOD,
                    fisler.FISTUR,
                    fisler.PLASIYERAD,
                    fisler.PLASIYERKOD,
                    fisler.BELGENO,
                    fisler.TARIH,
                    fisler.ISKONTOORAN,
                    fisler.ISKONTUTAR,
                    fisler.ACIKLAMA,
                    fisler.TOPLAMTUTAR,
                    Odenen = context.KASAHAREKET.Where(c=>c.FISKOD==fisler.FISKOD).Sum(c => c.TUTAR) ?? 0,
                    KalanOdeme = fisler.TOPLAMTUTAR - context.KASAHAREKET.Where(c => c.FISKOD == fisler.FISKOD).Sum(c => c.TUTAR) ?? 0


                }).ToList();
            return result;
        }
        public object CariFisGenelToplam(NetSatısContext context, string CarıKod)
        {
            var result =( from c in context.FISLER.Where(c => c.CARIKOD == CarıKod)
                         group c by new { c.FISTUR}
            into grp select new
            {
                BILGI = grp.Key.FISTUR,
                KAYITSAYISI = grp.Count(),
                TUTAR = grp.Sum(c => c.TOPLAMTUTAR)

            }).ToList();
            return result;
        }
        public object CarıGenelToplam(NetSatısContext context , string CarıKodu)
        {
            decimal ALACAK = (context.FISLER.Where(c => c.CARIKOD == CarıKodu && c.FISTUR == "Alış Faturası").Sum(c => c.TOPLAMTUTAR) ?? 0) +
                 (context.KASAHAREKET.Where(c => c.CARIKOD == CarıKodu && c.HAREKET == "Kasa Giriş").Sum(c => c.TUTAR) ?? 0);

            decimal BORC = (context.FISLER.Where(c => c.CARIKOD == CarıKodu && c.FISTUR == "Perakende Satış Faturası").Sum(c => c.TOPLAMTUTAR) ?? 0) +
                (context.KASAHAREKET.Where(c => c.CARIKOD == CarıKodu && c.HAREKET == "Kasa Çıkış").Sum(c => c.TUTAR) ?? 0);

            List<GENELTOPLAM> GenelToplamlar = new List<GENELTOPLAM>()
            { 
             new GENELTOPLAM
             {
               
                BILGI="Alacak",
                TUTAR= ALACAK

            },
            
            new GENELTOPLAM
            {
                BILGI = "Borç",
                TUTAR = BORC
            },
             new GENELTOPLAM
            {
                BILGI = "Bakıye",
                TUTAR = ALACAK-BORC
            },
            };
            return GenelToplamlar;
        }
        public CARIBAKIYE CarıBakıyesı(NetSatısContext context,string CarıKodu)
        {
            decimal ALACAK = (context.FISLER.Where(c => c.CARIKOD == CarıKodu && c.FISTUR == "Alış Faturası").Sum(c => c.TOPLAMTUTAR) ?? 0) +
               (context.KASAHAREKET.Where(c => c.CARIKOD == CarıKodu && c.HAREKET == "Kasa Giriş").Sum(c => c.TUTAR) ?? 0);

            decimal BORC = (context.FISLER.Where(c => c.CARIKOD == CarıKodu && c.FISTUR == "Perakende Satış Faturası").Sum(c => c.TOPLAMTUTAR) ?? 0) +
                (context.KASAHAREKET.Where(c => c.CARIKOD == CarıKodu && c.HAREKET == "Kasa Çıkış").Sum(c => c.TUTAR) ?? 0);

            CARIBAKIYE entitiy = new CARIBAKIYE()
            {

                CARIKOD = CarıKodu,
                RISKLIMITI = Convert.ToDecimal(context.CARİLER.Where(c => c.CARIKOD == CarıKodu).SingleOrDefault().RISKLIMIT),
                ALACAK = ALACAK,
                BORC = BORC,
                BAKIYE = ALACAK - BORC
            };
            return entitiy;
        }
    }
}