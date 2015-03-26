using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
            SchemaUpdate update = new SchemaUpdate(cfg);
            update.Execute(true, true);

        }
    }
}