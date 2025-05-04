using CalculoCDB.Application.DTOs;
using CalculoCDB.Application.Services;
using CalculoCDB.Tests.Fakes.DTO;
using Microsoft.Extensions.Logging;
using Moq;

namespace CalculoCDB.Tests.Application.Services
{
    public class CdbServiceTests
    {
        private readonly Mock<ILogger<CdbService>> _logger;
        private readonly CdbService _service;

        public CdbServiceTests()
        {
            _logger = new Mock<ILogger<CdbService>>();

            _service = new CdbService(_logger.Object);
        }

        [Fact]
        public void Calcular_DeveRetornarValorBrutoCorreto()
        {
            var calculoDto = new CalculoRequestDTOFake().Generate();

            var result = _service.Calcular(calculoDto);

            Assert.True(result.ValorBruto > calculoDto.ValorInicial);
        }

        [Fact]
        public void Calcular_DeveAplicarImpostoCorreto()
        {
            var calculoDto = new CalculoRequestDTOFake().Generate();

            var result = _service.Calcular(calculoDto);

            Assert.True(result.ValorLiquido < result.ValorBruto);
            Assert.True(result.ValorImposto > 0);
        }

        [Theory]
        [InlineData(6)]
        [InlineData(12)]
        [InlineData(24)]
        [InlineData(30)]
        public void Calcular_DeveAplicarImpostoCorreto_PorFaixas(int prazoMeses)
        {
            var calculoDto = new CalculoRequestDTO { PrazoMeses = prazoMeses, ValorInicial = 1000 };

            var result = _service.Calcular(calculoDto);

            Assert.True(result.ValorLiquido < result.ValorBruto);
            Assert.True(result.ValorImposto > 0);
        }
    }
}