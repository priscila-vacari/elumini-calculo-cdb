using Asp.Versioning;
using AutoMapper;
using CalculoCDB.API.Models;
using CalculoCDB.Application.DTOs;
using CalculoCDB.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CalculoCDB.API.Controllers.v1
{
    /// <summary>
    /// Controller responsável pelos cálculos de investimento
    /// </summary>
    /// <param name="logger"></param>
    /// <param name="mapper"></param>
    /// <param name="cdbService"></param>
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class CdbController(ILogger<CdbController> logger, IMapper mapper, ICdbService cdbService) : BaseController(logger, mapper)
    {
        private readonly ICdbService _cdbService = cdbService;

        /// <summary>
        /// Calcular a requisição
        /// </summary>
        /// <param name="request"></param>
        /// <returns>Retorna o valor calculado</returns>
        [HttpPost("calcular")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Calcular([FromBody] CalculoRequestModel request)
        {
            _logger.LogInformation("Calcular a requisição.");

            var calculoRequest = _mapper.Map<CalculoRequestDTO>(request);

            var calculoResponse = _cdbService.Calcular(calculoRequest);

            var response = _mapper.Map<CalculoResponseModel>(calculoResponse);
            return Ok(response);
        }
    }
}
