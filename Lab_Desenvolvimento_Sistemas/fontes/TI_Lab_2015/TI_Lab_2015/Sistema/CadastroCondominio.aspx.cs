﻿using System;

using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TI_Lab_2015.Model;
using TI_Lab_2015.Persistence;

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
            }
            catch (Exception ex)
            {

            }
        }


        private void limparTela()
        {
            txtNome.Text = String.Empty;
            hdfId.Value = String.Empty;
        }

        private void salvarCondominio()
        {
            Condominio cond = new Condominio();
            if (hdfId.Value != null && hdfId.Value != String.Empty)
            {
                cond.Id = Int16.Parse(hdfId.Value);
            }
            cond.Nome = txtNome.Text;
            NHibernateDAO.save(cond);
        }
    }
}