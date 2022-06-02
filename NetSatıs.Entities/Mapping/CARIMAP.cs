using NetSatıs.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatıs.Entities.Mapping
{
    public class CARIMAP : EntityTypeConfiguration<CARI>
    {
        public CARIMAP()
        {
            this.HasKey(p => p.ID);
            this.Property(p => p.ID).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            this.Property(p => p.CARITUR).HasMaxLength(15);
            this.Property(p => p.CARIKOD).HasMaxLength(12);
            this.Property(p => p.CARIAD).HasMaxLength(50);
            this.Property(p => p.YETKILIKISI).HasMaxLength(50);
            this.Property(p => p.FATURAUNVAN).HasMaxLength(50);
            this.Property(p => p.CEPTELEFON).HasMaxLength(20);
            this.Property(p => p.TELEFON).HasMaxLength(20);
            this.Property(p => p.FAX).HasMaxLength(20);
            this.Property(p => p.EMAIL).HasMaxLength(50);
            this.Property(p => p.WEB).HasMaxLength(50);
            this.Property(p => p.IL).HasMaxLength(20);
            this.Property(p => p.ILCE).HasMaxLength(20);
            this.Property(p => p.SEMT).HasMaxLength(20);
            this.Property(p => p.ADRES).HasMaxLength(100);
            this.Property(p => p.CARIGRUP).HasMaxLength(30);
            this.Property(p => p.CARIALTGRUBU).HasMaxLength(30);
            this.Property(p => p.OZELKOD1).HasMaxLength(30);
            this.Property(p => p.OZELKOD2).HasMaxLength(30);
            this.Property(p => p.OZELKOD3).HasMaxLength(30);
            this.Property(p => p.OZELKOD4).HasMaxLength(30);
            this.Property(p => p.VERGIDAIRE).HasMaxLength(30);
            this.Property(p => p.VERGINO).HasMaxLength(15);
            this.Property(p => p.ISKONTOORAN).HasPrecision(5, 2);
            this.Property(p => p.RISKLIMIT).HasPrecision(12, 2);
            this.Property(p => p.ALISOZELFIYAT).HasMaxLength(15);
            this.Property(p => p.SATISOZELFIYAT).HasMaxLength(15);
            this.Property(p => p.ACIKLAMA).HasMaxLength(200);



            this.ToTable("CARI");
            this.Property(p => p.ID).HasColumnName("ID");
            this.Property(p => p.DURUM).HasColumnName("DURUM");
            this.Property(p => p.CARITUR).HasColumnName("CARITUR");
            this.Property(p => p.CARIKOD).HasColumnName("CARIKOD");
            this.Property(p => p.CARIAD).HasColumnName("CARIAD");
            this.Property(p => p.YETKILIKISI).HasColumnName("YETKILIKISI");
            this.Property(p => p.FATURAUNVAN).HasColumnName("FATURAUNVAN");
            this.Property(p => p.CEPTELEFON).HasColumnName("CEPTELEFON");

            this.Property(p => p.TELEFON).HasColumnName("TELEFON");

            this.Property(p => p.FAX).HasColumnName("FAX");

            this.Property(p => p.EMAIL).HasColumnName("EMAIL");

            this.Property(p => p.WEB).HasColumnName("WEB");

            this.Property(p => p.IL).HasColumnName("IL");

            this.Property(p => p.ILCE).HasColumnName("ILCE");

            this.Property(p => p.SEMT).HasColumnName("SEMT");


            this.Property(p => p.ADRES).HasColumnName("ADRES");

            this.Property(p => p.CARIGRUP).HasColumnName("CARIGRUP");

            this.Property(p => p.CARIALTGRUBU).HasColumnName("CARIALTGRUBU");

            this.Property(p => p.OZELKOD1).HasColumnName("OZELKOD1");

            this.Property(p => p.OZELKOD2).HasColumnName("OZELKOD2");

            this.Property(p => p.OZELKOD3).HasColumnName("OZELKOD3");

            this.Property(p => p.OZELKOD4).HasColumnName("OZELKOD4");

            this.Property(p => p.VERGIDAIRE).HasColumnName("VERGIDAIRE");


            this.Property(p => p.VERGINO).HasColumnName("VERGINO");

            this.Property(p => p.ISKONTOORAN).HasColumnName("ISKONTOORAN");

            this.Property(p => p.RISKLIMIT).HasColumnName("RISKLIMIT");

            this.Property(p => p.ALISOZELFIYAT).HasColumnName("ALISOZELFIYAT");

            this.Property(p => p.SATISOZELFIYAT).HasColumnName("SATISOZELFIYAT");

            this.Property(p => p.ACIKLAMA).HasColumnName("ACIKLAMA");

        }
    }
}
