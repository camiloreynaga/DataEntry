using FluentNHibernate.Mapping;
using DataEntry_Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_Library.Mapping
{
    public class ProfesionMap : SubclassMap<Profesion>
    {
        public ProfesionMap()
        {
            Map(c => c.ProfesionEspecialidad);
            Map(c => c.Universitario);
            Map(c => c.Titulado);
            Map(c => c.NroColegiatura);
        }
    }
}
