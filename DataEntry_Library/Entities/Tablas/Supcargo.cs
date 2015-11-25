using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using DataEntry_Library.Entities.Tablas;

namespace DataEntry_Library.Entities.Tablas
{
    public class Supcargo
    {

        public virtual int Id { get; set; }
        public virtual string Codigo { get; set; }
        public virtual string Descripcion { get; set; }
        public virtual GrupoOcupacional Grupo { get; set; }
        public virtual PerfilCargo NivelProfesional { get; set; }
        public virtual bool Activo { get; set; }
    }
}
