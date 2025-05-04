using AutoMapper;
using CalculoCDB.API.Mapping;
using CalculoCDB.Tests.Fakes.DTO;
using CalculoCDB.Tests.Fakes.Entities;
using CalculoCDB.Application.DTOs;
using CalculoCDB.API.Models;

namespace CalculoCDB.Tests.API.Mapping
{
    public class MappingProfileTests
    {
        private readonly IConfigurationProvider _configurationProvider;
        private readonly IMapper _mapper;

        public MappingProfileTests()
        {
            _configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });

            _mapper = _configurationProvider.CreateMapper();
        }

        [Fact]
        public void FacaMapeamento_CalculoRequestModel_Para_CalculoRequestDTO()
        {
            var requestModel = new CalculoRequestModelFake().Generate();

            var dto = _mapper.Map<CalculoRequestDTO>(requestModel);

            Assert.NotNull(dto);
            Assert.Equal(requestModel.PrazoMeses, dto.PrazoMeses);
            Assert.Equal(requestModel.ValorInicial, dto.ValorInicial);
        }

        [Fact]
        public void FacaMapeamento_CalculoRequestDTO_Para_CalculoResponseModel()
        {
            var dto = new CalculoResponseDTOFake().Generate();

            var responseModel = _mapper.Map<CalculoResponseModel>(dto);

            Assert.NotNull(responseModel);
            Assert.Equal(dto.PrazoMeses, responseModel.PrazoMeses);
            Assert.Equal(dto.ValorInicial, responseModel.ValorInicial);
        }
    }
}
