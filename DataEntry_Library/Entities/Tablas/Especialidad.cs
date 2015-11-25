using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_Library.Entities.Tablas
{
    public class Especialidad
    {
        /// <summary>
        /// código univoco de BD
        /// </summary>
        public virtual int Id { get; set; }
        /// <summary>
        /// código de especialidad
        /// </summary>
        public virtual string Codigo { get; set; }
        /// <summary>
        /// descripción o nombre de la especialidad
        /// </summary>
        public virtual string Descripcion { get; set; }
        /// <summary>
        /// indica si actualmente esta activo esta especialidad
        /// </summary>
        public virtual bool Activo { get; set; }
    }
}
