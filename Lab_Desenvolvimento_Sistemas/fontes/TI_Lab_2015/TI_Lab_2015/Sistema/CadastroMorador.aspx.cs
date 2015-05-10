using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TI_Lab_2015.Model;
using TI_Lab_2015.Persistence;
using TI_Lab_2015.Utils;

namespace TI_Lab_2015.Sistema
{
    public partial class CadastroMorador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtSenha.Text.Equals(txtConfirmeSenha.Text))
                {
                    PageUtil.exibirAlert(this, "A confirmação de senha não confere!");
                    return;
                }
                this.salvarMorador();
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

        private void salvarMorador()
        {
            Morador morador = new Morador();
            if (hdfId.Value != null && hdfId.Value != String.Empty)
            {
                morador.Id = Int16.Parse(hdfId.Value);
                morador.Inclusao = DateTime.Parse(hdfInclusao.Value);
            }
            else
            {
                morador.Inclusao = DateTime.Now;
            }
            morador.Nome = txtNome.Text;
            morador.Cpf = Regex.Replace(txtCpf.Text, "[^\\d]", "");
            morador.Nascimento = DateTime.Parse(txtNascimento.Text);
            morador.Sexo = char.Parse(ddlSexo.SelectedValue);
            morador.Telefone = txtTelefone.Text;
            morador.Usuario = txtUsuario.Text;
            morador.Senha = txtSenha.Text;
            NHibernateDAO.save(morador);
            hdfId.Value = morador.Id.ToString();
            hdfInclusao.Value = morador.Inclusao.ToString();
        }

        private void carregarMorador(Morador morador)
        {
            hdfId.Value = morador.Id.ToString();
            hdfInclusao.Value = morador.Inclusao.ToString();

            txtNome.Text = morador.Nome;
            txtCpf.Text = morador.Cpf;
            txtNascimento.Text = morador.Nascimento.ToString();
            ddlSexo.SelectedValue = morador.Sexo.ToString();
            txtTelefone.Text = morador.Telefone;
            txtUsuario.Text = morador.Usuario;
            txtSenha.Text = morador.Senha;
        }
    }


}