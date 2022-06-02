using NetSatıs.Entities.Context;
using NetSatıs.Entities.Rapositories;
using NetSatıs.Entities.Tables;
using NetSatıs.Entities.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatıs.Entities.Data_Access
{
    public class KASADAL : EntitiyRapostoryBase<NetSatısContext, KASA, KASAVALİDATOR>
    {
        public object KasaListe(NetSatısContext context)
        {
            var result = context.KASALAR.GroupJoin(context.KASAHAREKET, c => c.KASAKOD, c => c.KASAKOD, (kasa, KASAHAREKET) => new
            {

                kasa.ID,
                kasa.KASAKOD,
                kasa.KASAAD,
                kasa.YETKILIKOD,
                kasa.YETKILIAD,
                kasa.ACIKLAMA,
                KASAGIRIS = (KASAHAREKET.Where(c => c.KASAKOD == kasa.KASAKOD && c.HAREKET == "Kasa Giriş").Sum(c => c.TUTAR) ?? 0),
                KASACIKIS = (KASAHAREKET.Where(c => c.KASAKOD == kasa.KASAKOD && c.HAREKET == "Kasa Çıkış").Sum(c => c.TUTAR) ?? 0),
                BAKIYE = (KASAHAREKET.Where(c => c.KASAKOD == kasa.KASAKOD && c.HAREKET == "Kasa Giriş").Sum(c => c.TUTAR) ?? 0) - (KASAHAREKET.Where(c => c.KASAKOD == kasa.KASAKOD && c.HAREKET == "Kasa Çıkış").Sum(c => c.TUTAR) ?? 0)



            }).ToList();

            return result;
        }

        public object OdemeTuruToplamLıstele(NetSatısContext context, string KasaKod)
        {
            var result = (from c in context.KASAHAREKET.Where(c => c.KASAKOD == KasaKod)
                          group c by new { c.ODEMETURUAD } into grp
                          select new
                          {
                              grp.Key.ODEMETURUAD,
                              KASAGIRIS = (grp.Where(c => c.ODEMETURUAD == grp.Key.ODEMETURUAD && c.HAREKET == "Kasa Giriş").Sum(c => c.TUTAR) ?? 0),
                              KASACIKIS = (grp.Where(c => c.ODEMETURUAD == grp.Key.ODEMETURUAD && c.HAREKET == "Kasa Çıkış").Sum(c => c.TUTAR) ?? 0),
                              BAKIYE = (grp.Where(c => c.ODEMETURUAD == grp.Key.ODEMETURUAD && c.HAREKET == "Kasa Giriş").Sum(c => c.TUTAR) ?? 0) - (grp.Where(c => c.ODEMETURUAD == grp.Key.ODEMETURUAD && c.HAREKET == "Kasa Çıkış").Sum(c => c.TUTAR) ?? 0)

                          }).ToList();
            return result;
        }
        public object GenelToplamLıstele(NetSatısContext context, string KasaKod)
        {
            decimal KASAGIRIS = context.KASAHAREKET.Where(c => c.KASAKOD == KasaKod && c.HAREKET == "Kasa Giriş").Sum(c => c.TUTAR) ?? 0;
            int KASAGIRISKAYITSAYISI = context.KASAHAREKET.Where(c => c.KASAKOD == KasaKod && c.HAREKET == "Kasa Giriş").Count();

            decimal KASACIKIS = context.KASAHAREKET.Where(c => c.KASAKOD == KasaKod && c.HAREKET == "Kasa Çıkış").Sum(c => c.TUTAR) ?? 0;
            int KASACIKISKAYITSAYISI = context.KASAHAREKET.Where(c => c.KASAKOD == KasaKod && c.HAREKET == "Kasa Çıkış").Count();

            List<GENELTOPLAM> GenelToplamlar = new List<GENELTOPLAM>()
            {
             new GENELTOPLAM
             {

                BILGI="Kasa Giriş",
                KAYITSAYISI= KASAGIRISKAYITSAYISI,
                TUTAR= KASAGIRIS

            },

            new GENELTOPLAM
            {
                BILGI = "Kasa Çıkış",
                KAYITSAYISI= KASACIKISKAYITSAYISI,
                TUTAR = KASACIKIS
            },
             new GENELTOPLAM
            {
                BILGI = "Bakıye",
                KAYITSAYISI= KASAGIRISKAYITSAYISI+KASACIKISKAYITSAYISI,
                TUTAR = KASAGIRIS-KASACIKIS
            },
            };
            return GenelToplamlar;
        }

    }
    }
