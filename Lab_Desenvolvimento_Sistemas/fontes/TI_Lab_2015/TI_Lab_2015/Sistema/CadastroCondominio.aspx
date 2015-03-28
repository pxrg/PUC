<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroCondominio.aspx.cs" Inherits="TI_Lab_2015.Sistema.CadastroCondominio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <hgroup class="title">
        <h1>Cadastro de Condominio</h1>
    </hgroup>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="pnlPrincipal" runat="server">
        <div class="row">
            <div class="col-sm-2">
                <span class="obrigatorio">*</span><label>Nome:</label>
            </div>
            <div class="col-sm-10">
                <asp:TextBox ID="txtNome" CssClass="form-control" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="txtNomeValid" ControlToValidate="txtNome" CssClass="obrigatorio" runat="server" ValidationGroup="obrigatorio" ErrorMessage="Nome Obrigatório"></asp:RequiredFieldValidator>
            </div>
            <asp:Panel ID="pnlEndereco" runat="server">
                <div class="col-sm-2">
                    <label>Logradouro:</label>
                </div>
                <div class="col-sm-10">
                    <asp:TextBox ID="txtLogradouro" CssClass="form-control" runat="server"></asp:TextBox>
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
                    <asp:TextBox ID="txtCep" CssClass="form-control" runat="server"></asp:TextBox>
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
                    <label>Cidade:</label>
                </div>
                <div class="col-sm-4">
                    <asp:TextBox ID="txtCidade" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <div class="col-sm-2">
                    <label>Estado:</label>
                </div>
                <div class="col-sm-4">
                    <asp:TextBox ID="txtEstado" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
            </asp:Panel>
            <div class="col-sm-12 group-button">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ValidationGroup="obrigatorio" />
                <asp:Button ID="btnLimpar" CssClass="btn btn-default" runat="server" Text="Limpar" OnClick="btnLimpar_Click" />
                <asp:Button ID="btnSalvar" CssClass="btn btn-default" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
            </div>
        </div>
        <asp:HiddenField ID="hdfId" runat="server" />
    </asp:Panel>
</asp:Content>
