using FluentNHibernate.Mapping;
using DataEntry_Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_Library.Mapping
{
    public class CapacitacionMap : ClassMap<Capacitacion>
    {
        public CapacitacionMap()
        {
            Id(c => c.Id);
            Map(c => c.Descripcion);
            Map(c => c.Activo)
                .Default("1");
        }
    }
}
