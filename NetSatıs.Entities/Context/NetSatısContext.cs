using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NetSatıs.Entities.Tables;
using System.Data.Entity;
using System.Threading.Tasks;
using NetSatıs.Entities.Mapping;

namespace NetSatıs.Entities.Context
{
  public  class NetSatısContext : DbContext
    {
        public DbSet<STOK> STOKLAR { get; set; }
        public DbSet<CARI> CARİLER { get; set; }
        public DbSet<FIS> FISLER { get; set; }
        public DbSet<STOKHAREKET> STOKHAREKET { get; set; }
        public DbSet<KASA_HAREKET> KASAHAREKET { get; set; }
        public DbSet<DEPO> DEPOLAR { get; set; }
        public DbSet<KASA> KASALAR { get; set; }
        public DbSet<ODEMETUR>ODEMETURLERI{ get; set; }
        public DbSet<TANIM> TANIMLAR { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new STOKMAP());
            modelBuilder.Configurations.Add(new CARIMAP());
            modelBuilder.Configurations.Add(new FISMAP());
            modelBuilder.Configurations.Add(new STOKHAREKETMAP());
            modelBuilder.Configurations.Add(new KASAHAREKETMAP());
            modelBuilder.Configurations.Add(new DEPOMAP());
            modelBuilder.Configurations.Add(new KASAMAP());
            modelBuilder.Configurations.Add(new ODEMETURMAP());
            modelBuilder.Configurations.Add(new TANIMMAP());

        }

    }
}
