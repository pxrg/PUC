using NHibernate.Mapping.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TI_Lab_2015.Model
{
    [Serializable]
    [Class(Table="reservas")]
    public class Reserva
    {
        [Id(0, Column = "id")]
        [Generator(1, Class = "native")]
        public virtual Int16 Id { get; set; }
        [Property(Column = "pago", Type = "TrueFalse")]
        public virtual Boolean pago { get; set; }
        [Property(Column = "reservado", Type = "TrueFalse")]
        public virtual Boolean reservado { get; set; }
        [Property(Column = "data_realizacao")]
        public virtual DateTime DataInclusao { get; set; }
        [Property(Column = "data_realizacao")]
        public virtual DateTime DataRealizacao { get; set; }
        [Property(Column = "data_vencimento")]
        public virtual DateTime DataVencimento { get; set; }

        [ManyToOne(Column = "id_morador")]
        public virtual Morador Morador { get; set; }
        [ManyToOne(Column = "id_espaco_cond")]
        public virtual EspacoCondominio espaco { get; set; }
    }
}