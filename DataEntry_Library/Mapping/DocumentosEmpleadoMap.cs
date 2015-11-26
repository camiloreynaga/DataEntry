using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataEntry_Library.Entities;

namespace DataEntry_Library.Mapping
{
    public class DocumentosEmpleadoMap : ClassMap<DocumentosEmpleado>
    {
        public DocumentosEmpleadoMap()
        {
            Id(c => c.Id);
            References(c => c.ambitoSeccion);
            References(c => c.tipoDocumento);
            Map(c => c.RegimenLaboral);
            Map(c => c.SiNo);
            Map(c => c.NumeroTramite);
            Map(c => c.NumeroDocumento);
            Map(c => c.FechaDocumento);
            Map(c => c.OrigenDocumento);
            Map(c => c.DestinoDocumento);
            Map(c => c.Denominacion);
            Map(c => c.Cargo);
            Map(c => c.Departamento);
            Map(c => c.DepartamentoOrigen);
            Map(c => c.DepartamentoDestino);
            Map(c => c.PeriodoDias);
            Map(c => c.PeriodoMeses);
            Map(c => c.PeriodoAnios);
            Map(c => c.FechaInicio);
            Map(c => c.FechaTermino);
            Map(c => c.ImportePorcentaje);
            Map(c => c.PsAdjudicacion);
            Map(c => c.PsTipo);
            Map(c => c.PlazaNumero);
            Map(c => c.PlazaVacante);
            Map(c => c.ComisionCargo);
            Map(c => c.ComisionDescripcion);
            Map(c => c.MeritoMotivo);
            Map(c => c.DemeritoMotivo);
            Map(c => c.DemeritoPeriodo);
            Map(c => c.EvaluacionResultados);
            Map(c => c.Nota1);
            Map(c => c.Nota2);
            Map(c => c.Observacion1);
            Map(c => c.Observacion2);
        }
    }
}
