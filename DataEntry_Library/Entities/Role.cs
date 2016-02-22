using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_Library.Entities
{
    public class Role
    {
        public virtual int id { get; set; }
        public virtual string role_name { get; set; }
        public virtual string role_value { get; set; }

    }
}
