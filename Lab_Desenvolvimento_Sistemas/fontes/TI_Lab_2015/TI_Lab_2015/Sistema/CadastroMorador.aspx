<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadastroMorador.aspx.cs" Inherits="TI_Lab_2015.Sistema.CadastroMorador" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="pnlPrincipal" runat="server">
        <div class="row">
            <div class="col-sm-2">
                <label>Nome:<span class="obrigatorio">*</span></label>
            </div>
            <div class="col-sm-10">
                <asp:TextBox ID="txtNome" CssClass="form-control" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="txtNomeValid" ControlToValidate="txtNome"
                    CssClass="obrigatorio_span" runat="server"
                    ErrorMessage="Nome" EnableClientScript="true" SetFocusOnError="true"></asp:RequiredFieldValidator>
            </div>
            <div class="col-sm-2">
                <label>Cpf:<span class="obrigatorio">*</span></label>
            </div>
            <div class="col-sm-4">
                <asp:TextBox ID="txtCpf" CssClass="form-control cpf" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvCpf" ControlToValidate="txtCpf"
                    CssClass="obrigatorio_span" runat="server"
                    ErrorMessage="Cpf" EnableClientScript="true" SetFocusOnError="true"></asp:RequiredFieldValidator>
            </div>
            <div class="col-sm-2">
                <label>Nascimento:</label>
            </div>
            <div class="col-sm-4">
                <asp:TextBox ID="txtNascimento" TextMode="Date" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="col-sm-2">
                <label>Sexo:</label>
            </div>
            <div class="col-sm-4">
                <asp:DropDownList ID="ddlSexo" CssClass="form-control" runat="server">
                    <asp:ListItem Text="Feminino" Value="F" />
                    <asp:ListItem Text="Masculino" Value="M" />
                </asp:DropDownList>
            </div>
            <div class="col-sm-2">
                <label>Telefone:</label>
            </div>
            <div class="col-sm-4">
                <asp:TextBox ID="txtTelefone" CssClass="form-control telefone" runat="server"></asp:TextBox>
            </div>
            <div class="col-sm-2">
                <label>Usuario:<span class="obrigatorio">*</span></label>
            </div>
            <div class="col-sm-10">
                <asp:TextBox ID="txtUsuario" CssClass="form-control" runat="server"></asp:TextBox>
            </div>

            <div class="col-sm-2">
                <label>Senha:<span class="obrigatorio">*</span></label>
            </div>
            <div class="col-sm-4">

                <asp:TextBox ID="txtSenha" TextMode="Password"  CssClass="form-control" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvSenha" ControlToValidate="txtSenha"
                    CssClass="obrigatorio_span" runat="server"
                    ErrorMessage="Senha" EnableClientScript="true" SetFocusOnError="true"></asp:RequiredFieldValidator>
            </div>
            <div class="col-sm-2">
                <label>Confime a Senha:<span class="obrigatorio">*</span></label>
            </div>
            <div class="col-sm-4">

                <asp:TextBox ID="txtConfirmeSenha" TextMode="Password"  CssClass="form-control" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtSenha"
                    CssClass="obrigatorio_span" runat="server"
                    ErrorMessage="Confirmação de Senha" EnableClientScript="true" SetFocusOnError="true"></asp:RequiredFieldValidator>
            </div>
            <div class="col-lg-12">
                <asp:ValidationSummary ID="ValidationSummary1" CssClass="obrigatorio" runat="server" HeaderText="Verifique os campos obrigatórios:"
                    ShowSummary="true" DisplayMode="BulletList" />
            </div>
            <div class="col-sm-12 group-button">
                <asp:Button ID="btnLimpar" CssClass="btn btn-default" CausesValidation="false" runat="server" Text="Limpar" OnClick="btnLimpar_Click" />
                <asp:Button ID="btnSalvar" CssClass="btn btn-default" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
            </div>
        </div>
        <asp:HiddenField ID="hdfId" runat="server" />
        <asp:HiddenField ID="hdfInclusao" runat="server" />
        <script type="text/javascript">
            $(document).ready(function () {
                $('.cpf').mask('000.000.000-00');
                $('.telefone').mask('(00)0000-0000');
            });
        </script>
    </asp:Panel>
</asp:Content>
