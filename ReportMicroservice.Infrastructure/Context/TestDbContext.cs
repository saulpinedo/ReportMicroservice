using Microsoft.EntityFrameworkCore;
using ReportMicroservice.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportMicroservice.Infrastructure.Context
{
    public class TestDbContext:DbContext
    {
        public DbSet<OpTransporteTerrestre> OpTransporteTerrestre { get; set; }
        public TestDbContext(DbContextOptions<TestDbContext> options): base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            Console.WriteLine("Ejecutando OnModelCreating");

            // Si no existen datos, agregamos algunos de ejemplo
            modelBuilder.Entity<OpTransporteTerrestre>().HasData(
                new OpTransporteTerrestre { Id=1, Codigo = "001", RazonSocial = "Transporte A", ParqueAutomotor = 20 },
                new OpTransporteTerrestre { Id = 2, Codigo = "002", RazonSocial = "Transporte B", ParqueAutomotor = 30 }
            );
        }
    }
}
