using NHibernate.Mapping.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TI_Lab_2015.Model
{
    [Serializable]
    [Class(Table = "despesas_imoveis")]
    public partial class DespesaImovel
    {
        [Id(0, Name="Id",Column = "id")]
        [Generator(1, Class = "native")]
        public virtual Int16 Id { get; set; }
        [Property(Column = "pago", Type = "TrueFalse")]
        public virtual Boolean pago { get; set; }
        [Property(Column = "valor", Scale = 5, Precision = 2)]
        public virtual float Valor { get; set; }
        [Property(Column = "data_pagamento")]
        public virtual DateTime DataPagamento { get; set; }

        [ManyToOne(Column = "id_despesa")]
        public virtual Despesa Despesa { get; set; }
        [ManyToOne(Column = "id_imovel")]
        public virtual Imovel Imovel { get; set; }
    }
}