using NetSatıs.Entities.Interfacess;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatıs.Entities.Tables
{
    public class KASA : IEntitiy
    {
        public int ID { get; set; }
        public string KASAKOD { get; set; }
        public string KASAAD { get; set; }
        public string YETKILIKOD { get; set; }
        public string YETKILIAD { get; set; }
        public string ACIKLAMA { get; set; }
    }
}
