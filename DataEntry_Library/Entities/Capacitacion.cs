﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_Library.Entities
{
     public class Capacitacion
    {
        public virtual int Id { get; set; }
        //public virtual string Codigo { get; set; }
        public virtual string Descripcion { get; set; }
        public virtual bool Activo { get; set; }
    }
}
