using NetSatıs.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatıs.Entities.Mapping
{
    public class FISMAP : EntityTypeConfiguration<FIS>
    {
        public FISMAP()
        {
            this.HasKey(p => p.ID);
            this.Property(p => p.ID).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            this.Property(p => p.FISKOD).HasMaxLength(12);
            this.Property(p => p.FISTUR).HasMaxLength(30);
            this.Property(p => p.CARIKOD).HasMaxLength(12);
            this.Property(p => p.CARIAD).HasMaxLength(50);
            this.Property(p => p.FATURAUNVANI).HasMaxLength(50);
            this.Property(p => p.CEPTELEFONU).HasMaxLength(20);
            this.Property(p => p.IL).HasMaxLength(20);
            this.Property(p => p.ILCE).HasMaxLength(20);
            this.Property(p => p.SEMT).HasMaxLength(20);
            this.Property(p => p.VERGIDAIRESI).HasMaxLength(30);
            this.Property(p => p.VERGINO).HasMaxLength(15);
            this.Property(p => p.BELGENO).HasMaxLength(20);
            this.Property(p => p.PLASIYERKOD).HasMaxLength(12);
            this.Property(p => p.PLASIYERAD).HasMaxLength(50);
            this.Property(p => p.ISKONTOORAN).HasPrecision(5,2);
            this.Property(p => p.ISKONTUTAR).HasPrecision(12,2);
            this.Property(p => p.TOPLAMTUTAR).HasPrecision(12,2);
            this.Property(p => p.ACIKLAMA).HasMaxLength(200);


            this.ToTable("FIS");
            this.Property(p => p.ID).HasColumnName("ID");
            this.Property(p => p.FISKOD).HasColumnName("FISKOD");
            this.Property(p => p.FISTUR).HasColumnName("FISTUR");
            this.Property(p => p.CARIKOD).HasColumnName("CARIKOD");
            this.Property(p => p.CARIAD).HasColumnName("CARIAD");
            this.Property(p => p.FATURAUNVANI).HasColumnName("FATURAUNVANI");
            this.Property(p => p.CEPTELEFONU).HasColumnName("CEPTELEFONU");
            this.Property(p => p.IL).HasColumnName("IL");
            this.Property(p => p.ILCE).HasColumnName("ILCE");
            this.Property(p => p.SEMT).HasColumnName("SEMT");
            this.Property(p => p.VERGIDAIRESI).HasColumnName("VERGIDAIRESI");
            this.Property(p => p.VERGINO).HasColumnName("VERGINO");
            this.Property(p => p.BELGENO).HasColumnName("BELGENO");
            this.Property(p => p.TARIH).HasColumnName("TARIH");
            this.Property(p => p.PLASIYERKOD).HasColumnName("PLASIYERKOD");
            this.Property(p => p.PLASIYERAD).HasColumnName("PLASIYERAD");
            this.Property(p => p.ISKONTOORAN).HasColumnName("ISKONTOORAN");
            this.Property(p => p.ISKONTUTAR).HasColumnName("ISKONTUTAR");
            this.Property(p => p.TOPLAMTUTAR).HasColumnName("TOPLAMTUTAR");
            this.Property(p => p.ACIKLAMA).HasColumnName("ACIKLAMA");

        }
    }
}
