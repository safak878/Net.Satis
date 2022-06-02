using NetSatıs.Entities.Interfacess;

using System;

namespace NetSatıs.Entities.Tables
{
    public class STOKHAREKET : IEntitiy
    {
        public int ID { get; set; }
        public string FISKOD { get; set; }
        public string HAREKET { get; set; }
        public string STOKKODU { get; set; }
        public string STOKAD { get; set; }
        public string BARKODTUR { get; set; }
        public string BARKOD { get; set; }
        public string BIRIM { get; set; }
        public Nullable<decimal> MIKTAR { get; set; }
        public int KDV { get; set; }
        public Nullable<decimal> BIRIMFIYAT { get; set; }
        public Nullable<decimal> INDIRIMORAN { get; set; }
        public Nullable<decimal> TOPLAMTUTAR { get; set; }
        public string DEPOKOD { get; set; }
        public string DEPOAD { get; set; }
        public string SERINO { get; set; }
        public Nullable<DateTime> TARIH { get; set; }
        public string ACIKLAMA { get; set; }
     
    }
}
