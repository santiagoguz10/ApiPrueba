using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPrueba.Entities
{
    public class Validations: AbstractValidator<Solicitud_Ingreso>
    {
        public Validations()
        {
            RuleFor(x => x.Nombre).NotEmpty().WithMessage("Por favor ingrese su nombre");
            RuleFor(x => x.Apellido).NotEmpty().WithMessage("Por favor ingrese su apellido");
            RuleFor(x => x.Edad).NotEmpty().WithMessage("Por favor ingrese su edad");
            RuleFor(x => x.Identificacion).NotEmpty().WithMessage("Por favor ingrese su numero de identificacion");

        }


        // Must be greater than 18 years old
        private bool BeAValidAge(DateTime? date)
        {
            if (date.HasValue)
                return (DateTime.Now.Year - date.Value.Year) >= 21;

            return false;
        }
    }
}
