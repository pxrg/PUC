using NHibernate;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TI_Lab_2015.Utils;

namespace TI_Lab_2015.Persistence
{
    public class NHibernateDAO
    {
        /// <summary>
        /// Salva o objeto passado como parametro ja preenchendo o id
        /// do objeto persistido
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
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

        /// <summary>
        /// Retorna todos os objetos do tipo T
        /// Caso seja informado o parametro orderField, os registros
        /// serao ordenados pelo mesmo, parametro pode ser null
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="orderField"></param>
        /// <returns></returns>
        public static IList<T> findAll<T>(String orderField)
        {
            IList<T> result = null;
            using (ISession session = SessionFactory.OpenSession())
            {
                try
                {
                    String hql = "From " + typeof(T).Name;
                    if (orderField != null && orderField.Trim() != String.Empty)
                    {
                        hql += " order by " + orderField.Trim();
                    }
                    IQuery query = session.CreateQuery(hql);
                    result = query.List<T>();
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