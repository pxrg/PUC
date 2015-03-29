using NHibernate.Mapping.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TI_Lab_2015.Model
{
    [Serializable]
    [Class(Table = "condominios")]
    public class Condominio
    {
        [Id(0, Name = "Id", Column = "id")]
        [Generator(1, Class = "native")]
        public virtual Int16 Id { get; set; }
        [Property(Column = "nome")]
        public virtual String Nome { get; set; }

        [ManyToOne(Column = "endereco_id", Class = "Endereco", ClassType = typeof(Endereco))]
        public virtual Endereco Endereco { get; set; }

        public Condominio() { }
        public Condominio(Int16 id) { this.Id = id; }
    }
}