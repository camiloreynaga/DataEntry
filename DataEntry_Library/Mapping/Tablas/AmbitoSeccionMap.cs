using FluentNHibernate.Mapping;
using DataEntry_Library.Entities.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_Library.Mapping.Tablas
{
    public class AmbitoSeccionMap : ClassMap<AmbitoSeccion>
    {
        public AmbitoSeccionMap()
        {
            Table("ambito_seccion");
            Id(c => c.Id);
            Map(c => c.Codigo);
            Map(c => c.Descripcion);
            References(c => c.seccion);
            Map(c => c.Activo)
                .Default("1");
        }
    }
}
