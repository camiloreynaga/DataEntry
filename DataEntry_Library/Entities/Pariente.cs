using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataEntry_Library.Entities.Tablas;

namespace DataEntry_Library.Entities
{
    public class Pariente: Persona
    {
        public virtual TipoPariente Tipo { get; set; }
        public virtual bool trabajaEssalud { get; set; }
    }
}
