using FluentNHibernate.Mapping;
using DataEntry_Library.Entities.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_Library.Mapping.Tablas
{
    public class CapMap : ClassMap<Cap>
    {
        public CapMap()
        {
            Table("cap");
            Id(c => c.Id);
            Map(c => c.Codigo);
            Map(c => c.CentroCap);
            Map(c => c.DenominacionCap);
            Map(c => c.Activo)
                .Default("1");
        }
    }
}
