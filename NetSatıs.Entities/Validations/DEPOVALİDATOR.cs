using FluentValidation;
using NetSatıs.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatıs.Entities.Validations
{
   public class DEPOVALİDATOR : AbstractValidator<DEPO>
    {
        public DEPOVALİDATOR()
        {

            RuleFor(p => p.DEPOKOD).NotEmpty().WithMessage("DEPO KODU ALANI BOŞ GEÇİLEMEZ");
            RuleFor(p => p.DEPOAD).NotEmpty().WithMessage("DEPO ADI BOŞ GEÇİLEMEZ").Length(5, 50).WithMessage("DEPO ADI ALANI 5 İLE 50 KARAKTER ARASINDA OLABİLİR");

        }
    }
}
