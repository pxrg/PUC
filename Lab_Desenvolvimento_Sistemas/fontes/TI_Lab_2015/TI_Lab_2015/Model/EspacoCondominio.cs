using NHibernate.Mapping.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TI_Lab_2015.Model
{
    [Serializable]
    [Class(Table = "espacos_condominio")]
    public partial class EspacoCondominio
    {
        [Id(0, Name="Id",Column = "id")]
        [Generator(1, Class = "native")]
        public virtual Int16 Id { get; set; }
        [Property(Column = "nome")]
        public virtual String Nome { get; set; }
        [Property(Column = "descricao")]
        public virtual String Descricao { get; set; }
        [Property(Column = "capacidade")]
        public virtual Int16 Capacidade { get; set; }
        [Property(Column = "horario_funcionamento", Length = 50)]
        public virtual String HorarioFuncionamento { get; set; }
        [Property(Column = "custo", Scale = 5, Precision = 2)]
        public virtual float Custo { get; set; }
        [ManyToOne(Column = "id_condominio")]
        public virtual Condominio Condominio { get; set; }
    }
}