using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TI_Lab_2015.Utils;

namespace TI_Lab_2015.Model
{
    public partial class Condominio
    {
        public virtual bool existeCondominio(String nome)
        {
            bool result = false;
            using (ISession session = SessionFactory.OpenSession())
            {
                try
                {
                    String hql = "select count(*) From " + this.GetType().Name;
                        hql += " where nome = :valor_nome";
                    IQuery query = session.CreateQuery(hql);
                    query.SetString("valor_nome", nome.Trim());
                    result = ((int)query.UniqueResult()) > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }

            }
            return result;
        }
    }
}