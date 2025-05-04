using Bogus;
using CalculoCDB.Application.DTOs;

namespace CalculoCDB.Tests.Fakes.DTO
{
    public class CalculoResponseDTOFake : Faker<CalculoResponseDTO>
    {
        public CalculoResponseDTOFake()
        {
            RuleFor(p => p.PrazoMeses, f => f.Random.Int(2, 100));
            RuleFor(p => p.ValorInicial, f => f.Random.Decimal(1, 1000000));
            RuleFor(p => p.ValorBruto, f => f.Random.Decimal(1, 1000000));
            RuleFor(p => p.ValorImposto, f => f.Random.Decimal(1, 1000000));
            RuleFor(p => p.ValorLiquido, f => f.Random.Decimal(1, 1000000));
        }
    }
}
