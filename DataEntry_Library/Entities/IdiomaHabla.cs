using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_Library.Entities
{
    public class IdiomaHabla
    {
        public virtual int Id { get; set; }
        public virtual Idioma idioma { get; set; }
        public virtual string Nivel { get; set; }

    }
}
