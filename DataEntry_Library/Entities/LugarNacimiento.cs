using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataEntry_Library.Entities.Tablas;

namespace DataEntry_Library.Entities
{
    public class LugarNacimiento
    {
        public virtual int Id { get; set; }
        public virtual Pais Pais { get; set; }
        public virtual UbigeoRegion Region { get; set; }
        public virtual UbigeoProvincia Provincia { get; set; }
        public virtual UbigeoDistrito Distrito { get; set; }

        public virtual Persona persona { get; set; }

    }
}
