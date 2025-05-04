using CalculoCDB.Application.DTOs;
using CalculoCDB.Application.Interfaces;
using Microsoft.Extensions.Logging;

namespace CalculoCDB.Application.Services
{
    public class CdbService(ILogger<CdbService> logger) : ICdbService
    {
        private readonly ILogger<CdbService> _logger = logger;

        #region constantes
        private const decimal cdi = 0.009m;  // 0.9%
        private const decimal tb = 1.08m;    // 108%
        #endregion

        public CalculoResponseDTO Calcular(CalculoRequestDTO request)
        {
            _logger.LogInformation("Calculando nova requisição");

            decimal valorBruto = CalcularValorBruto(request.PrazoMeses, request.ValorInicial);
            decimal valorImposto = CalcularValorImposto(request.PrazoMeses, request.ValorInicial, valorBruto);
            decimal valorLiquido = valorBruto - valorImposto;

            var response = new CalculoResponseDTO(request.PrazoMeses, request.ValorInicial, valorBruto, valorImposto, valorLiquido);
            return response;
        }

        private static decimal CalcularValorBruto(int prazoMeses, decimal valorInicial)
        {
            decimal valorBruto = valorInicial;
            for (int i = 0; i < prazoMeses; i++)
                valorBruto *= (1 + (cdi * tb));
            return valorBruto;
        }

        private static decimal CalcularValorImposto(int prazoMeses, decimal valorInicial, decimal valorFinal)
        {
            decimal rendimento = valorFinal - valorInicial;
            decimal taxaImposto = prazoMeses switch
            {
                <= 6 => 0.225m,  // 22,5%
                <= 12 => 0.20m,   // 20%
                <= 24 => 0.175m,  // 17,5%
                _ => 0.15m         // 15%
            };
            return rendimento * taxaImposto;
        }
    }
}
