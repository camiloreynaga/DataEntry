using FluentNHibernate.Mapping;
using DataEntry_Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_Library.Mapping
{
    public class ParienteMap: SubclassMap<Pariente>
    {
        public ParienteMap()
        {
            References(c => c.Tipo);
            Map(c => c.trabajaEssalud);
        }
    }
}
