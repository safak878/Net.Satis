using NetSatıs.Entities.Interfacess;
using System;

namespace NetSatıs.Entities.Tables
{
    public class STOK : IEntitiy
    {
        public int ID { get; set; }
        public bool DURUM { get; set; }
        public string STOKKODU { get; set; }
        public string STOKAD { get; set; }
        public string BARKOD { get; set; }
        public string BARKODTUR { get; set; }
        public string BIRIM { get; set; }
        public string STOKGRUP { get; set; }
        public string STOKALTGRUP { get; set; }
        public string MARKA { get; set; }
        public string MODEL { get; set; }
        public string OZELKOD1 { get; set; }
        public string OZELKOD2 { get; set; }
        public string OZELKOD3 { get; set; }
        public string OZELKOD4 { get; set; }
        public string GARANTISURE { get; set; }
        public string URETICIKOD { get; set; }
        public int ALISKDV { get; set; }
        public int SATISKDV { get; set; }
        public Nullable<decimal> ALISFIYAT1 { get; set; }
        public Nullable<decimal> ALISFIYAT2 { get; set; }
        public Nullable<decimal> ALISFIYAT3 { get; set; }
        public Nullable<decimal> SATISFIYAT1 { get; set; }
        public Nullable<decimal> SATISFIYAT2 { get; set; }
        public Nullable<decimal> SATISFIYAT3 { get; set; }
        public Nullable<decimal> MINSTOKMIKTAR { get; set; }
        public Nullable<decimal> MAXSTOKMIKTAR { get; set; }
        public string ACIKLAMA { get; set; }
    }
}
