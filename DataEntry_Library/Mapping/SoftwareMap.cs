using FluentNHibernate.Mapping;
using DataEntry_Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_Library.Mapping
{
    public class SoftwareMap : ClassMap<Software>
    {
        public SoftwareMap()
        {
            Table("software");
            Id(c => c.Id);
            Map(c => c.software);
            Map(c => c.Activo)
                .Default("1");
        }
    }
}
