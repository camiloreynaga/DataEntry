using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataEntry_Library.Entities;

namespace DataEntry_Library.Entities
{
    public class PostGrado: FormacionAcademica
    {
        public virtual string Tipo { get; set; }
        public virtual string Denominacion { get; set; }
    }
}
