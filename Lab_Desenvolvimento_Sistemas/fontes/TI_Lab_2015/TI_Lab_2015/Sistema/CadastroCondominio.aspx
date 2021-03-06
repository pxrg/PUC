﻿      <%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroCondominio.aspx.cs" Inherits="TI_Lab_2015.Sistema.CadastroCondominio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <hgroup class="title titulo-pagina" style="text-align:center">
        <h2>Cadastro de Condominio</h2>
    </hgroup>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="pnlPrincipal" runat="server">
        <div class="row">
            <div class="col-sm-2">
                <label>Nome:<span class="obrigatorio">*</span></label>
            </div>
            <div class="col-sm-10">
                <asp:TextBox ID="txtNome" CssClass="form-control" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="txtNomeValid" ControlToValidate="txtNome" 
                    CssClass="obrigatorio_span" runat="server"
                    ErrorMessage="Nome" EnableClientScript="true" SetFocusOnError="true"></asp:RequiredFieldValidator>
            </div>
            <asp:Panel ID="pnlEndereco" runat="server">
                <div class="col-sm-2">
                    <label>Logradouro:<span class="obrigatorio">*</span></label>
                </div>
                <div class="col-sm-10">
                    <asp:TextBox ID="txtLogradouro" CssClass="form-control" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvLogradouro" ControlToValidate="txtLogradouro" 
                    CssClass="obrigatorio_span" runat="server"
                    ErrorMessage="Logradouro" EnableClientScript="true" SetFocusOnError="true"></asp:RequiredFieldValidator>
                </div>
                <div class="col-sm-2">
                    <label>Número:</label>
                </div>
                <div class="col-sm-4">
                    <asp:TextBox ID="txtNumero" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="col-sm-2">
                    <label>Cep:</label>
                </div>
                <div class="col-sm-4">
                    <asp:TextBox ID="txtCep" CssClass="form-control cep" runat="server"></asp:TextBox>
                </div>
                <div class="col-sm-2">
                    <label>Complemento:</label>
                </div>
                <div class="col-sm-4">
                    <asp:TextBox ID="txtComplemento" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="col-sm-2">
                    <label>Bairro:</label>
                </div>
                <div class="col-sm-4">
                    <asp:TextBox ID="txtBairro" CssClass="form-control" runat="server"></asp:TextBox>
                </div>

                <div class="col-sm-2">
                    <label>Cidade:<span class="obrigatorio">*</span></label>
                </div>
                <div class="col-sm-4">
                    <asp:TextBox ID="txtCidade" CssClass="form-control" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvCidade" ControlToValidate="txtCidade" 
                    CssClass="obrigatorio_span" runat="server"
                    ErrorMessage="Cidade" EnableClientScript="true" SetFocusOnError="true"></asp:RequiredFieldValidator>
                </div>
                <div class="col-sm-2">
                    <label>Estado:<span class="obrigatorio">*</span></label>
                </div>
                <div class="col-sm-4">
                    <asp:TextBox ID="txtEstado" CssClass="form-control" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvEstado" ControlToValidate="txtEstado" 
                    CssClass="obrigatorio_span" runat="server"
                    ErrorMessage="Estado" EnableClientScript="true" SetFocusOnError="true"></asp:RequiredFieldValidator>
                </div>
            </asp:Panel>
            <div class="col-lg-12">
                <asp:ValidationSummary ID="ValidationSummary1" CssClass="obrigatorio" runat="server" HeaderText="Verifique os campos obrigatórios:" 
                    ShowSummary="true" DisplayMode="BulletList" />
            </div>
            <div class="col-sm-12 group-button">
                <asp:Button ID="btnLimpar" CssClass="btn btn-default" CausesValidation="false" runat="server" Text="Limpar" OnClick="btnLimpar_Click" />
                <asp:Button ID="btnSalvar" CssClass="btn btn-default" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
            </div>
        </div>
        <asp:HiddenField ID="hdfId" runat="server" />
        <asp:HiddenField ID="hdfIdEndereco" runat="server" />
        <script type="text/javascript">
            $(document).ready(function () {
                $('.cep').mask('00.000-000');
            });
        </script>
    </asp:Panel>
</asp:Content>
