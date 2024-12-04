using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportMicroservice.Domain.Entities
{
    public class OpTransporteTerrestre
    {
        public int Id { get; set; } // Identificador único
        public string Codigo { get; set; } // Código del transporte
        public string RazonSocial { get; set; } // Nombre o razón social
        public int ParqueAutomotor { get; set; } // Detalles del parque automotor
    }
}
