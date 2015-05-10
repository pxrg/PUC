using NHibernate.Mapping.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TI_Lab_2015.Model
{
    [Serializable]
    [Class(Table="leituras_consumos")]
    public partial class LeituraConsumo
    {
        [Id(0, Name="Id",Column = "id")]
        [Generator(1, Class = "native")]
        public virtual Int16 Id { get; set; }
        [Property(Column = "data_referencia")]
        public virtual DateTime DataReferencia { get; set; }
        [Property(Column = "valor_agua", Scale = 5, Precision = 2)]
        public virtual float ValorAgua { get; set; }
        [Property(Column = "valor_gas", Scale = 5, Precision = 2)]
        public virtual float ValorGas { get; set; }
        [Property(Column = "valor_energia", Scale = 5, Precision = 2)]
        public virtual float ValorEnergia { get; set; }

        [Property(Column = "pagamento_agua", NotNull=false)]
        public virtual DateTime? PagamentoAgua { get; set; }
        [Property(Column = "pagamento_energia", NotNull = false)]
        public virtual DateTime? PagamentoEnergia{ get; set; }
        [Property(Column = "pagamento_gas", NotNull=false)]
        public virtual DateTime? PagamentoGas { get; set; }

        [ManyToOne(Column = "imovel", Lazy=Laziness.False)]
        public virtual Imovel Imovel { get; set; }
        
    }
}