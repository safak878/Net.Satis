using NetSatıs.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatıs.Entities.Mapping
{
    public class KASAHAREKETMAP : EntityTypeConfiguration<KASA_HAREKET>
    {

        public KASAHAREKETMAP()
        {
            this.HasKey(p => p.ID);
            this.Property(p => p.ID).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            this.Property(p => p.FISKOD).HasMaxLength(12);
            this.Property(p => p.HAREKET).HasMaxLength(10);
            this.Property(p => p.KASAKOD).HasMaxLength(12);
            this.Property(p => p.KASAAD).HasMaxLength(30);
            this.Property(p => p.ODEMETURKOD).HasMaxLength(12);
            this.Property(p => p.ODEMETURUAD).HasMaxLength(30);
            this.Property(p => p.CARIKOD).HasMaxLength(12);
            this.Property(p => p.CARIAD).HasMaxLength(50);
            this.Property(p => p.TUTAR).HasPrecision(12,2);
            this.Property(p => p.ACIKLAMA).HasMaxLength(200);

            this.ToTable("KASAHAREKET");

            this.Property(p => p.ID).HasColumnName("ID");
            this.Property(p => p.FISKOD).HasColumnName("FISKOD");
            this.Property(p => p.HAREKET).HasColumnName("HAREKET");
            this.Property(p => p.KASAKOD).HasColumnName("KASAKOD");
            this.Property(p => p.KASAAD).HasColumnName("KASAAD");
            this.Property(p => p.ODEMETURKOD).HasColumnName("ODEMETURKOD");
            this.Property(p => p.ODEMETURUAD).HasColumnName("ODEMETURUAD");
            this.Property(p => p.CARIKOD).HasColumnName("CARIKOD");
            this.Property(p => p.CARIAD).HasColumnName("CARIAD");
            this.Property(p => p.TARIH).HasColumnName("TARIH");
            this.Property(p => p.TUTAR).HasColumnName("TUTAR");
            this.Property(p => p.ACIKLAMA).HasColumnName("ACIKLAMA");

        }
    } }
