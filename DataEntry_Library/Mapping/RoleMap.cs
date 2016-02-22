using FluentNHibernate.Mapping;
using DataEntry_Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_Library.Mapping
{
    public class RoleMap : ClassMap<Role>
    {
        public RoleMap()
        {
            Table("role");
            Id(c => c.id);
            Map(c => c.role_name);
            Map(c => c.role_value);
        }
    }
}
