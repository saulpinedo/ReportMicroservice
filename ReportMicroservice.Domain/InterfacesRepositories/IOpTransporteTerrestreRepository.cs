using ReportMicroservice.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportMicroservice.Domain.Interfaces
{
    public interface IOpTransporteTerrestreRepository
    {
        Task<IEnumerable<OpTransporteTerrestre>> GetAllAsync();
    }
}
