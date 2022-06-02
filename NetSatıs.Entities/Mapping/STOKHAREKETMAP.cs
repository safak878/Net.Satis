using NetSatıs.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatıs.Entities.Mapping
{
    public class STOKHAREKETMAP : EntityTypeConfiguration<STOKHAREKET>
    {
        public STOKHAREKETMAP()
        {
            this.HasKey(p => p.ID);
            this.Property(p => p.ID).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            this.Property(p => p.FISKOD).HasMaxLength(12);
            this.Property(p => p.HAREKET).HasMaxLength(10);
            this.Property(p => p.STOKKODU).HasMaxLength(12);
            this.Property(p => p.STOKAD).HasMaxLength(50);
            this.Property(p => p.BARKODTUR).HasMaxLength(15);
            this.Property(p => p.BARKOD).HasMaxLength(20);
            this.Property(p => p.BIRIM).HasMaxLength(15);
            this.Property(p => p.MIKTAR).HasPrecision(12,3);
            this.Property(p => p.BIRIMFIYAT).HasPrecision(12,2);
            this.Property(p => p.INDIRIMORAN).HasPrecision(5,2);
            this.Property(p => p.TOPLAMTUTAR).HasPrecision(12, 2);
            this.Property(p => p.DEPOKOD).HasMaxLength(12);
            this.Property(p => p.DEPOAD).HasMaxLength(30);
            this.Property(p => p.SERINO).HasMaxLength(30);
            this.Property(p => p.ACIKLAMA).HasMaxLength(200);

            this.ToTable("STOKHAREKET");
            this.Property(p => p.ID).HasColumnName("ID");
            this.Property(p => p.FISKOD).HasColumnName("FISKOD"); 
            this.Property(p => p.HAREKET).HasColumnName("HAREKET");
            this.Property(p => p.STOKKODU).HasColumnName("STOKKODU");
            this.Property(p => p.STOKAD).HasColumnName("STOKAD");
            this.Property(p => p.BARKODTUR).HasColumnName("BARKODTUR");
            this.Property(p => p.BARKOD).HasColumnName("BARKOD");
            this.Property(p => p.BIRIM).HasColumnName("BIRIM");
            this.Property(p => p.MIKTAR).HasColumnName("MIKTAR");
            this.Property(p => p.KDV).HasColumnName("KDV");
            this.Property(p => p.BIRIMFIYAT).HasColumnName("BIRIMFIYAT");
            this.Property(p => p.INDIRIMORAN).HasColumnName("INDIRIMORAN");
            this.Property(p => p.TOPLAMTUTAR).HasColumnName("TOPLAMTUTAR");
            this.Property(p => p.DEPOKOD).HasColumnName("DEPOKOD");
            this.Property(p => p.DEPOAD).HasColumnName("DEPOAD");
            this.Property(p => p.SERINO).HasColumnName("SERINO");
            this.Property(p => p.TARIH).HasColumnName("TARIH");
            this.Property(p => p.ACIKLAMA).HasColumnName("ACIKLAMA");
        }
    }
}
