using NetSatıs.Entities.Interfacess;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatıs.Entities.Tables
{
    public class TANIM : IEntitiy
    {

        public int ID { get; set; }
        public string TUR { get; set; }
        public string TANIMI { get; set; }
        public string ACIKLAMA { get; set; }
    }
}
