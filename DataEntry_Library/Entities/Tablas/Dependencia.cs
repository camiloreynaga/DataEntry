using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_Library.Entities.Tablas
{
    public class Dependencia
    {
        public virtual int Id { get; set; }
        public virtual string Codigo { get; set; }
        public virtual string Descripcion { get; set; }
        public virtual Supestructura supestructura { get; set; }
        public virtual string Programa { get; set; }
        public virtual string Subprograma { get; set; }
        public virtual string Actividad { get; set; }
        public virtual string Subactividad1 { get; set; }
        public virtual string Subactividad2 { get; set; }
        public virtual string Subactividad3 { get; set; }
        // tipo de area asistencia de dependencia A = administrativa; S =asistencial
        public virtual string TipoArea { get; set; }
        public virtual string Ubigeo { get; set; }
        public virtual string UbigeoDep { get; set; }
        public virtual string UbigeoPro { get; set; }
        public virtual string UbigeoDis { get; set; }
        public virtual string BzmdAsistencial { get; set; }
        public virtual string BzmdAdministrativo { get; set; }
        public virtual Cap cap { get; set; }
        public virtual bool Activo { get; set; }
    }
}
