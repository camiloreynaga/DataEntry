using FluentNHibernate.Mapping;
using DataEntry_Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_Library.Mapping
{
    public class DatosLaboralesMap : ClassMap<DatosLaborales>
    {
        public DatosLaboralesMap()
        {
            Id(c => c.Id);
            References(c => c.CondicionLaboral);
            References(c => c.SituacionCargo);
            References(c => c.GrupoOcupacional);
            Map(c => c.Nivel);
            References(c => c.Cargo);
            Map(c => c.FechaIngreso);
            References(c => c.Dependencia);
            Map(c => c.RegimenPensiones);
            Map(c => c.Afp);
            Map(c => c.NroAfiliado);
            Map(c => c.Pension);
            Map(c => c.Concepto);
            Map(c => c.Funciones);

                
        }
    }
}
