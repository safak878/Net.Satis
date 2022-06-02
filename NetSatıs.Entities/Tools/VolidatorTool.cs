using FluentValidation;
using NetSatıs.Entities.Tables;
using System.Windows.Forms;
using NetSatıs.Entities.Rapositories;
using System;
using NetSatıs.Entities.Interfacess;

namespace NetSatıs.Entities.Tools
{
    public static class VolidatorTool
    {
        internal static bool validationResut;

        public static bool Validate(IValidator valitador, IEntitiy entity)
        {
            bool result = true;
            var validationResult = valitador.Validate(entity);
            if (!validationResult.IsValid)
            {
                string message = null;
                foreach (var error in validationResult.Errors)
                {
                    message += error.ErrorMessage + System.Environment.NewLine;

                }
                MessageBox.Show(message);
                result = false;
            }


            return result;
        }

  
    }
}

  
