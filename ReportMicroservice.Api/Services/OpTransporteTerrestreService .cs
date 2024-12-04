using ReportMicroservice.Domain.Entities;
using ReportMicroservice.Domain.Interfaces;
using ReportMicroservice.Domain.InterfacesServices;

namespace ReportMicroservice.Api.Services
{
    public class OpTransporteTerrestreService:IOpTransporteTerrestreService
    {
        private readonly IOpTransporteTerrestreRepository _repository;

        public OpTransporteTerrestreService(IOpTransporteTerrestreRepository repository)
        {
            _repository = repository;
        }
        public async Task<IEnumerable<OpTransporteTerrestre>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }
    }
}
