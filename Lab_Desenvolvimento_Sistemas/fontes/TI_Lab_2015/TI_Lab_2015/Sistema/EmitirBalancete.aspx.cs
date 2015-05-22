using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TI_Lab_2015.Model;
using TI_Lab_2015.Persistence;
using TI_Lab_2015.Utils;

namespace TI_Lab_2015.Sistema
{
    public partial class EmitirBalancete : System.Web.UI.Page
    {
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

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        protected void btnExportar_Click(object sender, EventArgs e)
        {

        }

        private void pesquisar()
        {
            Int16 idCond = Int16.Parse(ddlCondominio.SelectedValue);
            DateTime? inicio = null, fim = null;
            if(!String.IsNullOrEmpty(txtDataIni.Text))
            {
                inicio = DateTime.Parse(txtDataIni.Text);
            }
            if (!String.IsNullOrEmpty(txtDataFim.Text))
            {
                fim = DateTime.Parse(txtDataFim.Text);
            }
            IList<Despesa> despesas = Despesa.consultarParaBalancete(idCond, inicio, fim);
            rptDespesas.DataSource = despesas;
            rptDespesas.DataBind();

            IList<Receita> receitas = Receita.consultarParaBalancete(idCond, inicio, fim);
            rptReceitas.DataSource = receitas;
            rptReceitas.DataBind();
        }

        private void limparCampos()
        {
            PageUtil.limparParametrosGet(this);
        }

        private void carregarCondominios()
        {
            PageUtil.CarregarCondominios(ddlCondominio, null);
        }
    }
}