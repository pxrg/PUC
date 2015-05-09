<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroImoveis.aspx.cs" Inherits="TI_Lab_2015.Sistema.CadastroImoveis" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="pnlPrincipal" runat="server">
        <div class="row">
            <div class="col-sm-2">
                <label><span class="obrigatorio">*</span> Numero:</label>
            </div>
            <div class="col-sm-4">
                <asp:TextBox ID="txtNumero" CssClass="form-control" TextMode="Number" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="txtNumeroValid" ControlToValidate="txtNumero"
                    CssClass="obrigatorio_span" runat="server"
                    ErrorMessage="Numero" EnableClientScript="true" SetFocusOnError="true"></asp:RequiredFieldValidator>
            </div>
            <div class="col-sm-2">
                <label>Vagas veiculo:</label>
            </div>
            <div class="col-sm-4">
                <asp:TextBox ID="txtVagasGaragem" CssClass="form-control VagasGaragem" TextMode="Number" runat="server"></asp:TextBox>
            </div>
            <div class="col-sm-2">
                <label>Area:</label>
            </div>
            <div class="col-sm-4">
                <asp:TextBox ID="txtArea" pattern="^[+-]?\d+(,\d{2})?" CssClass="form-control area" runat="server"></asp:TextBox>
            </div>
            <div class="col-sm-2">
                <label><span class="obrigatorio">*</span> Bloco:</label>
            </div>
            <div class="col-sm-4">
                <asp:TextBox ID="txtBloco" CssClass="form-control Bloco" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvBloco" ControlToValidate="txtBloco"
                    CssClass="obrigatorio_span" runat="server"
                    ErrorMessage="Bloco" EnableClientScript="true" SetFocusOnError="true"></asp:RequiredFieldValidator>
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
                <asp:Button ID="btnSalvar" CssClass="btn btn-default" runat="server" Text="Salvar" />
            </div>
            <asp:HiddenField ID="hdfId" runat="server" />
            <script type="text/javascript">
                $(document).ready(function () {
                    $('.area').mask('###0.00', { placeholder: "0.00" });
                });
            </script>
        </div>
    </asp:Panel>
</asp:Content>
