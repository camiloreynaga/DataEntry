using FluentNHibernate.Mapping;
using DataEntry_Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_Library.Mapping
{
    public class UserTypeMap: ClassMap<UserType>
    {
        public UserTypeMap()
        {
            Table("user_type");
            Id(c => c.id);
            Map(c => c.user_type_name);
            Map(c => c.user_type_value);
        }
    }
}
