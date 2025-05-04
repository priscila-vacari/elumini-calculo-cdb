namespace CalculoCDB.Application.DTOs
{
    public class CalculoResponseDTO
    {
        public int PrazoMeses { get; }
        public decimal ValorInicial { get; }
        public decimal ValorBruto { get; }
        public decimal ValorImposto { get; }
        public decimal ValorLiquido { get; }

        public CalculoResponseDTO() { }

        public CalculoResponseDTO(int prazoMeses, decimal valorInicial, decimal valorBruto, decimal valorImposto, decimal valorLiquido)
        {
            PrazoMeses = prazoMeses;
            ValorInicial = Math.Round(valorInicial, 2);
            ValorBruto = Math.Round(valorBruto, 2);
            ValorImposto = Math.Round(valorImposto, 2);
            ValorLiquido = Math.Round(valorLiquido, 2);
        }
    }
}
