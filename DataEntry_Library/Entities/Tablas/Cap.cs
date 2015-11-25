using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_Library.Entities.Tablas
{
    public class Cap
    {
        public virtual int Id { get; set; }
        public virtual string Codigo { get; set; }
        public virtual string CentroCap { get; set; }
        public virtual string DenominacionCap { get; set; }
        public virtual bool Activo { get; set; }
    }
}
