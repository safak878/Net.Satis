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
   public class DEPODAL: EntitiyRapostoryBase<NetSatısContext, DEPO,DEPOVALİDATOR>
    {
        public object DepoBazındaStokLıstele(NetSatısContext context,string stokKodu)
        {

            var result = context.DEPOLAR.GroupJoin(context.STOKHAREKET.Where(c => c.STOKKODU == stokKodu), c => c.DEPOKOD, c => c.DEPOKOD, (depolar, stokhareketleri) => new
            {
                depolar.ID,
                depolar.DEPOKOD,
                depolar.DEPOAD,
                depolar.YETKILIKOD,
                depolar.YETKILIAD,
                depolar.TELEFON,
                depolar.IL,
                depolar.ILCE,
                depolar.SEMT,
                depolar.ADRES,
                STOKGIRIS = stokhareketleri.Where(c => c.HAREKET == "Stok Gİriş").Sum(c => c.MIKTAR) ?? 0,
                STOKCIKIS = stokhareketleri.Where(c => c.HAREKET == "Stok Çıkış").Sum(c => c.MIKTAR) ?? 0,
                MEVCUTSTOK = (stokhareketleri.Where(c => c.HAREKET == "Stok Gİriş").Sum(c => c.MIKTAR) ?? 0) - (stokhareketleri.Where(c => c.HAREKET == "Stok çıkış").Sum(c => c.MIKTAR) ?? 0)

            }).ToList();
            return result;
        }


    }
}
