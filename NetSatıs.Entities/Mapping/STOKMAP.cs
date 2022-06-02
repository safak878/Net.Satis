using NetSatıs.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatıs.Entities.Mapping
{
   public class STOKMAP:EntityTypeConfiguration<STOK>
    {
        public STOKMAP()
        {
            this.HasKey(p => p.ID);
            this.Property(p => p.ID).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            this.Property(p => p.STOKKODU).HasMaxLength(12);
            this.Property(p => p.STOKAD).HasMaxLength(50);
            this.Property(p => p.BARKOD).HasMaxLength(20);
            this.Property(p => p.BARKODTUR).HasMaxLength(15);
            this.Property(p => p.BIRIM).HasMaxLength(15);
            this.Property(p => p.STOKGRUP).HasMaxLength(30);
            this.Property(p => p.STOKALTGRUP).HasMaxLength(30);
            this.Property(p => p.MARKA).HasMaxLength(30);
            this.Property(p => p.OZELKOD1).HasMaxLength(30);
            this.Property(p => p.OZELKOD2).HasMaxLength(30);
            this.Property(p => p.OZELKOD3).HasMaxLength(30);
            this.Property(p => p.OZELKOD4).HasMaxLength(30);
            this.Property(p => p.GARANTISURE).HasMaxLength(15);
            this.Property(p => p.URETICIKOD).HasMaxLength(20);
            this.Property(p => p.ALISFIYAT1).HasPrecision(12,2);
            this.Property(p => p.ALISFIYAT2).HasPrecision(12, 2);
            this.Property(p => p.ALISFIYAT3).HasPrecision(12, 2);
            this.Property(p => p.SATISFIYAT1).HasPrecision(12, 2);
            this.Property(p => p.SATISFIYAT2).HasPrecision(12, 2);
            this.Property(p => p.SATISFIYAT3).HasPrecision(12, 2);
            this.Property(p => p.MINSTOKMIKTAR).HasPrecision(12, 3);
            this.Property(p => p.MAXSTOKMIKTAR).HasPrecision(12, 3);
            this.Property(p => p.ACIKLAMA).HasMaxLength(200);

            this.ToTable("STOKLAR");
            this.Property(p => p.ID).HasColumnName("ID");
            this.Property(p => p.DURUM).HasColumnName("DURUM");
            this.Property(p => p.STOKKODU).HasColumnName("STOKKODU");
            this.Property(p => p.STOKAD).HasColumnName("STOKAD");
            this.Property(p => p.BARKOD).HasColumnName("BARKOD");
            this.Property(p => p.BARKODTUR).HasColumnName("BARKODTUR");
            this.Property(p => p.BIRIM).HasColumnName("BIRIM");
            this.Property(p => p.STOKGRUP).HasColumnName("STOKGRUP");
            this.Property(p => p.STOKALTGRUP).HasColumnName("STOKALTGRUP");
            this.Property(p => p.MARKA).HasColumnName("MARKA");
            this.Property(p => p.MODEL).HasColumnName("MODEL");
            this.Property(p => p.OZELKOD1).HasColumnName("OZELKOD1");
            this.Property(p => p.OZELKOD2).HasColumnName("OZELKOD2");
            this.Property(p => p.OZELKOD3).HasColumnName("OZELKOD3");
            this.Property(p => p.OZELKOD4).HasColumnName("OZELKOD4");
            this.Property(p => p.GARANTISURE).HasColumnName("GARANTISURE");
            this.Property(p => p.URETICIKOD).HasColumnName("URETICIKOD");
            this.Property(p => p.ALISKDV).HasColumnName("ALISKDV");
            this.Property(p => p.SATISKDV).HasColumnName("SATISKDV");
            this.Property(p => p.ALISFIYAT1).HasColumnName("ALISFIYAT1");
            this.Property(p => p.ALISFIYAT2).HasColumnName("ALISFIYAT2");
            this.Property(p => p.ALISFIYAT3).HasColumnName("ALISFIYAT3");
            this.Property(p => p.SATISFIYAT1).HasColumnName("SATISFIYAT1");
            this.Property(p => p.SATISFIYAT2).HasColumnName("SATISFIYAT2");
            this.Property(p => p.SATISFIYAT3).HasColumnName("SATISFIYAT3");
            this.Property(p => p.MINSTOKMIKTAR).HasColumnName("MINSTOKMIKTAR");
            this.Property(p => p.MAXSTOKMIKTAR).HasColumnName("MAXSTORMIKTAR");
            this.Property(p => p.ACIKLAMA).HasColumnName("ACIKLAMA");



        }
    }
}
