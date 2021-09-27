
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapimvc.models;

namespace webapimvc.data
{
    public class EmpleadosContext : DbContext
    {
        public EmpleadosContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Empleado> Empleados { get; set; }
    }
}
