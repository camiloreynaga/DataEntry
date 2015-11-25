using FluentNHibernate.Mapping;
using DataEntry_Library.Entities.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_Library.Mapping.Tablas
{
    public class SupestructuraMap : ClassMap<Supestructura>
    {
        public SupestructuraMap()
        {
            Table("supestructura");
            Id(c => c.Id);
            Map(c => c.Codigo);
            Map(c => c.Descripcion);
            Map(c => c.Provincia);
            Map(c => c.Distrito);
            Map(c => c.Activo)
                .Default("1");
        }
    }
}
