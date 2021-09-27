
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapimvc.data;
using webapimvc.models;

namespace webapimvc.repositories
{
    public class RepositoryEmpleados
    {
        EmpleadosContext context;

        public RepositoryEmpleados(EmpleadosContext context)
        {
            this.context = context;
        }

        public List<Empleado> GetEmpleados()
        {
            return this.context.Empleados.ToList();
        }

        public Empleado BuscarEmpleado(int idempleado)
        {
            return this.context.Empleados.SingleOrDefault(z => z.IdEmpleado == idempleado);
        }
    }
}
