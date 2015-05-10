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
    public partial class CadastroImoveis : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                carregarPessoas();
                carregarCondominios();
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                this.salvarImovel();
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

        private void salvarImovel()
        {
            Imovel imovel = new Imovel();
            if (hdfId.Value != null && hdfId.Value != String.Empty)
            {
                imovel.Id = Int16.Parse(hdfId.Value);
            }
            imovel.Area = float.Parse(txtArea.Text);
            imovel.Bloco = txtBloco.Text;
            imovel.Numero = Int16.Parse(txtNumero.Text);
            imovel.VagasGaragem = Int16.Parse(txtVagasGaragem.Text);
            imovel.Morador = new Morador(Int16.Parse(ddlProprietario.SelectedValue));
            imovel.Condominio = new Condominio(Int16.Parse(ddlCondominio.SelectedValue));
            NHibernateDAO.save(imovel);
            hdfId.Value = imovel.Id.ToString();
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

        private void carregarCondominios()
        {
            IList<Condominio> pessoas = NHibernateDAO.findAll<Condominio>("nome");
            ddlCondominio .DataSource = pessoas;
            ddlCondominio.DataTextField = "nome";
            ddlCondominio.DataValueField = "id";
            ddlCondominio.DataBind();
            ddlCondominio.Items.Insert(0, new ListItem(" Selecione ", "0"));
        }


    }
}