<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistroReceita.aspx.cs" Inherits="TI_Lab_2015.Sistema.RegistroReceita" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="pnlPrincipal" runat="server">
        <div class="row">
            <div class="col-sm-2">
                <label>Condominio:<span class="obrigatorio">*</span></label>
            </div>
            <div class="col-sm-10">
                <asp:DropDownList ID="ddlCondominio" CssClass="form-control" runat="server"></asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtTitulo"
                    CssClass="obrigatorio_span" runat="server" InitialValue=""
                    ErrorMessage="Condominio" EnableClientScript="true" SetFocusOnError="true"></asp:RequiredFieldValidator>
            </div>
            <div class="col-sm-2">
                <label>Descrição:<span class="obrigatorio">*</span></label>
            </div>
            <div class="col-sm-10">
                <asp:TextBox ID="txtTitulo" CssClass="form-control" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="txtTituloValid" ControlToValidate="txtTitulo"
                    CssClass="obrigatorio_span" runat="server"
                    ErrorMessage="Descrição" EnableClientScript="true" SetFocusOnError="true"></asp:RequiredFieldValidator>
            </div>
            <div class="col-sm-2">
                <label>Tipo:<span class="obrigatorio">*</span></label>
            </div>
            <div class="col-sm-10">
                <asp:TextBox ID="txtTipo" CssClass="form-control" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="txtTipoValid" ControlToValidate="txtTipo"
                    CssClass="obrigatorio_span" runat="server"
                    ErrorMessage="Tipo" EnableClientScript="true" SetFocusOnError="true"></asp:RequiredFieldValidator>
            </div>
            <div class="col-sm-2">
                <label>Valor:<span class="obrigatorio">*</span></label>
            </div>
            <div class="col-sm-4">
                <asp:TextBox ID="txtValor" CssClass="form-control area" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtValor"
                    CssClass="obrigatorio_span" runat="server"
                    ErrorMessage="Valor" EnableClientScript="true" SetFocusOnError="true"></asp:RequiredFieldValidator>
            </div>
            <div class="col-sm-2">
                <label>Data realização:<span class="obrigatorio">*</span></label>
            </div>
            <div class="col-sm-4">
                <asp:TextBox ID="txtDataRealizacao" TextMode="Date" CssClass="form-control" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="txtDataRealizacao"
                    CssClass="obrigatorio_span" runat="server"
                    ErrorMessage="Data Realização" EnableClientScript="true" SetFocusOnError="true"></asp:RequiredFieldValidator>
            </div>
            <div class="col-lg-12">
                <asp:ValidationSummary ID="ValidationSummary1" CssClass="obrigatorio" runat="server" HeaderText="Verifique os campos obrigatórios:"
                    ShowSummary="true" DisplayMode="BulletList" />
            </div>
            <div class="col-sm-12 group-button">
                <asp:Button ID="btnLimpar" CssClass="btn btn-default" CausesValidation="false"
                    runat="server" Text="Limpar" OnClick="btnLimpar_Click" />
                <asp:Button ID="btnSalvar" CssClass="btn btn-default" runat="server" Text="Salvar"
                    OnClick="btnSalvar_Click" />
            </div>
            <asp:HiddenField ID="hdfId" runat="server" />
            <script type="text/javascript">
                $(document).ready(function () {
                    $('.area').mask('000.00', { placeholder: "000.00" });
                });
            </script>
        </div>
    </asp:Panel>
</asp:Content>
