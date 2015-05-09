using NHibernate.Mapping.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TI_Lab_2015.Model
{
    [Serializable]
    //[JoinedSubclass(Table = "moradores", Extends = "Pessoa")]
    [UnionSubclass(Table = "moradores", Extends = "TI_Lab_2015.Model.Pessoa")]
    public partial class Morador : Pessoa
    {
        public Morador() { }
        public Morador(Int16 id)
        {
            this.Id = id;
        }
        [Property(Column = "tipo_morador")]
        public virtual String TipoMorador { get; set; }
    }
}