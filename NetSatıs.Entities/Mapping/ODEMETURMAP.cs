using NetSatıs.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatıs.Entities.Mapping
{
    class ODEMETURMAP : EntityTypeConfiguration<ODEMETUR>
    {

        public ODEMETURMAP()
        {
            this.HasKey(p => p.ID);
            this.Property(p => p.ID).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            this.Property(p => p.ODEMETURKOD).HasMaxLength(12);
            this.Property(p => p.ODEMETURAD).HasMaxLength(30);
            this.Property(p => p.ACIKLAMA).HasMaxLength(200);

            this.ToTable("ODEMETUR");

            this.Property(p => p.ID).HasColumnName("ID");
            this.Property(p => p.ODEMETURKOD).HasColumnName("ODEMETURKOD");
            this.Property(p => p.ODEMETURAD).HasColumnName("ODEMETURAD");
            this.Property(p => p.ACIKLAMA).HasColumnName("ACIKLAMA");


        }
    }
}
