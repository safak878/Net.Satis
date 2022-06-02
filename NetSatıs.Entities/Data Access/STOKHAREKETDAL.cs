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
    public class STOKHAREKETDAL : EntitiyRapostoryBase<NetSatısContext, STOKHAREKET, STOKHAREKETVALİDATOR>
    {
        public object GetGenelStok(NetSatısContext context, string stokKodu)
        {

            var result = (from c in context.STOKHAREKET.Where(c => c.STOKKODU == stokKodu)
                          group c by new { c.HAREKET } into g
                          select new
                          {
                              BILGI = g.Key.HAREKET,
                              KAYITSAYISI = g.Count(),
                              TUTAR = g.Sum(c => c.MIKTAR)

                          }).ToList();
            return result;
        }

        public object GetDepoStok(NetSatısContext context, string stokKodu)
        {
            var result = context.DEPOLAR.GroupJoin(context.STOKHAREKET.Where(c => c.STOKKODU == stokKodu), c => c.DEPOKOD, c => c.DEPOKOD, (depolar, stokhareketleri) => new
            {

                depolar.DEPOKOD,
                depolar.DEPOAD,
                STOKGIRIS = stokhareketleri.Where(c => c.HAREKET == "Stok Giriş").Sum(c => c.MIKTAR) ?? 0,
                STOKCIKIS = stokhareketleri.Where(c => c.HAREKET == "Stok Çıkış").Sum(c => c.MIKTAR) ?? 0,
                MEVCUTSTOK = (stokhareketleri.Where(c => c.HAREKET == "Stok Giriş").Sum(c => c.MIKTAR) ?? 0) - (stokhareketleri.Where(c => c.HAREKET == "Stok Çıkış").Sum(c => c.MIKTAR) ?? 0)

            }).ToList();
            return result;

        }
        public object DepoStokLıstele(NetSatısContext context,string DepoKod)
        {

            var tablo = context.STOKLAR.GroupJoin(context.STOKHAREKET.Where(c=>c.DEPOKOD== DepoKod), c => c.STOKKODU, c => c.STOKKODU, (STOKLAR, STOKHAREKET) => new
            {
                STOKLAR.STOKAD,
                STOKLAR.BARKOD,
                STOKGIRIS = STOKHAREKET.Where(c => c.HAREKET == "Stok Giriş").Sum(c => c.TOPLAMTUTAR) ?? 0,
                STOKCIKIS = STOKHAREKET.Where(c => c.HAREKET == "Stok Çıkış").Sum(c => c.TOPLAMTUTAR) ?? 0,
                MEVCUTSTOK = STOKHAREKET.Where(c => c.HAREKET == "Stok Giriş").Sum(c => c.TOPLAMTUTAR) - STOKHAREKET.Where(c => c.HAREKET == "Stok Çıkış").Sum(c => c.TOPLAMTUTAR) ?? 0


            }).ToList();
            return tablo;
        }
        public object DepoIstatıskLıstele(NetSatısContext context, string DepoKodu)
        {
          
        List<GENELTOPLAM> GenelToplamlar = new List<GENELTOPLAM>()
            {
             new GENELTOPLAM
             {

                BILGI="Stok Giriş",
                KAYITSAYISI=context.STOKHAREKET.Where(c=>c.DEPOKOD==DepoKodu && c.HAREKET=="Stok Giriş").Count(),
                TUTAR= context.STOKHAREKET.Where(c=>c.DEPOKOD==DepoKodu && c.HAREKET=="Stok Giriş").Sum(c=>c.MIKTAR) ?? 0

            },

            new GENELTOPLAM
            {

                BILGI="Stok Çıkış",
                KAYITSAYISI=context.STOKHAREKET.Where(c=>c.DEPOKOD==DepoKodu && c.HAREKET=="Stok Çıkış").Count(),
                TUTAR= context.STOKHAREKET.Where(c=>c.DEPOKOD==DepoKodu && c.HAREKET=="Stok Çıkış").Sum(c=>c.MIKTAR) ?? 0
            },
       
            };
            return GenelToplamlar;
        }
}
}