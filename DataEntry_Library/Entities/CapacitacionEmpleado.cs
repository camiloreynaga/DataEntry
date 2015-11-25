using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_Library.Entities
{
    public class CapacitacionEmpleado
    {
        public virtual string Tiempo { get; set; }
        public virtual double Horas { get; set; }
        public virtual double Creditos { get; set; }

        public Capacitacion Capacitaciones { get; set; }
        public Empleado Empleados { get; set; }
    }
}
