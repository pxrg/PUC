using NHibernate.Mapping.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TI_Lab_2015.Model
{
    [Serializable]
    [Class(Table="enderecos")]
    public partial class Endereco
    {
        [Id(0, Name="Id",Column = "id")]
        [Generator(1, Class = "native")]
        public virtual Int16 Id { get; set; }
        [Property(Column = "logradouro")]
        public virtual String Logradouro { get; set; }
        [Property(Column = "numero", Length = 10)]
        public virtual String Numero { get; set; }
        [Property(Column = "bairro", Length = 50)]
        public virtual String Bairro { get; set; }
        [Property(Column = "cep", Length = 10)]
        public virtual String Cep { get; set; }
        [Property(Column = "complemento")]
        public virtual String Complemento { get; set; }
        [Property(Column = "cidade", Length = 50)]
        public virtual String Cidade { get; set; }
        [Property(Column = "estado", Length = 30)]
        public virtual String Estado { get; set; }
    }
}