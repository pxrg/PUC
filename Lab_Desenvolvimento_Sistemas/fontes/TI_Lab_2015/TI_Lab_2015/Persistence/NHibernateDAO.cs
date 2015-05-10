using NHibernate;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
                    StringBuilder hql = new StringBuilder("From ").Append(typeof(T).Name);
                    if (orderField != null && orderField.Trim() != String.Empty)
                    {
                        hql.Append(" order by ").Append(orderField.Trim());
                    }
                    IQuery query = session.CreateQuery(hql.ToString());
                    result = query.List<T>();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }

            }
            return result;
        }

        public static T findById<T>(Int16 id)
        {
            T result;
            using (ISession session = SessionFactory.OpenSession())
            {
                try
                {
                    StringBuilder hql = new StringBuilder("From ").Append(typeof(T).Name);
                    hql.Append("where id = :value_id");
                    IQuery query = session.CreateQuery(hql.ToString());
                    query.SetParameter("value_id", id);
                    result = (T)query.UniqueResult();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }

            }
            return result;
        }
    

        public static IList<T> find<T>(Dictionary<String, Object> conditions)
        {
            IList<T> result = null;
            using (ISession session = SessionFactory.OpenSession())
            {
                try
                {
                    StringBuilder hql = new StringBuilder("From ").Append(typeof(T).Name);
                    hql.Append(" obj ");
                    if (conditions != null && conditions.Count > 0)
                    {
                        hql.Append(" where ");
                        int count = 0, last = conditions.Count - 1;
                        foreach (KeyValuePair<string, Object> pair in conditions)
                        {
                            hql.Append(" obj.");
                            hql.Append(pair.Key);
                            hql.Append(" = :");
                            hql.Append(pair.Key.ToLower().Replace(".", "_"));
                            if (count < last)
                            {
                                hql.Append(" and ");
                            }
                            count++;
                        }
                    }
                    IQuery query = session.CreateQuery(hql.ToString());
                    if (conditions != null && conditions.Count > 0)
                    {
                        foreach (KeyValuePair<string, Object> pair in conditions)
                        {
                            String key = pair.Key.ToLower().Replace(".", "_");
                            query.SetParameter(key, pair.Value);
                        }
                    }
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