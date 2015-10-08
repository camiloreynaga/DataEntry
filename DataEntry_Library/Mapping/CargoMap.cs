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
            Id(c => c.id);
            Map(c => c.cargo);
            Map(c => c.Activo)
                .Default("1");
            //HasMany(x => x.Staff)
            //    .Cascade.All()
            //    .Inverse();
        }
    }
}
