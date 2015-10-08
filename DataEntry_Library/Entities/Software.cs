using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_Library.Entities
{
    public class Software
    {
        public virtual int Id { get; set; }
        public virtual string software { get; set; }
        public virtual bool Activo { get; set; }
    }
}
