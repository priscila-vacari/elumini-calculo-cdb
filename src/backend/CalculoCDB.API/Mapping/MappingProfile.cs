using AutoMapper;
using CalculoCDB.API.Models;
using CalculoCDB.Application.DTOs;
using System.Diagnostics.CodeAnalysis;

namespace CalculoCDB.API.Mapping
{
    /// <summary>
    /// Mapeamento de modelos
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class MappingProfile: Profile
    {
        /// <summary>
        /// Perfis de mapeamento
        /// </summary>
        public MappingProfile()
        {
            CreateMap<CalculoRequestModel, CalculoRequestDTO>().ReverseMap();
            CreateMap<CalculoResponseModel, CalculoResponseDTO>().ReverseMap();
        }
    }
}
