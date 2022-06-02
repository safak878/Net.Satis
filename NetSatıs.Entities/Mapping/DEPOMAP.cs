using NetSatıs.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatıs.Entities.Mapping
{
    public class DEPOMAP : EntityTypeConfiguration<DEPO>
    {
        public DEPOMAP()
        {
            this.HasKey(p => p.ID);
            this.Property(p => p.ID).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            this.Property(p => p.DEPOKOD).HasMaxLength(12);
            this.Property(p => p.DEPOAD).HasMaxLength(30);
            this.Property(p => p.YETKILIKOD).HasMaxLength(12);
            this.Property(p => p.YETKILIAD).HasMaxLength(50);
            this.Property(p => p.IL).HasMaxLength(12);
            this.Property(p => p.ILCE).HasMaxLength(20);
            this.Property(p => p.SEMT).HasMaxLength(20);
            this.Property(p => p.ADRES).HasMaxLength(100);
            this.Property(p => p.TELEFON).HasMaxLength(20);
            this.Property(p => p.ACIKLAMA).HasMaxLength(200);

            this.ToTable("DEPO");

            this.Property(p => p.ID).HasColumnName("ID");
            this.Property(p => p.DEPOKOD).HasColumnName("DEPOKOD");
            this.Property(p => p.DEPOAD).HasColumnName("DEPOAD");
            this.Property(p => p.YETKILIKOD).HasColumnName("YETKILIKOD");
            this.Property(p => p.YETKILIAD).HasColumnName("YETKILIAD");
            this.Property(p => p.IL).HasColumnName("IL");
            this.Property(p => p.ILCE).HasColumnName("ILCE");
            this.Property(p => p.SEMT).HasColumnName("SEMT");
            this.Property(p => p.ADRES).HasColumnName("ADRES");
            this.Property(p => p.TELEFON).HasColumnName("TELEFON");
            this.Property(p => p.ACIKLAMA).HasColumnName("ACIKLAMA");

        }
    }
}
