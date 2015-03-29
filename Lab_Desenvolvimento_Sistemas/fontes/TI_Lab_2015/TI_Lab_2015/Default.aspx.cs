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
using TI_Lab_2015.Persistence;

namespace TI_Lab_2015
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            carregarNoticias();
        }


        private void carregarNoticias()
        {
            IList<Noticia> noticias = NHibernateDAO.findAll<Noticia>("inclusao desc");
            if (noticias != null)
            {
                rptNoticias.DataSource = noticias;
                rptNoticias.DataBind();
            }
            else
            {
                lblSemNoticias.Text = "Nenhuma noticia cadastrada.";
            }
        }
    }
}