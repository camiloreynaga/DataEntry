using FluentNHibernate.Mapping;
using DataEntry_Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_Library.Mapping
{
    public class OfimaticaMap : ClassMap<Ofimatica>
    {
        public OfimaticaMap()
        {
            Id(c => c.Id);
            References(c => c.software);
            Map(c => c.Nivel);
            //Map(c => c.Activo);
        }
    }
}
