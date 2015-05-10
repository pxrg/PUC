using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TI_Lab_2015.Model;
using TI_Lab_2015.Persistence;

namespace TI_Lab_2015.Sistema
{
    public partial class ControleConsumo : System.Web.UI.Page
    {
        IList<LeituraConsumo> leituras;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                carregarImoveis();
            }
        }

        protected void btnPesquisar_Click(object sender, EventArgs e)
        {
            pesquisar();
        }

        protected void btnLimpar_Click(object sender, EventArgs e)
        {
            txtData.Text = null;
            carregarImoveis();
        }

        private void pesquisar()
        {
            carregarLeituras();
            rptConsumos.DataSource = leituras;
            rptConsumos.DataBind();
        }

        private void carregarLeituras()
        {
            Dictionary<String, Object> condit = new Dictionary<string, object>();
            if (!String.IsNullOrEmpty(txtData.Text))
            {
                condit.Add("DataReferencia", DateTime.Parse(txtData.Text));
            }
            if (!ddlImovel.SelectedValue.Equals("0"))
            {
                condit.Add("Imovel.Id", Int16.Parse(ddlImovel.SelectedValue));   
            }
            leituras = NHibernateDAO.find<LeituraConsumo>(condit);
            if (leituras == null)
            {
                leituras = new List<LeituraConsumo>();
            }
        }

        private void carregarImoveis()
        {
            IList<Imovel> imoveis = NHibernateDAO.findAll<Imovel>("numero");
            ddlImovel.DataSource = imoveis;
            ddlImovel.DataTextField = "numero";
            ddlImovel.DataValueField = "id";
            ddlImovel.DataBind();
            ddlImovel.Items.Insert(0, new ListItem(" Todos ", "0"));
        }

        protected void chkPagAgua_CheckedChanged(object sender, EventArgs e)
        {
            carregarLeituras();
            CheckBox checkBox = (CheckBox)sender;
            Int16 id = Int16.Parse(checkBox.ValidationGroup);
            foreach (LeituraConsumo item in leituras)
            {
                if (item.Id.Equals(id))
                {
                    if (checkBox.Checked)
                    {
                        item.PagamentoAgua = DateTime.Now;
                    }
                    else
                    {
                        item.PagamentoAgua = null;
                    }
                    NHibernateDAO.save(item);
                    break;
                }
            }
        }


        protected void chkPagGas_CheckedChanged(object sender, EventArgs e)
        {
            carregarLeituras();
            CheckBox checkBox = (CheckBox)sender;
            Int16 id = Int16.Parse(checkBox.ValidationGroup);
            foreach (LeituraConsumo item in leituras)
            {
                if (item.Id.Equals(id))
                {
                    if (checkBox.Checked)
                    {
                        item.PagamentoGas = DateTime.Now;
                    }
                    else
                    {
                        item.PagamentoGas = null;
                    }
                    NHibernateDAO.save(item);
                    break;
                }
            }
        }

        protected void chkPagEnergia_CheckedChanged(object sender, EventArgs e)
        {
            carregarLeituras();
            CheckBox checkBox = (CheckBox)sender;
            Int16 id = Int16.Parse(checkBox.ValidationGroup);
            foreach (LeituraConsumo item in leituras)
            {
                if (item.Id.Equals(id))
                {
                    if (checkBox.Checked)
                    {
                        item.PagamentoEnergia = DateTime.Now;
                    }
                    else
                    {
                        item.PagamentoEnergia = null;
                    }
                    NHibernateDAO.save(item);
                    break;
                }
            }
        }


    }
}