﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_Library.Entities
{
    public class EspecialidadMedica : FormacionAcademica
    {
        /// <summary>
        /// denominación de la especializadad
        /// </summary>
        public virtual string Denominacion { get; set;}
        /// <summary>
        /// número de registro RNE
        /// </summary>
        public virtual string NumeroRegistroRNE { get; set; }
        /// <summary>
        /// año en el que hizo su residentado
        /// </summary>
        public virtual string AnioResidentado { get; set; }

    }
}
