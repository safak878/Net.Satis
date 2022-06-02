using NetSatıs.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatıs.Entities.Mapping
{
    class TANIMMAP : EntityTypeConfiguration<TANIM>
    {

        public TANIMMAP()
        {
            this.HasKey(p => p.ID);
            this.Property(p => p.ID).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            this.Property(p => p.TUR).HasMaxLength(15);
            this.Property(p => p.TANIMI).HasMaxLength(30);
            this.Property(p => p.ACIKLAMA).HasMaxLength(200);

            this.ToTable("TANIM");

            this.Property(p => p.ID).HasColumnName("ID");
            this.Property(p => p.TUR).HasColumnName("TUR");
            this.Property(p => p.TANIMI).HasColumnName("TANIMI");
            this.Property(p => p.ACIKLAMA).HasColumnName("ACIKLAMA");

        }
    }
}