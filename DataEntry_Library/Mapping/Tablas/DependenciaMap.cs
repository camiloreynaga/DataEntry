using FluentNHibernate.Mapping;
using DataEntry_Library.Entities.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_Library.Mapping.Tablas
{
    public class DependenciaMap : ClassMap<Dependencia>
    {
        public DependenciaMap()
        {
            Table("dependencia");
            Id(c => c.Id);
            Map(c => c.Codigo);
            Map(c => c.Descripcion);
            References(c => c.supestructura);
            Map(c => c.Programa);
            Map(c => c.Subprograma);
            Map(c => c.Actividad);
            Map(c => c.Subactividad1);
            Map(c => c.Subactividad2);
            Map(c => c.Subactividad3);
            Map(c => c.TipoArea);
            Map(c => c.Ubigeo);
            Map(c => c.UbigeoDep);
            Map(c => c.UbigeoPro);
            Map(c => c.UbigeoDis);
            Map(c => c.BzmdAsistencial);
            Map(c => c.BzmdAdministrativo);
            References(c => c.cap);
            Map(c => c.Activo)
                .Default("1");
        }
    }
}
