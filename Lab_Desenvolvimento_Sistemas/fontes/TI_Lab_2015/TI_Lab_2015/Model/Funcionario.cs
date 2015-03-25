using NHibernate.Mapping.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TI_Lab_2015.Model
{
    [JoinedSubclass(Table="funcionarios")]
    public class Funcionario:Pessoa
    {
        [Property(Column = "funcao")]
        public virtual String Funcao { get; set; }
        [Property(Column = "remuneracao")]
        public virtual float Remuneracao { get; set; }
        [Property(Column = "carga_horaria")]
        public virtual float CargaHoraria { get; set; }
        [Property(Column = "admissao")]
        public virtual DateTime Admissao { get; set; }
        [Property(Column = "demissao")]
        public virtual DateTime Demissao { get; set; }
        [Property(Column = "frequencia")]
        public virtual String frequencia { get; set; }
        [ManyToOne(Column="endereco_id", Cascade="delete")]
        public virtual Endereco endereco { get; set; }

    }
}