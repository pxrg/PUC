using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TI_Lab_2015.Model;
using TI_Lab_2015.Persistence;
using TI_Lab_2015.Utils;

namespace TI_Lab_2015.Sistema
{
    public partial class ConsultarSaldoDevedor : System.Web.UI.Page
    {
        IList<Despesa> despesas;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                carregarCondominios();
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            pesquisar();
        }

        protected void btnExportar_Click(object sender, EventArgs e)
        {
            downloadListagem();
        }

        private void downloadListagem()
        {
            pesquisar();
            if (despesas == null || despesas.Count <= 0)
            {
                PageUtil.exibirAlert(this, "Não é possivel exportar uma relatorio vazio!");
                return;
            }
            StringBuilder builder = new StringBuilder();
            builder.Append("Condominio;Descrição;Valor;Vencimento;Data realizado;Status\n");
            foreach (Despesa despesa in despesas)
            {
                builder.Append(despesa.Condominio.Nome);
                builder.Append(";");
                builder.Append(despesa.Descricao);
                builder.Append(";");
                builder.Append(despesa.Valor.ToString("C"));
                builder.Append(";");
                builder.Append(despesa.Vencimento.ToShortDateString());
                builder.Append(";");
                builder.Append(despesa.DataRealizacao.ToShortDateString());
                builder.Append(";");
                builder.Append(despesa.retornarSituacao());
                builder.Append("\n");
            }
            Response.AddHeader("Content-Type", "text/plain; charset=ISO-8859-1");
            Response.AddHeader("Content-Transfer-Encoding", "Binary");
            Response.AddHeader("Content-disposition", @"attachment; filename=saldo_devedor.csv");
            Response.Write(builder.ToString());
            Response.End();
        }

        private void pesquisar()
        {
            Dictionary<String, Object[]> dict = new Dictionary<string, object[]>();
            if (ddlCondominio.SelectedIndex > 0)
            {
                dict.Add("Condominio.Id", NHibernateDAO.getParam("=", Int16.Parse(ddlCondominio.SelectedValue)));
            }
            if (!String.IsNullOrEmpty(txtDataIni.Text))
            {
                dict.Add("Vencimento", NHibernateDAO.getParam(">", DateTime.Parse(txtDataIni.Text)));
            }
            if (!String.IsNullOrEmpty(txtDataFim.Text))
            {
                dict.Add("Vencimento", NHibernateDAO.getParam("<", DateTime.Parse(txtDataFim.Text)));
            }
            dict.Add("DataQuitacao", NHibernateDAO.getParam("is null", null));
            despesas = NHibernateDAO.find<Despesa>(dict);
            if (despesas == null || despesas.Count == 0)
            {
                //lbl
            }
            rptDespesas.DataSource = despesas;
            rptDespesas.DataBind();
        }

        private void carregarCondominios()
        {
            PageUtil.CarregarCondominios(ddlCondominio, " Todos ");
        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            PageUtil.limparParametrosGet(this);
        }
    }
}