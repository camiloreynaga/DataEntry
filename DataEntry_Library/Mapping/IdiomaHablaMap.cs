using FluentNHibernate.Mapping;
using DataEntry_Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_Library.Mapping
{
    public class IdiomaHablaMap : ClassMap<IdiomaHabla>
    {
        public IdiomaHablaMap()
        {
            Id(c => c.Id);
            References(c => c.idioma);
            Map(c => c.Nivel);
        }
    }
}
