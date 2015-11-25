using FluentNHibernate.Mapping;
using DataEntry_Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_Library.Mapping
{
    public class LineaCarreraMap : ClassMap<LineaCarrera>
    {
        public LineaCarreraMap()
        {
            Table("linea_carrera");
            Id(c => c.Id);
            Map(c => c.Codigo);
            Map(c => c.TipoArea);
            Map(c => c.Descripcion);
            References(c => c.supcargo);
            References(c => c.grupoOcupacional);
            References(c => c.nivel);
            References(c => c.clase);
            Map(c => c.Activo)
                .Default("1");
        }
    }
}
