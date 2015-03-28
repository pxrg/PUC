<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TI_Lab_2015._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
            </hgroup>
            <p> Bem vindo(a) ao sistema de gerênciamento de condomínios Beta View. <br />Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.</p>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h3>Alertas:</h3>
    <ul class="round">
        <li class="one">
            Você possui pendências de pagamento prestes a vencer.
        </li>
        <li class="two">
            Você possui uma reclamação de um vizinho.
        </li>        
    </ul>

    <h3>Notícias:</h3>
    <ol class="round">
        <li class="one">
            <h5>Reforma do ambiente comunitário - <i>26/03/2015</i></h5>
            Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat.
            <a href="http://go.microsoft.com/fwlink/?LinkId=245146">ler mais…</a>
        </li>
        <li class="two">
            <h5>5ª Reunião dos moradores - <i>25/03/2015</i></h5>
            Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam.
            <a href="http://go.microsoft.com/fwlink/?LinkId=245147">ler mais…</a>
        </li>
        <li class="three">
            <h5>Racionamento de água e energia - <i>02/03/2015</i></h5>
            Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat. Ut wisi enim ad minim veniam, quis nostrud exerci tation ullamcorper suscipit lobortis nisl ut aliquip ex ea commodo consequat.
            <a href="http://go.microsoft.com/fwlink/?LinkId=245143">ler mais…</a>
        </li>        
    </ol>
</asp:Content>
