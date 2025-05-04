using System.Text.Json.Serialization;

namespace CalculoCDB.API.Models
{
    /// <summary>
    /// Classe de resposta do pedido
    /// </summary>
    public class CalculoResponseModel
    {
        /// <summary>
        /// Prazo em meses para calculo 
        /// </summary>
        [JsonPropertyName("prazoMeses")]
        public int PrazoMeses { get; set; }

        /// <summary>
        /// Valor inicial investido
        /// </summary>
        [JsonPropertyName("valorInicial")]
        public decimal ValorInicial { get; set; }

        /// <summary>
        /// Valor bruto
        /// </summary>
        [JsonPropertyName("valorBruto")]
        public decimal ValorBruto { get; set; }

        /// <summary>
        /// Valor imposto
        /// </summary>
        [JsonPropertyName("valorImposto")]
        public decimal ValorImposto { get; set; }

        /// <summary>
        /// Valor liquido
        /// </summary>
        [JsonPropertyName("valorLiquido")]
        public decimal ValorLiquido { get; set; }
    }
}
