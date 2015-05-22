using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using TI_Lab_2015.Model;
using TI_Lab_2015.Persistence;

namespace TI_Lab_2015.Utils
{
    public class PageUtil
    {
        public static void exibirAlert(System.Web.UI.Page page, String msg)
        {
            page.ClientScript.RegisterStartupScript(page.GetType(), "myalert", "alert('" + msg + "');", true);
        }

        public static float formatParse(String value)
        {
            return float.Parse(value.Replace(".", "").Replace(",", "."));
        }

        public static void limparParametrosGet(System.Web.UI.Page page)
        {
            page.Response.Redirect(page.Request.CurrentExecutionFilePath);
        }

        public static void CarregarCondominios(DropDownList ddl, String itemDefault)
        {
            IList<Condominio> pessoas = NHibernateDAO.findAll<Condominio>("nome");
            ddl.DataSource = pessoas;
            ddl.DataTextField = "nome";
            ddl.DataValueField = "id";
            ddl.DataBind();
            if (itemDefault != null)
            {
                ddl.Items.Insert(0, new ListItem(itemDefault, " "));   
            }
        }
    }
}