using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_Library.Entities
{
    public class Idioma
    {
        public virtual int Id { get; set; }
        public virtual string idioma { get; set; }
        //public virtual string Nivel { get; set; }
        // public virtual IList<Empleado> Staff { get; set; }
        public virtual bool Activo { get; set; }
    }
}
