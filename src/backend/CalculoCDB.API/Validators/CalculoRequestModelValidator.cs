using FluentValidation;
using CalculoCDB.API.Models;

namespace CalculoCDB.API.Validators
{
    /// <summary>
    /// Classe de validação de pedido
    /// </summary>
    public class CalculoRequestModelValidator : AbstractValidator<CalculoRequestModel>
    {
        /// <summary>
        /// Validador de pedido
        /// </summary>
        public CalculoRequestModelValidator()
        {
            RuleFor(c => c.PrazoMeses)
            .GreaterThan(1)
            .WithMessage("O prazo em meses deve ser maior que 1 (um).");

            RuleFor(c => c.ValorInicial)
               .GreaterThan(0).WithMessage("O valor inicial deve ser maior que zero.");
        }
    }
}
