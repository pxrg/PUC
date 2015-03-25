using NHibernate.Mapping.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TI_Lab_2015.Model
{
    [Serializable]
    [Class(Table = "patrimonios")]
    public class Patrimonio
    {
        [Id(0, Column = "id")]
        [Generator(1, Class = "native")]
        public virtual Int16 Id { get; set; }
        [Property(Column = "descricao")]
        public virtual String Descricao { get; set; }
        [Property(Column = "valor", Scale = 5, Precision = 2)]
        public virtual float Valor { get; set; }
        [Property(Column = "aquisicao")]
        public virtual DateTime aquisicao { get; set; }
        [ManyToOne(Column = "id_condominio")]
        public virtual Condominio Condominio { get; set; }
    }
}