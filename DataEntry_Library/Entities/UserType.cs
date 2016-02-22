using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_Library.Entities
{
    public class UserType
    {

        public virtual int id { get; set; }
        public virtual string user_type_name { get; set; }
        public virtual string user_type_value { get; set; }
    }
}
