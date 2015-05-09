using NHibernate.Mapping.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TI_Lab_2015.Model
{
    [Serializable]
    [Class(Table="visitantes")]
    public partial class Visitante
    {
        [Id(0, Name="Id",Column = "id")]
        [Generator(1, Class = "native")]
        public virtual Int16 Id { get; set; }
        [Property(Column = "nome")]
        public virtual String Nome { get; set; }
        [Property(Column = "identificacao", Length = 50)]
        public virtual String Identificacao { get; set; }
        [Property(Column = "inclusao")]
        public virtual DateTime Inclusao { get; set; }
        [ManyToOne(Column="id_morador")]
        public virtual Morador Morador { get; set; }

    }
}