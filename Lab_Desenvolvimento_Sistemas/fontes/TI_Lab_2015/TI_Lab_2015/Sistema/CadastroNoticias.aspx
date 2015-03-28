<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroNoticias.aspx.cs" Inherits="TI_Lab_2015.Sistema.CadastroNoticias" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
        <div class="row">
            <div class="col-sm-2"><label>Título:</label> </div>
            <div class="col-sm-10">
                <asp:TextBox ID="txtNome" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="col-sm-2"><label>Conteúdo:</label> </div>
            <div class="col-sm-10">
                <asp:TextBox ID="TextBox2" CssClass="form-control" runat="server" Columns="20" Rows="20" Height="200px"></asp:TextBox>
            </div> 
                       
        </div>
</asp:Content>
