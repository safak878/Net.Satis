using FluentValidation;
using NetSatıs.Entities.Tables;

namespace NetSatıs.Entities.Validations
{
    public class STOKVALİDATOR:AbstractValidator<STOK>
    {
        public STOKVALİDATOR()
        {

            RuleFor(p => p.STOKKODU).NotEmpty().WithMessage("STOK KODU ALANI BOŞ GEÇİLEMEZ");
            RuleFor(p => p.STOKAD).NotEmpty().WithMessage("STOK ADI BOŞ GEÇİLEMEZ").Length(5,50).WithMessage("STOK ADI ALANI 5 İLE 50 KARAKTER ARASINDA OLABİLİR");
            RuleFor(p => p.BARKOD).NotEmpty().WithMessage("BARKOD ALANI BOŞ GEÇİLEMEZ");
            RuleFor(p => p.ALISFIYAT1).GreaterThanOrEqualTo(0).WithMessage("ALIŞ FİYATI - 1 ALANI 0'DAN KÜÇÜK OLAMAZ");
            RuleFor(p => p.ALISFIYAT2).GreaterThanOrEqualTo(0).WithMessage("ALIŞ FİYATI - 2 ALANI 0'DAN KÜÇÜK OLAMAZ");
            RuleFor(p => p.ALISFIYAT3).GreaterThanOrEqualTo(0).WithMessage("ALIŞ FİYATI - 3 ALANI 0'DAN KÜÇÜK OLAMAZ");
            RuleFor(p => p.SATISFIYAT1).GreaterThanOrEqualTo(0).WithMessage("SATIŞ FİYATI - 1 ALANI 0'DAN KÜÇÜK OLAMAZ");
            RuleFor(p => p.SATISFIYAT2).GreaterThanOrEqualTo(0).WithMessage("SATIŞ FİYATI - 2 ALANI 0'DAN KÜÇÜK OLAMAZ");
            RuleFor(p => p.SATISFIYAT3).GreaterThanOrEqualTo(0).WithMessage("SATIŞ FİYATI - 3 ALANI 0'DAN KÜÇÜK OLAMAZ");
        }
    }
}
