using FluentNHibernate.Mapping;
using DataEntry_Library.Entities.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_Library.Mapping.Tablas
{
    public class SupcargoMap : ClassMap<Supcargo>
    {
        public SupcargoMap()
        {
            Table("supcargo");
            Id(c => c.Id);
            Map(c => c.Codigo);
            Map(c => c.Descripcion);
            References(c => c.Grupo);
            References(c => c.NivelProfesional);
            Map(c => c.Activo)
                .Default("1");
        }
    }
}
