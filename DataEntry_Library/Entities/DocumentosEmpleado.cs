using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataEntry_Library.Entities.Tablas;

namespace DataEntry_Library.Entities
{
    public class DocumentosEmpleado
    {
        public virtual int Id { get; set; }
        public virtual AmbitoSeccion ambitoSeccion { get; set; }
        public virtual TipoDocumento tipoDocumento { get; set; }

        public virtual string RegimenLaboral { get; set; }
        public virtual string SiNo { get; set; }
        public virtual string NumeroTramite { get; set; }
        public virtual string NumeroDocumento { get; set; }
        public virtual string FechaDocumento { get; set; }
        public virtual string OrigenDocumento { get; set; }
        public virtual string DestinoDocumento { get; set; }
        public virtual string Denominacion { get; set; }
        public virtual string Cargo { get; set; }
        public virtual string Departamento { get; set; }
        public virtual string RegLabCont { get; set; }
        public virtual string DepartamentoOrigen { get; set; }
        public virtual string DepartamentoDestino { get; set; }
        public virtual string PeriodoDias { get; set; }
        public virtual string PeriodoMeses { get; set; }
        public virtual string PeriodoAnios { get; set; }
        public virtual string FechaInicio { get; set; }
        public virtual string FechaTermino { get; set; }
        public virtual string ImportePorcentaje { get; set; }
        public virtual string PsAdjudicacion { get; set; }
        public virtual string PsTipo { get; set; }
        public virtual string PlazaNumero { get; set; }
        public virtual string PlazaVacante { get; set; }
        public virtual string ComisionCargo { get; set; }
        public virtual string ComisionDescripcion { get; set; }
        public virtual string MeritoMotivo { get; set; }
        public virtual string DemeritoMotivo { get; set; }
        public virtual string DemeritoPeriodo { get; set; }
        public virtual string EvaluacionResultados { get; set; }
        public virtual string Nota1 { get; set; }
        public virtual string Nota2 { get; set; }
        public virtual string Observacion1 { get; set; }
        public virtual string Observacion2 { get; set; }
    }
}
