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
    public partial class CadastroVeiculo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                carregarPessoas();
            }
        }

        private void carregarPessoas()
        {
            IList<Pessoa> pessoas = NHibernateDAO.findAll<Pessoa>("nome");
            ddlProprietario.DataSource = pessoas;
            ddlProprietario.DataTextField = "nome";
            ddlProprietario.DataValueField = "id";
            ddlProprietario.DataBind();
            ddlProprietario.Items.Insert(0, new ListItem(" Selecione ", "0"));
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                this.salvarVeiculo();
                PageUtil.exibirAlert(this, "Registro salvo com sucesso!");
            }
            catch (Exception ex)
            {
                PageUtil.exibirAlert(this, "Erro ao salvar: " + ex.Message);
            }
        }

        private void salvarVeiculo()
        {
            Veiculo veiculo = new Veiculo();
            if (hdfId.Value != null && hdfId.Value != String.Empty)
            {
                veiculo.Id = Int16.Parse(hdfId.Value);
                veiculo.Inclusao = DateTime.Parse(hdfInclusao.Value);
            }
            else
            {
                veiculo.Inclusao = DateTime.Now;
            }
            veiculo.Placa = txtPlaca.Text;
            veiculo.Vaga = txtVaga.Text;
            veiculo.Morador = new Morador(Int16.Parse(ddlProprietario.SelectedValue));
            NHibernateDAO.save(veiculo);
            hdfId.Value = veiculo.Id.ToString();
            hdfInclusao.Value = veiculo.Inclusao.ToString();
        }


        private void carregarVeiculo(Veiculo veiculo)
        {
            hdfId.Value = veiculo.Id.ToString();
            hdfInclusao.Value = veiculo.Inclusao.ToString();
            txtPlaca.Text = veiculo.Placa;
            txtVaga.Text = veiculo.Vaga;
            ddlProprietario.SelectedValue = veiculo.Morador.Id.ToString();
        }
    }
}