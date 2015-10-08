using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_Library.Entities
{
    public class FormacionAcademica
    {
        public virtual int Id { get; set; }

        public virtual string Grado { get; set; }
        public virtual string Institucion { get; set; }
        public virtual string NivelAlcanzado { get; set; }
        public virtual bool Concluida { get; set; }
         /// <summary>
        /// formato AAAAMM anio mes
        /// </summary>
        public virtual string FechaOptaNivel { get; set; }
        
        

    }
}
