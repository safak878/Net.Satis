using NetSatıs.Entities.Context;
using NetSatıs.Entities.Tables;
using System.Linq;
using NetSatıs.Entities.Rapositories;
using NetSatıs.Entities.Validations;
using System;

namespace NetSatıs.Entities.Data_Access
{
    public class STOKDAL: EntitiyRapostoryBase<NetSatısContext,STOK,STOKVALİDATOR>
    {
       public object GetAllJoin(NetSatısContext context)
        {

            var tablo = context.STOKLAR.GroupJoin(context.STOKHAREKET, c => c.STOKKODU, c => c.STOKKODU, (STOKLAR, STOKHAREKET) => new
            {
                STOKLAR.ID,
                STOKLAR.STOKKODU,
                STOKLAR.STOKAD,
                STOKLAR.DURUM,
                STOKLAR.BARKOD,
                STOKLAR.BARKODTUR,
                STOKLAR.BIRIM,
                STOKLAR.STOKGRUP,
                STOKLAR.STOKALTGRUP,
                STOKLAR.MARKA,
                STOKLAR.MODEL,
                STOKLAR.OZELKOD1,
                STOKLAR.OZELKOD2,
                STOKLAR.OZELKOD3,
                STOKLAR.OZELKOD4,
                STOKLAR.GARANTISURE,
                STOKLAR.URETICIKOD,
                STOKLAR.ALISKDV,
                STOKLAR.SATISKDV,
                STOKLAR.ALISFIYAT1,
                STOKLAR.ALISFIYAT2,
                STOKLAR.ALISFIYAT3,
                STOKLAR.SATISFIYAT1,
                STOKLAR.SATISFIYAT2,
                STOKLAR.SATISFIYAT3,
                STOKLAR.MINSTOKMIKTAR,
                STOKLAR.MAXSTOKMIKTAR,
                STOKLAR.ACIKLAMA,
                STOKGIRIS = STOKHAREKET.Where(c => c.HAREKET == "Stok Giriş").Sum(c => c.TOPLAMTUTAR) ?? 0,
                STOKCIKIS = STOKHAREKET.Where(c => c.HAREKET == "Stok Çıkış").Sum(c => c.TOPLAMTUTAR) ?? 0,
                MEVCUTSTOK = STOKHAREKET.Where(c => c.HAREKET == "Stok Giriş").Sum(c => c.TOPLAMTUTAR) - STOKHAREKET.Where(c => c.HAREKET == "Stok Çıkış").Sum(c => c.TOPLAMTUTAR) ?? 0


            }).ToList();
            return tablo;

        }

    }
}
