using NetSatıs.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatıs.Entities.Mapping
{
    public class KASAMAP : EntityTypeConfiguration<KASA>
    {

        public KASAMAP()
        {
            this.HasKey(p => p.ID);
            this.Property(p => p.ID).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            this.Property(p => p.KASAKOD).HasMaxLength(12);
            this.Property(p => p.KASAAD).HasMaxLength(30);
            this.Property(p => p.YETKILIKOD).HasMaxLength(12);
            this.Property(p => p.YETKILIAD).HasMaxLength(50);
            this.Property(p => p.ACIKLAMA).HasMaxLength(200);

            this.ToTable("KASA");
            this.Property(p => p.ID).HasColumnName("ID");
            this.Property(p => p.KASAKOD).HasColumnName("KASAKOD");
            this.Property(p => p.KASAAD).HasColumnName("KASAAD");
            this.Property(p => p.YETKILIKOD).HasColumnName("YETKILIKOD");
            this.Property(p => p.YETKILIAD).HasColumnName("YETKILIAD");
            this.Property(p => p.ACIKLAMA).HasColumnName("ACIKLAMA");

        }
    }
}
