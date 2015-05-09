<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroVeiculo.aspx.cs" Inherits="TI_Lab_2015.Sistema.CadastroVeiculo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="pnlPrincipal" runat="server">
        <div class="row">
            <div class="col-sm-2">
                <label><span class="obrigatorio">*</span> Placa:</label>
            </div>
            <div class="col-sm-4">
                <asp:TextBox ID="txtPlaca" CssClass="form-control placa" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="txtPlacaValid" ControlToValidate="txtPlaca"
                    CssClass="obrigatorio_span" runat="server"
                    ErrorMessage="Placa" EnableClientScript="true" SetFocusOnError="true"></asp:RequiredFieldValidator>
            </div>
            <div class="col-sm-2">
                <label>Vaga:</label>
            </div>
            <div class="col-sm-4">
                <asp:TextBox ID="txtVaga" CssClass="form-control vaga" runat="server"></asp:TextBox>
            </div>
            <div class="col-sm-2">
                <label><span class="obrigatorio">*</span> Proprietário:</label>
            </div>
            <div class="col-sm-10">
                <asp:DropDownList ID="ddlProprietario" CssClass="form-control" runat="server"></asp:DropDownList>
                <asp:RequiredFieldValidator ID="rfvProprietario" ControlToValidate="ddlProprietario"
                    CssClass="obrigatorio_span" runat="server"
                    ErrorMessage="Proprietário" EnableClientScript="true" SetFocusOnError="true"></asp:RequiredFieldValidator>
            </div>
            <div class="col-lg-12">
                <asp:ValidationSummary ID="ValidationSummary1" CssClass="obrigatorio" runat="server" HeaderText="Verifique os campos obrigatórios:"
                    ShowSummary="true" DisplayMode="BulletList" />
            </div>
            <div class="col-sm-12 group-button">
                <asp:Button ID="btnLimpar" CssClass="btn btn-default" CausesValidation="false" runat="server" Text="Limpar" />
                <asp:Button ID="btnSalvar" CssClass="btn btn-default" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
            </div>
            <asp:HiddenField ID="hdfId" runat="server" />
            <asp:HiddenField ID="hdfInclusao" runat="server" />
            <script type="text/javascript">
                $(document).ready(function () {
                    $('.placa').mask('AAA-0000');
                });
            </script>
        </div>
    </asp:Panel>
</asp:Content>
