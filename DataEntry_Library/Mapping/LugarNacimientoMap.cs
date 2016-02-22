using FluentNHibernate.Mapping;
using DataEntry_Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_Library.Mapping
{
    public class LugarNacimientoMap : ComponentMap<LugarNacimiento>
    {
        public LugarNacimientoMap()
        {
            
            //Table("lugar_nacimiento");
            //Id(c => c.Id);
            References(c => c.Pais);
            References(c => c.Region);
            References(c => c.Provincia);
            References(c => c.Distrito);
            //References(c => c.persona);

        }
    }
}
