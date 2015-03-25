using NHibernate.Mapping.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TI_Lab_2015.Model
{
    [Serializable]
    [Class(Table = "receitas")]
    public class Despesa
    {
        [Id(0, Column = "id")]
        [Generator(1, Class = "native")]
        public virtual Int16 Id { get; set; }
        [Property(Column = "descricao")]
        public virtual String Descricao { get; set; }
        [Property(Column = "tipo", Length = 50)]
        public virtual String Tipo { get; set; }
        [Property(Column = "valor", Scale = 5, Precision = 2)]
        public virtual float Valor { get; set; }
        [Property(Column = "data_realizacao")]
        public virtual DateTime DataRealizacao { get; set; }
        [Property(Column = "vencimento")]
        public virtual DateTime Vencimento { get; set; }
        [Property(Column = "juros", Scale = 5, Precision = 2)]
        public virtual float Juros { get; set; }
        [ManyToOne(Column = "id_condominio")]
        public virtual Condominio Condominio { get; set; }
    }
}