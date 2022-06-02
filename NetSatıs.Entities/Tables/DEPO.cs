using NetSatıs.Entities.Interfacess;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatıs.Entities.Tables
{
  public  class DEPO : IEntitiy
    {
        public int ID { get; set; }
        public string DEPOKOD { get; set; }
        public string DEPOAD { get; set; }
        public string YETKILIKOD { get; set; }
        public string YETKILIAD { get; set; }
        public string IL { get; set; }
        public string ILCE { get; set; }
        public string SEMT { get; set; }
        public string ADRES { get; set; }
        public string TELEFON { get; set; }
        public string ACIKLAMA { get; set; }
    }
}
