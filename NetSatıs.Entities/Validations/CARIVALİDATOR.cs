using FluentValidation;
using NetSatıs.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatıs.Entities.Validations
{
    public class CARIVALİDATOR : AbstractValidator<CARI>
    {
        public CARIVALİDATOR()
        {

            RuleFor(p => p.CARIKOD).NotEmpty().WithMessage("CARİ KODU ALANI BOŞ GEÇİLEMEZ");
            RuleFor(p => p.CARIAD).NotEmpty().WithMessage("CARİ ADI BOŞ GEÇİLEMEZ").Length(5, 50).WithMessage("CARİ ADI ALANI 5 İLE 50 KARAKTER ARASINDA OLABİLİR");
            RuleFor(p => p.YETKILIKISI).NotEmpty().WithMessage("YETKİLİ KİŞİ ALANI BOŞ GEÇİLEMEZ");
            RuleFor(p => p.FATURAUNVAN).NotEmpty().WithMessage("FATURA ÜNVANI ALANI BOŞ GEÇİLEMEZ");
            RuleFor(p => p.EMAIL).EmailAddress().WithMessage("GİRDİĞİNİZ EMAİL ADRESİ GEÇERSİZ");
            RuleFor(p => p.ISKONTOORAN).GreaterThanOrEqualTo(0).WithMessage("ISKONTO ORANI ALANI 0'DAN KÜÇÜK OLAMAZ");
            RuleFor(p => p.RISKLIMIT).GreaterThanOrEqualTo(0).WithMessage("RİSK LİMİTİ ALANI 0'DAN KÜÇÜK OLAMAZ");
        }
    }
}
