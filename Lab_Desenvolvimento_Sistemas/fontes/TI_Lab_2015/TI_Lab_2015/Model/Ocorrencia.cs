using NHibernate.Mapping.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TI_Lab_2015.Model
{
    [Serializable]
    [Class(Table = "visitantes")]
    public class Ocorrencia
    {
        [Id(0, Column = "id")]
        [Generator(1, Class = "native")]
        public virtual Int16 Id { get; set; }
        [Property(Column = "conteudo")]
        public virtual String Conteudo { get; set; }
        [Property(Column = "inclusao")]
        public virtual DateTime Inclusao { get; set; }
        [Property(Column = "ocorrencia")]
        public virtual DateTime ocorrencia { get; set; }
        [ManyToOne(Column = "id_morador")]
        public virtual Morador Morador { get; set; }
    }
}