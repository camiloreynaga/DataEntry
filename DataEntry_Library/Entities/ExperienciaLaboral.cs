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
        /// <summary>
        /// Cargo, se debe considerar el cargo que ocupo. 
        /// que para nuestro sistema se relaciona mejor con linea de carrera
        /// Linea de carrera es el nombre del cargo como nombre generico.
        /// </summary>
        public virtual LineaCarrera Cargo { get; set; }
        public virtual string Tiempo { get; set; }
        public virtual string Dependencia { get; set; }
        public virtual string Experiencia { get; set; }

    }
}
