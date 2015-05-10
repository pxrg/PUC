using NHibernate.Mapping.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TI_Lab_2015.Model
{
    [Serializable]
    [Class(Table = "imoveis")]
    public partial class Imovel
    {
        public Imovel() { }
        public Imovel(Int16 id) { this.Id = id; }
        [Id(0, Name = "Id", Column = "id")]
        [Generator(1, Class = "native")]
        public virtual Int16 Id { get; set; }
        [Property(Column = "numero")]
        public virtual Int16 Numero { get; set; }
        [Property(Column = "vagas_garagem")]
        public virtual Int16 VagasGaragem { get; set; }
        [Property(Column = "area", Scale = 4, Precision = 2)]
        public virtual float Area { get; set; }
        [Property(Column = "bloco", Length = 50)]
        public virtual String Bloco { get; set; }

        [ManyToOne(Column = "morador_id", Lazy = Laziness.False)]
        public virtual Morador Morador { get; set; }
        [ManyToOne(Column = "condominio_id", Lazy = Laziness.Unspecified)]
        public virtual Condominio Condominio { get; set; }
    }
}