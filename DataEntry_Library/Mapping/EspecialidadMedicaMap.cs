﻿using FluentNHibernate.Mapping;
using DataEntry_Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_Library.Mapping
{
    public class EspecialidadMedicaMap : SubclassMap<EspecialidadMedica>
    {
        public EspecialidadMedicaMap()
        {
            Map(c => c.Denominacion);
            Map(c => c.NumeroRegistroRNE);
            Map(c => c.AnioResidentado);
        }
    }
}
