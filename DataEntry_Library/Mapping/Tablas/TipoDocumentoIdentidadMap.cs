using FluentNHibernate.Mapping;
using DataEntry_Library.Entities.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_Library.Mapping
{
    public class TipoDocumentoIdentidadMap: ClassMap<TipoDocumentoIdentidad>
    {
        public TipoDocumentoIdentidadMap ()
        {
            Table("tipo_documento_identidad");
            Id(c => c.Id);
            Map(c => c.Codigo);
            Map(c => c.Descripcion);
            Map(c => c.DescripcionAbreviada);
            Map(c => c.Activo)
                .Default("1");
        }
    }
}
