using FluentValidation;
using NetSatıs.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatıs.Entities.Validations
{
    public class KASAVALİDATOR : AbstractValidator<KASA>
    {
        public KASAVALİDATOR()
        {

            RuleFor(p => p.KASAKOD).NotEmpty().WithMessage("KASA KODU ALANI BOŞ GEÇİLEMEZ");
            RuleFor(p => p.KASAAD).NotEmpty().WithMessage("KASA ADI BOŞ GEÇİLEMEZ").Length(5, 50).WithMessage("KASA ADI ALANI 5 İLE 50 KARAKTER ARASINDA OLABİLİR");

        }
    
    }
}
