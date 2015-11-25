
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_Library.Entities.Tablas
{
    public class Supestructura
    {

        public virtual int Id { get; set; }
        public virtual string Codigo { get; set; }
        //nombre o descripcion de la superestructura
        public virtual string Descripcion { get; set; }
        public virtual string Departamento { get; set; }
        public virtual string Provincia { get; set; }
        public virtual string Distrito { get; set;  }
        public virtual bool Activo { get; set; }

    }
}
