using FluentNHibernate.Mapping;
using DataEntry_Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_Library.Mapping
{
    public class ExperienciaLaboralMap: ClassMap<ExperienciaLaboral>
    {
        public ExperienciaLaboralMap()
        {
            Id(c => c.Id);
            Map(c => c.Empresa);
            References(c => c.Cargo);
            Map(c => c.Tiempo);
            Map(c => c.Dependencia);
            Map(c => c.Experiencia);
        }
    }
}
