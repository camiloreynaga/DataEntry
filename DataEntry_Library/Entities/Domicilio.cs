using DataEntry_Library.Entities.Tablas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataEntry_Library.Entities
{
    public class Domicilio
    {
        public virtual int Id { get; set; }

        public virtual UbigeoRegion Region { get; set; }
        public virtual UbigeoProvincia Provincia { get; set; }
        public virtual UbigeoDistrito Distrito { get; set; }

        /// <summary>
        /// tipo de via por default Otros (id=21)
        /// </summary>
        public virtual Via TipoVia { get; set; }
        public virtual string NombreVia { get; set; }
        public virtual string NumeroVia { get; set; }
        public virtual string Departamento { get; set; }
        public virtual string Interior { get; set; }
        public virtual string Manzana { get; set; }
        public virtual string Lote { get; set; }
        public virtual string Kilometro { get; set; }
        public virtual string Block { get; set; }
        public virtual string Etapa { get; set; }
        
        /// <summary>
        /// tipo de zona por default Otros (id=12)
        /// </summary>
        //public virtual Zona TipoZona { get; set; }
        //public virtual string NombreZona { get; set; }
        public virtual string Referencia { get; set; }
    }
}
