﻿using NHibernate.Mapping.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TI_Lab_2015.Model
{
    [Serializable]
    [JoinedSubclass(Table = "moradores")]
    public class Morador:Pessoa
    {
        [Property(Column = "tipo_morador")]
        public virtual String TipoMorador { get; set; }
    }
}