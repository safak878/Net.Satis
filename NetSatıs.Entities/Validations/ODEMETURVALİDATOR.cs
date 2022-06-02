using FluentValidation;
using NetSatıs.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatıs.Entities.Validations
{
   public class ODEMETURVALİDATOR : AbstractValidator<ODEMETUR>
    {
        public ODEMETURVALİDATOR()
        {

            RuleFor(p => p.ODEMETURKOD).NotEmpty().WithMessage("ÖDEME TÜRÜ KODU ALANI BOŞ GEÇİLEMEZ");
            RuleFor(p => p.ODEMETURAD).NotEmpty().WithMessage("ÖDEME TÜRÜ ADI BOŞ GEÇİLEMEZ").Length(5, 50).WithMessage("ÖDEME TÜRÜ ADI ALANI 5 İLE 50 KARAKTER ARASINDA OLABİLİR");

        }
    
    }
}
