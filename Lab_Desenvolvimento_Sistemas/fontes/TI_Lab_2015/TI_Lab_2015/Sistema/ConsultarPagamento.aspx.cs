using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TI_Lab_2015.Model;
using TI_Lab_2015.Persistence;

namespace TI_Lab_2015.Sistema
{
    public partial class ConsultarPagamento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                carregarCondominios();
            }
        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        protected void btnPesquisar_Click(object sender, EventArgs e)
        {
            pesquisar();
        }

        private void limparCampos()
        {
            carregarCondominios();
            txtData.Text = String.Empty;
            txtVencimento.Text = String.Empty;
            ddlSituacao.ClearSelection();
        }

        private void pesquisar()
        {
            Dictionary<String, Object[]> dict = new Dictionary<string, object[]>();
            if (ddlCondominio.SelectedIndex > 0)
            {
                dict.Add("Condominio.Id", NHibernateDAO.getParam("=", Int16.Parse(ddlCondominio.SelectedValue)));
            }
            if (!String.IsNullOrEmpty(txtData.Text))
            {
                dict.Add("DataRealizacao", NHibernateDAO.getParam("=", DateTime.Parse(txtData.Text)));
            }
            if (!String.IsNullOrEmpty(txtVencimento.Text))
            {
                dict.Add("Vencimento", NHibernateDAO.getParam("=", DateTime.Parse(txtVencimento.Text)));
            }
            if (ddlSituacao.SelectedIndex > 0)
            {
                if (ddlSituacao.SelectedValue.Equals("p"))
                {
                    dict.Add("DataQuitacao", NHibernateDAO.getParam("is not null", null));
                }
                else
                {
                    String operador = "=";
                    switch (ddlSituacao.SelectedValue)
                    {
                        case "a":
                            operador = ">";
                            break;
                        case "v":
                            operador = "<";
                            break;
                        default:
                            break;
                    }
                    dict.Add("Vencimento", NHibernateDAO.getParam(operador, DateTime.Now));
                }
            }
            IList<Despesa> despesas = NHibernateDAO.find<Despesa>(dict);
            rptDespesas.DataSource = despesas;
            rptDespesas.DataBind();
        }

        private void carregarCondominios()
        {
            IList<Condominio> pessoas = NHibernateDAO.findAll<Condominio>("nome");
            ddlCondominio.DataSource = pessoas;
            ddlCondominio.DataTextField = "nome";
            ddlCondominio.DataValueField = "id";
            ddlCondominio.DataBind();
            ddlCondominio.Items.Insert(0, new ListItem(" Todos ", "0"));
        }


    }
}