using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_Library.Entities
{
    public class Log
    {
        public virtual int Id { get; set; }
        public virtual DateTime Fecha { get; set; }
        public virtual string Tabla { get; set; }
        public virtual string Campo { get; set; }
        public virtual string Usuario { get; set; }
        /// <summary>
        /// registo de suceso para la tabla
        /// </summary>
        public virtual string Suceso { get; set; }
    }
}
