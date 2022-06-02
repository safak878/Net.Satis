using NetSatıs.Entities.Context;
using NetSatıs.Entities.Rapositories;
using NetSatıs.Entities.Tables;
using NetSatıs.Entities.Validations;
using System.Collections.Generic;
using System.Linq;

namespace NetSatıs.Entities.Data_Access
{
    public class ODEMETURUDAL : EntitiyRapostoryBase<NetSatısContext, ODEMETUR, ODEMETURVALİDATOR>
    {
        public object OdemeTuruLıste(NetSatısContext context)
        {
            var result = context.ODEMETURLERI.GroupJoin(context.KASAHAREKET, c => c.ODEMETURKOD, c => c.ODEMETURKOD,
                (OdemeTuru, KASAHAREKET) => new
                {


                    OdemeTuru.ID,
                    OdemeTuru.ODEMETURKOD,
                    OdemeTuru.ODEMETURAD,
                    OdemeTuru.ACIKLAMA,
                    KASAGIRIS = (KASAHAREKET.Where(c => c.ODEMETURKOD == OdemeTuru.ODEMETURKOD && c.HAREKET == "Kasa Giriş").Sum(c => c.TUTAR) ?? 0),
                    KASACIKIS = (KASAHAREKET.Where(c => c.ODEMETURKOD == OdemeTuru.ODEMETURKOD && c.HAREKET == "Kasa Çıkış").Sum(c => c.TUTAR) ?? 0),
                    BAKIYE = (KASAHAREKET.Where(c => c.ODEMETURKOD == OdemeTuru.ODEMETURKOD && c.HAREKET == "Kasa Giriş").Sum(c => c.TUTAR) ?? 0) - (KASAHAREKET.Where(c => c.ODEMETURKOD == OdemeTuru.ODEMETURKOD && c.HAREKET == "Kasa Çıkış").Sum(c => c.TUTAR) ?? 0)
                }).ToList();

            return result;
        }
        public object OdemeTuruToplamLıstele(NetSatısContext context, string OdemeTuruKod)
        {
            var result = (from c in context.KASAHAREKET.Where(c => c.ODEMETURKOD == OdemeTuruKod)
                          group c by new { c.KASAKOD,c.KASAAD } into grp
                          select new
                          {
                              grp.Key.KASAKOD,
                              grp.Key.KASAAD,
                              KASAGIRIS = (grp.Where(c => c.KASAKOD == grp.Key.KASAKOD && c.HAREKET == "Kasa Giriş").Sum(c => c.TUTAR) ?? 0),
                              KASACIKIS = (grp.Where(c => c.KASAKOD == grp.Key.KASAKOD && c.HAREKET == "Kasa Çıkış").Sum(c => c.TUTAR) ?? 0),
                              BAKIYE = (grp.Where(c => c.KASAKOD == grp.Key.KASAKOD && c.HAREKET == "Kasa Giriş").Sum(c => c.TUTAR) ?? 0) - (grp.Where(c => c.KASAKOD == grp.Key.KASAKOD && c.HAREKET == "Kasa Çıkış").Sum(c => c.TUTAR) ?? 0)

                          }).ToList();
            return result;
        }
        public object GenelToplamLıstele(NetSatısContext context, string OdemeTuruKod)
        {
            decimal KASAGIRIS = context.KASAHAREKET.Where(c => c.ODEMETURKOD == OdemeTuruKod && c.HAREKET == "Kasa Giriş").Sum(c => c.TUTAR) ?? 0;
            int KASAGIRISKAYITSAYISI = context.KASAHAREKET.Where(c => c.ODEMETURKOD == OdemeTuruKod && c.HAREKET == "Kasa Giriş").Count();

            decimal KASACIKIS = context.KASAHAREKET.Where(c => c.ODEMETURKOD == OdemeTuruKod && c.HAREKET == "Kasa Çıkış").Sum(c => c.TUTAR) ?? 0;
            int KASACIKISKAYITSAYISI = context.KASAHAREKET.Where(c => c.ODEMETURKOD == OdemeTuruKod && c.HAREKET == "Kasa Çıkış").Count();

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