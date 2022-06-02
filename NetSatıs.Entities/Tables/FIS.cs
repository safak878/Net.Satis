using NetSatıs.Entities.Interfacess;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatıs.Entities.Tables
{
    public class FIS : IEntitiy
    {
        public int ID { get; set; }
        public string FISKOD { get; set; }
        public string FISTUR { get; set; }
        public string CARIKOD { get; set; }
        public string CARIAD { get; set; }
        public string FATURAUNVANI { get; set; }
        public string CEPTELEFONU { get; set; }
        public string IL { get; set; }
        public string ILCE { get; set; }
        public string SEMT { get; set; }
        public string ADRES { get; set; }
        public string VERGIDAIRESI { get; set; }
        public string VERGINO { get; set; }
        public string BELGENO { get; set; }
        public DateTime TARIH { get; set; }
        public string PLASIYERKOD { get; set; }
        public string PLASIYERAD { get; set; }
        public Nullable<decimal> ISKONTOORAN { get; set; }
        public Nullable<decimal> ISKONTUTAR { get; set; }
        public Nullable<decimal> TOPLAMTUTAR { get; set; }
        public string ACIKLAMA { get; set; }
    }
}
