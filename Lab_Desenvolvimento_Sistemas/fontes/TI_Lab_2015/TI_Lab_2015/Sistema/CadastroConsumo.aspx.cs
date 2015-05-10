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
    public partial class CadastroConsumo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                carregarImoveis();
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                this.salvarConsumo();
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


        private void salvarConsumo()
        {
            LeituraConsumo consumo = new LeituraConsumo();
            if (hdfId.Value != null && hdfId.Value != String.Empty)
            {
                consumo.Id = Int16.Parse(hdfId.Value);
            }
            else
            {
                consumo.PagamentoAgua = null;
                consumo.PagamentoEnergia = null;
                consumo.PagamentoGas = null;
            }
            consumo.DataReferencia = DateTime.Parse(txtData.Text);
            consumo.ValorAgua = PageUtil.formatParse(txtAgua.Text);
            consumo.ValorEnergia = PageUtil.formatParse(txtEnergia.Text);
            consumo.ValorGas = PageUtil.formatParse(txtGas.Text);
            consumo.Imovel = new Imovel(Int16.Parse(ddlImovel.SelectedValue));
            NHibernateDAO.save(consumo);
            hdfId.Value = consumo.Id.ToString();
        }

        private void carregarImoveis()
        {
            IList<Imovel> imoveis = NHibernateDAO.findAll<Imovel>("numero");
            ddlImovel.DataSource = imoveis;
            ddlImovel.DataTextField = "numero";
            ddlImovel.DataValueField = "id";
            ddlImovel.DataBind();
            ddlImovel.Items.Insert(0, new ListItem(" Selecione ", "0"));
        }
    }
}