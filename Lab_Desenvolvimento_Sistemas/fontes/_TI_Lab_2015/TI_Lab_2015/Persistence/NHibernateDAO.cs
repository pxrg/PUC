using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TI_Lab_2015.Utils;

namespace TI_Lab_2015.Persistence
{
    public class NHibernateDAO
    {
        public static void save<T>(T obj)
        {
            using (ISession session = SessionFactory.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    try
                    {
                        session.SaveOrUpdate(obj);
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception(ex.Message, ex);
                    }
                }
            }
        }
    }
}