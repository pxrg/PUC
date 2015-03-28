using NHibernate.Cfg;
using NHibernate.Mapping.Attributes;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TI_Lab_2015.Model;

namespace TI_Lab_2015
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Configuration cfg = new Configuration();
            cfg = cfg.Configure();
            String path = @"C:\Users\PRX\Documents\GitHub\PUC\Lab_Desenvolvimento_Sistemas\fontes\TI_Lab_2015\TI_Lab_2015\App_Data";
            HbmSerializer.Default.Validate = true;
            HbmSerializer.Default.Serialize(path, Assembly.GetExecutingAssembly());
            cfg.AddDirectory(new DirectoryInfo(path));    
            //cfg.AddDirectory(new DirectoryInfo());
            SchemaUpdate update = new SchemaUpdate(cfg);
            update.Execute(true, true);

        }
    }
}