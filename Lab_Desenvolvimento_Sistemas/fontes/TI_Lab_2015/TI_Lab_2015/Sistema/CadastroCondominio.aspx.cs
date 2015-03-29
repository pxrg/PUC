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
    public partial class CadastroCondominio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            this.limparTela();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                this.salvarCondominio();
                PageUtil.exibirAlert(this, "Registro salvo com sucesso!");
            }
            catch (Exception ex)
            {
                PageUtil.exibirAlert(this, "Erro ao salvar: "+ex.Message);
            }
        }


        private void limparTela()
        {
            // Dados Condominio
            txtNome.Text = String.Empty;
            hdfId.Value = String.Empty;

            // Dados Endereco
            txtLogradouro.Text = String.Empty;
            txtNumero.Text = String.Empty;
            txtCep.Text = String.Empty;
            txtComplemento.Text = String.Empty;
            txtBairro.Text = String.Empty;
            txtCidade.Text = String.Empty;
            txtEstado.Text = String.Empty;
            hdfIdEndereco.Value = String.Empty;

        }

        private void salvarCondominio()
        {
            // Preenchendo o endereco
            Endereco end = new Endereco();
            if (hdfIdEndereco.Value != null && hdfIdEndereco.Value != String.Empty)
            {
                end.Id = Int16.Parse(hdfIdEndereco.Value);
            }
            end.Logradouro = txtLogradouro.Text;
            end.Numero = txtNumero.Text;
            end.Cep = txtCep.Text;
            end.Complemento = txtComplemento.Text;
            end.Bairro = txtBairro.Text;
            end.Cidade = txtCidade.Text;
            end.Estado = txtEstado.Text;
            NHibernateDAO.save(end);
            hdfIdEndereco.Value = end.Id.ToString();
            //end

            // Preenchendo Condominio
            Condominio cond = new Condominio();
            if (hdfId.Value != null && hdfId.Value != String.Empty)
            {
                cond.Id = Int16.Parse(hdfId.Value);
            }
            cond.Endereco = end;
            cond.Nome = txtNome.Text;
            NHibernateDAO.save(cond);
            hdfId.Value = cond.Id.ToString();
        }
    }
}