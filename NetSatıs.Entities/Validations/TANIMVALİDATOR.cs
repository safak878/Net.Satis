using FluentValidation;
using NetSatıs.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetSatıs.Entities.Validations
{
   public class TANIMVALİDATOR : AbstractValidator<TANIM>
    {
        public TANIMVALİDATOR()
        {

            RuleFor(p => p.TUR).NotEmpty().WithMessage("TANIM TÜRÜ ALANI BOŞ GEÇİLEMEZ");
            RuleFor(p => p.TANIMI).NotEmpty().WithMessage("TANIM ALANI BOŞ GEÇİLEMEZ");

        }
    
    }
}
