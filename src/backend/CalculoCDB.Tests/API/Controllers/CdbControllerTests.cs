using AutoMapper;
using Microsoft.Extensions.Logging;
using CalculoCDB.API.Controllers.v1;
using CalculoCDB.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using CalculoCDB.API.Models;
using Moq;
using CalculoCDB.Application.DTOs;
using CalculoCDB.Tests.Fakes.Entities;

namespace CalculoCDB.Tests.API.Controllers
{
    public class CDBControllerTests
    {
        private readonly Mock<ILogger<CdbController>> _logger;
        private readonly Mock<IMapper> _mapper;
        private readonly Mock<ICdbService> _service;
        private readonly CdbController _controller;

        public CDBControllerTests()
        {
            _logger = new Mock<ILogger<CdbController>>();
            _mapper = new Mock<IMapper>();
            _service = new Mock<ICdbService>();
            _controller = new CdbController(_logger.Object, _mapper.Object, _service.Object);
        }

        [Fact]
        public void Calcular_DeveRetornarOk_QuandoValoresValidos()
        {
            var request = new CalculoRequestModelFake().Generate();
            var calculoRequestDTO = new CalculoRequestDTO { ValorInicial = request.ValorInicial, PrazoMeses = request.PrazoMeses };
            var calculoResponseDTO = new CalculoResponseDTO(request.PrazoMeses, request.ValorInicial, 1500, 200, 1300);
            var responseModel = new CalculoResponseModel { ValorBruto = calculoResponseDTO.ValorBruto, ValorLiquido = calculoResponseDTO.ValorLiquido, ValorImposto = calculoResponseDTO.ValorImposto };

            _mapper.Setup(m => m.Map<CalculoRequestDTO>(request)).Returns(calculoRequestDTO);
            _service.Setup(s => s.Calcular(calculoRequestDTO)).Returns(calculoResponseDTO);
            _mapper.Setup(m => m.Map<CalculoResponseModel>(calculoResponseDTO)).Returns(responseModel);

            var result = _controller.Calcular(request) as OkObjectResult;

            Assert.NotNull(result);
            Assert.Equal(200, result.StatusCode);
            Assert.Equal(responseModel, result.Value);
        }
    }
}