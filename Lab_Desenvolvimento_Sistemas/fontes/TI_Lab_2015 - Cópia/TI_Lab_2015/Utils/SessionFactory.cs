using NHibernate;
using NHibernate.Cfg;
using NHibernate.Mapping.Attributes;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;

namespace TI_Lab_2015.Utils
{
    public class SessionFactory
    {
        private static volatile ISessionFactory iSessionFactory;

        private static object syncRoot = new Object();
        private static bool updateDB = false;


        public static ISession OpenSession()
        {
            if (iSessionFactory == null)
            {

                Configuration cfg = new Configuration();
                cfg = cfg.Configure();
                //String path = @"C:\Users\PRX\Documents\GitHub\PUC\Lab_Desenvolvimento_Sistemas\fontes\TI_Lab_2015\TI_Lab_2015\App_Data";
                String path = HttpContext.Current.Server.MapPath(@"~\App_Data");
                HbmSerializer.Default.Validate = true;
                HbmSerializer.Default.Serialize(path, Assembly.GetExecutingAssembly());
                cfg.AddDirectory(new DirectoryInfo(path));
                if (updateDB)
                {
                    SchemaUpdate update = new SchemaUpdate(cfg);
                    update.Execute(true, true);
                }
                iSessionFactory = cfg.BuildSessionFactory();

            }
            return iSessionFactory.OpenSession();



        }
    }
}