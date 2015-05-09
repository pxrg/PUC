using NHibernate.Mapping.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TI_Lab_2015.Model
{
    [Serializable]
    [Class(Table = "noticias")]
    public partial class Noticia
    {
        [Id(0, Name="Id",Column = "id")]
        [Generator(1, Class = "native")]
        public virtual Int16 Id { get; set; }
        [Property(Column = "titulo")]
        public virtual String Titulo { get; set; }
        
        [Property(0, Column = "conteudo",Name="Conteudo" , Type = "StringClob")]
        [Column(1, SqlType = "ntext", Name = "Conteudo")]
        public virtual String Conteudo { get; set; }
        [Property(Column = "inclusao")]
        public virtual DateTime Inclusao { get; set; }
        [ManyToOne(Column="id_condominio", NotNull=true)]
        public virtual Condominio Condominio{ get; set; }

    }
}