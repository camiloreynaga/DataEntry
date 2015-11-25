using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataEntry_Library.Entities.Tablas;

namespace DataEntry_Library.Entities
{
    public class LineaCarrera
    {
        public virtual int Id { get; set; }
        public virtual string Codigo { get; set; }
        public virtual string TipoArea { get; set; }
        public virtual string Descripcion { get; set; }
        public virtual Supcargo supcargo { get; set; }
        public virtual GrupoOcupacional grupoOcupacional { get; set; }
        public virtual Nivel nivel { get; set; }
        public virtual Clase clase { get; set; }
        public virtual bool Activo { get; set; }
    }
}
