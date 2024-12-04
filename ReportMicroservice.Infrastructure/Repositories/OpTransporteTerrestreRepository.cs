using ReportMicroservice.Domain.Entities;
using ReportMicroservice.Domain.Interfaces;
using ReportMicroservice.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportMicroservice.Infrastructure.Repositories
{
    public class OpTransporteTerrestreRepository:IOpTransporteTerrestreRepository
    {
        private readonly TestDbContext _context;
        public OpTransporteTerrestreRepository(TestDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<OpTransporteTerrestre>> GetAllAsync()
        {
            return await _context.OpTransporteTerrestre.ToListAsync();
        }
    }
}
