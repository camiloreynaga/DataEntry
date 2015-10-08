using FluentNHibernate.Mapping;
using DataEntry_Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_Library.Mapping
{
    public class IdiomaMap : ClassMap<Idioma>
    {
        public IdiomaMap()
        {
            Id(c => c.Id);
            Map(c => c.idioma);
           // Map(c => c.Nivel);
            Map(c => c.Activo)
                .Default("1");

        }
    }
}
