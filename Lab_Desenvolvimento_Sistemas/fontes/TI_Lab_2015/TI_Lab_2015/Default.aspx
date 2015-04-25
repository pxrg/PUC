<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TI_Lab_2015._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
            </hgroup>
            <p>
                Bem vindo(a) ao sistema de gerênciamento de condomínios Beta View.
                <br />
                Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.
            </p>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h3>Alertas:</h3>
    <ul class="round">
        <li class="one">Você possui pendências de pagamento prestes a vencer.
        </li>
        <li class="two">Você possui uma reclamação de um vizinho.
        </li>
    </ul>

    <h3>Notícias:</h3>
    <ol class="round">
        <asp:Label ID="lblSemNoticias" runat="server" Text=""></asp:Label>
        <asp:Repeater ID="rptNoticias" runat="server">
            <ItemTemplate>
                <li class="_<%# Container.ItemIndex+1 %>">
                    <h5><%# ((TI_Lab_2015.Model.Noticia)Container.DataItem).Titulo %> - <i><%# ((TI_Lab_2015.Model.Noticia)Container.DataItem).Inclusao.ToShortDateString() %></i></h5>
                    <%# ((TI_Lab_2015.Model.Noticia)Container.DataItem).Conteudo.Substring(0, ((TI_Lab_2015.Model.Noticia)Container.DataItem).Conteudo.Length >= 100 ? 100:((TI_Lab_2015.Model.Noticia)Container.DataItem).Conteudo.Length) %> ...
                    <br />
                    <a href="http://go.microsoft.com/fwlink/?LinkId=245146">Ler mais…</a>
                </li>
            </ItemTemplate>
        </asp:Repeater>
    </ol>
</asp:Content>
