using NetSatıs.Entities.Interfacess;
using NetSatıs.Entities.Rapositories;

namespace NetSatıs.Entities.Tables
{
    public class ODEMETUR : IEntitiy
    {
        public int ID { get; set; }
        public string ODEMETURKOD { get; set; }
        public string ODEMETURAD { get; set; }
        public string ACIKLAMA { get; set; }
    }
}
