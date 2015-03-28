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
            <div class="col-sm-2"><label>Nome:</label> </div>
            <div class="col-sm-10">
                <asp:TextBox ID="txtNome" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="col-sm-12 group-button" >
                <asp:Button ID="btnLimpar" CssClass="btn btn-default" runat="server" Text="Limpar" OnClick="btnLimpar_Click" />
                <asp:Button ID="btnSalvar" CssClass="btn btn-default" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
            </div>
        </div>
        <asp:HiddenField ID="hdfId" runat="server" />
    </asp:Panel>
</asp:Content>
