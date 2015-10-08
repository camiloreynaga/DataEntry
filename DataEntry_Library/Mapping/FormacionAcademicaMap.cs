using FluentNHibernate.Mapping;
using DataEntry_Library.Entities; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_Library.Mapping
{
    public class FormacionAcademicaMap : ClassMap<FormacionAcademica>
    {
        public FormacionAcademicaMap()
        {
            Id(c => c.Id);
            Map(c => c.Grado);
            Map(c => c.Institucion);
            Map(c => c.NivelAlcanzado);
            Map(c => c.Concluida);
            Map(c => c.FechaOptaNivel);
        }
    }
}
