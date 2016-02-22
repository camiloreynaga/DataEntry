using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_Library.Entities
{
    public  class Status
    {
        public virtual int id { get; set; }
        public virtual string status_name { get; set; }
        public virtual string status_value { get; set; }
    }
}
