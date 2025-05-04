using CalculoCDB.Application.DTOs;

namespace CalculoCDB.Application.Interfaces
{
    public interface ICdbService
    {
        CalculoResponseDTO Calcular(CalculoRequestDTO request);
    }
}
