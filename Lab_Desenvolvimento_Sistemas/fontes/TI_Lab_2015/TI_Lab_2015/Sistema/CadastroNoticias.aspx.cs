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
    public partial class CadastroNoticias : System.Web.UI.Page
    {
        private IList<Condominio> condominios;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                carregarListaCondominios();
            }
            catch (Exception ex)
            {
                PageUtil.exibirAlert(this, ex.Message);
            }
        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            
            this.limparNoticia();
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                this.salvarNoticia();
                PageUtil.exibirAlert(this, "Noticia salva com sucesso");
            }
            catch (Exception ex)
            {
                PageUtil.exibirAlert(this, "Erro ao salvar: "+ex.Message);
            }
        }

        private void carregarListaCondominios()
        {
            condominios = NHibernateDAO.findAll<Condominio>("nome");
            if (condominios != null)
            {
                ddlCondominio.DataSource = condominios;
                ddlCondominio.DataTextField = "nome";
                ddlCondominio.DataValueField = "id";
                ddlCondominio.DataBind();
            }
            else
            {
                throw new Exception("Cadastre ao menos um condominio para inserir uma noticia");
            }
        }

        private void limparNoticia()
        {
            hdfId.Value = String.Empty;
            txtTitulo.Text = String.Empty;
            txtConteudo.Text = String.Empty;
        }

        private void salvarNoticia()
        {
            Noticia noticia = new Noticia();
            if (hdfId.Value != null && hdfId.Value != String.Empty)
            {
                noticia.Id = Int16.Parse(hdfId.Value);
            }else
            {
                noticia.Inclusao = DateTime.Now;
            }
            noticia.Titulo = txtTitulo.Text;
            noticia.Conteudo = txtConteudo.Text;
            noticia.Condominio = new Condominio(Int16.Parse(ddlCondominio.SelectedValue));
            NHibernateDAO.save(noticia);
            hdfId.Value = noticia.Id.ToString();

        }
    }
}