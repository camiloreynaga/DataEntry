using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_Library.Entities
{
    public class ExperienciaLaboral
    {
        public virtual int Id { get; set; }
        public virtual string Empresa { get; set; }
        public virtual Cargo Cargo { get; set; }
        public virtual string Tiempo { get; set; }
        public virtual string Dependencia { get; set; }
        public virtual string Experiencia { get; set; }

    }
}
