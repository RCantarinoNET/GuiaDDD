using FluentValidation;
using Main.Domain.Entities;
using System;

namespace Main.Service.Validators
{
    public class UsuarioValidator : AbstractValidator<User>
    {
        public UsuarioValidator()
        {
            RuleFor(x => x)
                .NotNull()
                .OnAnyFailure(x => { throw new ArgumentNullException("Objeto não encontrado!"); });

            RuleFor(c => c.Cpf)
                .NotEmpty().WithMessage("Is necessary to inform the CPF.")
                .NotNull().WithMessage("Is necessary to inform the CPF.");

            RuleFor(c => c.BirthDate)
                .NotEmpty().WithMessage("Is necessary to inform the birth date.")
                .NotNull().WithMessage("Is necessary to inform the birth date.");

            RuleFor(c => c.Name)
                .NotEmpty().WithMessage("Is necessary to inform the name.")
                .NotNull().WithMessage("Is necessary to inform the birth date.");
        }
    }
}