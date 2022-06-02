using NetSatıs.Entities.Interfacess;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatıs.Entities.Tables
{
    public class KASA_HAREKET : IEntitiy
    {
        public int ID { get; set; }
        public string FISKOD { get; set; }
        public string HAREKET { get; set; }
        public string KASAKOD { get; set; }
        public string KASAAD { get; set; }
        public string ODEMETURKOD { get; set; }
        public string ODEMETURUAD { get; set; }
        public string CARIKOD { get; set; }
        public string CARIAD { get; set; }
        public Nullable<DateTime> TARIH { get; set; }
        public Nullable<decimal> TUTAR { get; set; }
        public string ACIKLAMA { get; set; }
    }
}
