using NetSatıs.Entities.Interfacess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatıs.Entities.Tables
{
    public class CARI:IEntitiy
    {
        public int ID { get; set; }
        public bool DURUM { get; set; }
        public string CARITUR { get; set; }
        public string CARIKOD { get; set; }
        public string CARIAD { get; set; }
        public string YETKILIKISI { get; set; }
        public string FATURAUNVAN { get; set; }
        public string CEPTELEFON { get; set; }
        public string TELEFON { get; set; }
        public string FAX { get; set; }
        public string EMAIL { get; set; }
        public string WEB { get; set; }
        public string IL { get; set; }
        public string ILCE { get; set; }
        public string SEMT { get; set; }
        public string ADRES { get; set; }
        public string CARIGRUP { get; set; }
        public string CARIALTGRUBU { get; set; }
        public string OZELKOD1 { get; set; }
        public string OZELKOD2 { get; set; }
        public string OZELKOD3 { get; set; }
        public string OZELKOD4 { get; set; }
        public string VERGIDAIRE { get; set; }
        public string VERGINO { get; set; }
        public Nullable<decimal> ISKONTOORAN { get; set; }
        public Nullable<decimal> RISKLIMIT { get; set; }
        public string ALISOZELFIYAT { get; set; }
        public string SATISOZELFIYAT { get; set; }
        public string ACIKLAMA { get; set; }
    }
}
