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
    public partial class RegistroDespesa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                carregarCondominios();
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                this.salvarDespesa();
                PageUtil.exibirAlert(this, "Registro salvo com sucesso!");
            }
            catch (Exception ex)
            {
                PageUtil.exibirAlert(this, "Erro ao salvar: " + ex.Message);
            }
        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {

        }

        public void salvarDespesa()
        {
            Despesa despesa = new Despesa();
            if (hdfId.Value != null && hdfId.Value != String.Empty)
            {
                despesa.Id = Int16.Parse(hdfId.Value);
            }
            despesa.Descricao = txtTitulo.Text;
            despesa.Tipo = txtTipo.Text;
            despesa.Valor = float.Parse(txtValor.Text);
            despesa.DataRealizacao = DateTime.Parse(txtDataRealizacao.Text);
            despesa.Vencimento = DateTime.Parse(txtVencimento.Text);
            despesa.Juros = float.Parse(txtJuros.Text);
            despesa.Condominio = new Condominio(Int16.Parse(ddlCondominio.SelectedValue));
            NHibernateDAO.save(despesa);
            hdfId.Value = despesa.Id.ToString();
        }


        private void carregarCondominios()
        {
            IList<Condominio> pessoas = NHibernateDAO.findAll<Condominio>("nome");
            ddlCondominio.DataSource = pessoas;
            ddlCondominio.DataTextField = "nome";
            ddlCondominio.DataValueField = "id";
            ddlCondominio.DataBind();
            ddlCondominio.Items.Insert(0, new ListItem(" Selecione ", "0"));
        }
    }
}