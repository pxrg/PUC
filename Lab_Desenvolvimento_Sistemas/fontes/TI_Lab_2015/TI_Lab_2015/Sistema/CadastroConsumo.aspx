<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroConsumo.aspx.cs" Inherits="TI_Lab_2015.Sistema.CadastroConsumo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
      <asp:Panel ID="pnlPrincipal" runat="server">
        <div class="row">
            <div class="col-sm-2">
                <label>Data:</label>
            </div>
            <div class="col-sm-4">
                <asp:TextBox ID="txtData" TextMode="Date" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="col-sm-2">
                <label>Energia:</label>
            </div>
            <div class="col-sm-4">
                <asp:TextBox ID="txtEnergia"  CssClass="form-control float" runat="server"></asp:TextBox>
            </div>
            <div class="col-sm-2">
                <label>Gás:</label>
            </div>
            <div class="col-sm-4">
                <asp:TextBox ID="txtGas" CssClass="form-control float" runat="server"></asp:TextBox>
            </div>
            <div class="col-sm-2">
                <label>Água:</label>
            </div>
            <div class="col-sm-4">
                <asp:TextBox ID="txtAgua" CssClass="form-control float" runat="server"></asp:TextBox>
            </div>
            <div class="col-sm-2">
                <label><span class="obrigatorio">*</span> Imovel:</label>
            </div>
            <div class="col-sm-10">
                <asp:DropDownList ID="ddlImovel" CssClass="form-control" runat="server"></asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="ddlImovel"
                    CssClass="obrigatorio_span" runat="server" InitialValue="0"
                    ErrorMessage="Imovel" EnableClientScript="true" SetFocusOnError="true"></asp:RequiredFieldValidator>
            </div>
            <div class="col-lg-12">
                <asp:ValidationSummary ID="ValidationSummary1" CssClass="obrigatorio" runat="server" HeaderText="Verifique os campos obrigatórios:"
                    ShowSummary="true" DisplayMode="BulletList" />
            </div>
            <div class="col-sm-12 group-button">
                <asp:Button ID="btnLimpar" CssClass="btn btn-default" CausesValidation="false" runat="server" Text="Limpar" OnClick="btnLimpar_Click" />
                <asp:Button ID="btnSalvar" CssClass="btn btn-default" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
            </div>
            <asp:HiddenField ID="hdfId" runat="server" />
            <script type="text/javascript">
                $(document).ready(function () {
                    $('.float').mask('0.000,00', { placeholder: "0.000,00" });
                });
            </script>
        </div>
    </asp:Panel>
</asp:Content>
