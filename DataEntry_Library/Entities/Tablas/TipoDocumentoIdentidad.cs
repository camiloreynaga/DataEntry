using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_Library.Entities.Tablas
{
    public class TipoDocumentoIdentidad
    {
        public virtual int Id { get; set; }
        public virtual string Codigo { get; set; }
        public virtual string Descripcion { get; set; }
        public virtual string DescripcionAbreviada { get; set; }
        public virtual bool Activo { get; set; }
    }
}
