using FluentNHibernate.Mapping;
using DataEntry_Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_Library.Mapping
{
    public class CargoMap : ClassMap<Cargo>
    {
        public CargoMap()
        {
            Table("cargo");
            Id(c => c.Id);
            Map(c => c.Codigo);
            Map(c => c.TipoArea);
            References(c => c.supcargo);
            References(c => c.grupoOcupacional);
            References(c => c.nivel);
            References(c => c.clase);
            References(c => c.perfilCargo);
            Map(c => c.Descripcion);
            Map(c => c.Activo)
                .Default("1");
            //HasMany(x => x.Staff)
            //    .Cascade.All()
            //    .Inverse();
        }
    }
}
