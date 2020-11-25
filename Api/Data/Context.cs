using Api.Controllers;
using Api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<Empleados> Empleados { get; set; }
        public DbSet<Factura> Factura { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Tarifa> Tarifa { get; set; }
    }
}
