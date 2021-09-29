using FluentValidation;
using Prova1bimestre.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prova1bimestre.Validation
{
    public class DimensoesValidation: AbstractValidator<Dimensoes>
    {

        public DimensoesValidation()
        {

            RuleFor(Dimensoes => Dimensoes.ComprimentoCm)

                    .NotEmpty().WithMessage("O valor é obrigatorio, tente novamente")
                    .NotNull().WithMessage("Valor não informado, tente novamente")
                    .GreaterThan(0).WithMessage("Valor do comprimento deve ser maior que 0")

                    ;


            RuleFor(Dimensoes => Dimensoes.LarguraCm)

                    .NotEmpty().WithMessage("O valor é obrigatorio, tente novamente")
                    .NotNull().WithMessage("Valor não informado, tente novamente")
                    .GreaterThan(0).WithMessage("Valor de largura deve ser maior que 0")

                    ;

            RuleFor(Dimensoes => Dimensoes.AlturaCm)

                   .NotEmpty().WithMessage("O valor é obrigatorio, tente novamente")
                   .NotNull().WithMessage("Valor não informado, tente novamente")
                   .GreaterThan(0).WithMessage("Valor da altura deve ser maior que 0")

                   ;
        }
        

    }
}
