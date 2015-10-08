using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_Library.Entities
{
    public class Cargo
    {

        public virtual int id { get; set; }
        public virtual string cargo { get; set; }

       // public virtual IList<Empleado> Staff { get; set; }
        public virtual bool Activo { get; set; }
    }
}
