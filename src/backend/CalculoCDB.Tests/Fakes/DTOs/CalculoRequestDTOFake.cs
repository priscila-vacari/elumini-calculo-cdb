using Bogus;
using CalculoCDB.Application.DTOs;

namespace CalculoCDB.Tests.Fakes.DTO
{
    public class CalculoRequestDTOFake : Faker<CalculoRequestDTO>
    {
        public CalculoRequestDTOFake()
        {
            RuleFor(p => p.PrazoMeses, f => f.Random.Int(2, 100));
            RuleFor(p => p.ValorInicial, f => f.Random.Decimal(1, 1000000));
        }
    }
}
