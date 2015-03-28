using NHibernate.Mapping.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TI_Lab_2015.Model
{
    [Serializable]
    [Class(Abstract = true)]
    public abstract class Pessoa
    {
        [Id(0, Name = "Id", Column = "id")]
        [Generator(1, Class = "hilo")]
        public virtual Int16 Id { get; set; }
        [Property(Column = "nome", Length = 150)]
        public virtual String Nome { get; set; }
        [Property(Column = "cpf", Length = 11)]
        public virtual String Cpf { get; set; }
        [Property(Column = "nascimento")]
        public virtual DateTime Nascimento { get; set; }
        [Property(Column = "sexo", Length = 1)]
        public virtual char Sexo { get; set; }
        [Property(Column = "telefone", Length = 50)]
        public virtual String Telefone { get; set; }
        [Property(Column = "usuario", Length = 50)]
        public virtual String Usuario { get; set; }
        [Property(Column = "senha", Length = 10)]
        public virtual String Senha { get; set; }
        [Property(Column = "inclusao")]
        public virtual DateTime Inclusao { get; set; }
        [Property(Column = "foto")]
        public virtual String Foto { get; set; }
    }
}