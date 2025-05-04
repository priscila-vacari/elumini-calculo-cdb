using FluentValidation.TestHelper;
using CalculoCDB.Tests.Fakes.Entities;
using CalculoCDB.API.Validators;

namespace CalculoCDB.Tests.API.Validators
{
    public class CalculoRequestModelValidatorTests
    {
        private readonly CalculoRequestModelValidator _validator;

        public CalculoRequestModelValidatorTests()
        {
            _validator = new CalculoRequestModelValidator();
        }

        [Fact]
        public void Deve_Ter_Error_Quando_PrazoMeses_Menor_Que_Um()
        {
            var model = new CalculoRequestModelFake().Generate();
            model.PrazoMeses = 1;

            var result = _validator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(x => x.PrazoMeses)
                .WithErrorMessage("O prazo em meses deve ser maior que 1 (um).");
        }

        [Fact]
        public void Deve_Ter_Error_Quando_ValorInicial_Menor_Que_Zero()
        {
            var model = new CalculoRequestModelFake().Generate();
            model.ValorInicial = 0;

            var result = _validator.TestValidate(model);

            result.ShouldHaveValidationErrorFor(x => x.ValorInicial)
                .WithErrorMessage("O valor inicial deve ser maior que zero.");
        }

        [Fact]
        public void Deve_Ser_Validado_Quando_Modelo_For_Valido()
        {
            var model = new CalculoRequestModelFake().Generate();

            var result = _validator.TestValidate(model);

            result.ShouldNotHaveAnyValidationErrors();
        }
    }
}
