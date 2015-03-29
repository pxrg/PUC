<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroNoticias.aspx.cs" Inherits="TI_Lab_2015.Sistema.CadastroNoticias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <div class="titulo-pagina" style="text-align:center">
        <h2>Cadastro de Noticias</h2>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
        <div class="row">
            <div class="col-sm-2"><label>Condominio:</label> </div>
            <div class="col-sm-10">
                <asp:DropDownList ID="ddlCondominio" CssClass="form-control" runat="server"></asp:DropDownList>
            </div> 
            <div class="col-sm-2"><label>Título:</label> </div>
            <div class="col-sm-10">
                <asp:TextBox ID="txtTitulo" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="col-sm-2"><label>Conteúdo:</label> </div>
            <div class="col-sm-10">
                <asp:TextBox ID="txtConteudo" CssClass="form-control" runat="server" Columns="20" Rows="20" Height="200px" TextMode="MultiLine"></asp:TextBox>
            </div> 
            <div class="col-sm-12 group-button">
                <asp:Button ID="btnLimpar" CssClass="btn btn-default" runat="server" Text="Limpar" OnClick="btnLimpar_Click" />
                <asp:Button ID="btnSalvar" CssClass="btn btn-default" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
            </div>
            <div>
                <asp:HiddenField ID="hdfId" runat="server" />
            </div>
        </div>
</asp:Content>
