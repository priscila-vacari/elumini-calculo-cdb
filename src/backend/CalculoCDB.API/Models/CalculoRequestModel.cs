using System.Text.Json.Serialization;

namespace CalculoCDB.API.Models
{
    /// <summary>
    /// Classe de requisição do pedido
    /// </summary>
    public class CalculoRequestModel
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
    }
}
