using ReportMicroservice.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportMicroservice.Domain.InterfacesServices
{
    public interface IOpTransporteTerrestreService
    {
        Task<IEnumerable<OpTransporteTerrestre>> GetAllAsync();
    }
}
