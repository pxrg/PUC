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
    public partial class RegistroReceita : System.Web.UI.Page
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
                this.salvarReceita();
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
            //carregarCondominios();
            PageUtil.limparParametrosGet(this);
        }

        public void salvarReceita()
        {
            Receita receita = new Receita();
            if (hdfId.Value != null && hdfId.Value != String.Empty)
            {
                receita.Id = Int16.Parse(hdfId.Value);
            }
            receita.Descricao = txtTitulo.Text;
            receita.Tipo = txtTipo.Text;
            receita.Valor = float.Parse(txtValor.Text);
            receita.DataRealizacao = DateTime.Parse(txtDataRealizacao.Text);
            receita.Condominio = new Condominio(Int16.Parse(ddlCondominio.SelectedValue));
            NHibernateDAO.save(receita);
            hdfId.Value = receita.Id.ToString();
        }

        private void carregarObj(Int16 id)
        {
            Receita receita = NHibernateDAO.findById<Receita>(id);
            if (receita == null)
            {
                return;
            }
            hdfId.Value = receita.Id.ToString();
            txtTitulo.Text = receita.Descricao;
            txtTipo.Text = receita.Tipo;
            txtValor.Text = receita.Valor.ToString("C");
            txtDataRealizacao.Text = receita.DataRealizacao.ToString("yyyy-MM-dd");
            ddlCondominio.SelectedValue = receita.Condominio.Id.ToString();
        }

        private void carregarCondominios()
        {
            PageUtil.CarregarCondominios(ddlCondominio, " Selecione ");
        }
    }
}