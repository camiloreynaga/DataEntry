using FluentNHibernate.Mapping;
using DataEntry_Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_Library.Mapping
{
    public class StatusMap : ClassMap<Status>
    {
        public StatusMap()
        {
            Table("status");
            Id(c => c.id);
            Map(c => c.status_name);
            Map(c => c.status_value);
        }
    }
}
