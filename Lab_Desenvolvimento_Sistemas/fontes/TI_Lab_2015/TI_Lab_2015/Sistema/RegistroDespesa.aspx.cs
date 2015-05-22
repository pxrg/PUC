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
                String id = Request.QueryString["id"];
                if (id != null)
                {
                    carregarObj(Int16.Parse(id));
                }
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
            limparCampos();
        }

        private void limparCampos()
        {
            hdfId.Value = String.Empty;
            txtTitulo.Text = String.Empty;
            txtTipo.Text = String.Empty;
            txtValor.Text = String.Empty;
            txtDataRealizacao.Text = String.Empty;
            txtVencimento.Text = String.Empty;
            txtJuros.Text = String.Empty;
            //carregarCondominios();
            PageUtil.limparParametrosGet(this);
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
            btnRateio.Visible = true;
        }

        private void carregarObj(Int16 id)
        {
            Despesa despesa = NHibernateDAO.findById<Despesa>(id);
            if (despesa == null)
            {
                return;
            }
            hdfId.Value = despesa.Id.ToString();
            txtTitulo.Text = despesa.Descricao;
            txtTipo.Text = despesa.Tipo;
            txtValor.Text = despesa.Valor.ToString("C");
            txtDataRealizacao.Text = despesa.DataRealizacao.ToString("yyyy-MM-dd");
            txtVencimento.Text = despesa.Vencimento.ToString("yyyy-MM-dd");
            txtJuros.Text = despesa.Juros.ToString();
            ddlCondominio.SelectedValue = despesa.Condominio.Id.ToString();
            btnRateio.Visible = true;
        }

        private void carregarCondominios()
        {
            PageUtil.CarregarCondominios(ddlCondominio, " Selecione ");
        }
    }
}