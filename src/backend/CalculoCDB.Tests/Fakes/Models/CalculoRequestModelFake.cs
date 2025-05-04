using Bogus;
using CalculoCDB.API.Models;

namespace CalculoCDB.Tests.Fakes.Entities
{
    public class CalculoRequestModelFake : Faker<CalculoRequestModel>
    {
        public CalculoRequestModelFake()
        {
            RuleFor(p => p.PrazoMeses, f => f.Random.Int(2, 100));
            RuleFor(p => p.ValorInicial, f => Math.Round(f.Random.Decimal(1, 1000000), 2));
        }
    }
}
