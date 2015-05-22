<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmitirBalancete.aspx.cs" Inherits="TI_Lab_2015.Sistema.EmitirBalancete" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="pnlPrincipal" runat="server">
        <div class="row">
            <div class="col-sm-2">
                <label>Condominio:</label>
            </div>
            <div class="col-sm-10">
                <asp:DropDownList ID="ddlCondominio" CssClass="form-control" runat="server">
                </asp:DropDownList>
            </div>
            <div class="col-sm-2">
                <label>Data inicio:</label>
            </div>
            <div class="col-sm-4">
                <asp:TextBox ID="txtDataIni" TextMode="Date" CssClass="form-control area" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="txtNomeValid" ControlToValidate="txtDataIni" 
                    CssClass="obrigatorio_span" runat="server"
                    ErrorMessage="Data inicio" EnableClientScript="true" SetFocusOnError="true"></asp:RequiredFieldValidator>
            </div>
            <div class="col-sm-2">
                <label>Data fim:</label>
            </div>
            <div class="col-sm-4">
                <asp:TextBox ID="txtDataFim" TextMode="Date" CssClass="form-control area" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtDataFim" 
                    CssClass="obrigatorio_span" runat="server"
                    ErrorMessage="Data fim" EnableClientScript="true" SetFocusOnError="true"></asp:RequiredFieldValidator>
            </div>
            <div class="col-lg-12">
                <asp:ValidationSummary ID="ValidationSummary1" CssClass="obrigatorio" runat="server" HeaderText="Verifique os campos obrigatórios:" 
                    ShowSummary="true" DisplayMode="BulletList" />
            </div>
            <div class="col-sm-12 group-button">
                <asp:Button ID="btnExportar" CssClass="btn btn-default" runat="server" Text="Exportar" OnClick="btnExportar_Click" />
                <asp:Button ID="btnLimpar" CssClass="btn btn-default" runat="server" Text="Limpar" OnClick="btnLimpar_Click" />
                <asp:Button ID="btnBuscar" CssClass="btn btn-default" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
            </div>
             <div class="col-sm-6">
                <asp:Repeater ID="rptReceitas" runat="server">
                    <HeaderTemplate>
                        <table class="table table-striped table-bordered">
                            <thead>
                                <tr>
                                    <th>Cod</th>
                                    <th>Data</th>
                                    <th>Valor</th>
                                </tr>
                            </thead>
                            <tbody>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td><%# ((TI_Lab_2015.Model.Receita)Container.DataItem).Id %></td>
                            <td>
                                <%# ((TI_Lab_2015.Model.Receita)Container.DataItem).DataRealizacao.ToShortDateString() %>
                            </td>
                            <td>
                                <%# ((TI_Lab_2015.Model.Receita)Container.DataItem).Valor.ToString("C") %>
                            </td>
                        </tr>
                    </ItemTemplate>
                    <FooterTemplate>
                        <tr>
                            <td style="text-align: center">
                                <asp:Label ID="lblVazio" runat="server" Visible="false" Text="Nenhum registro encontrado"></asp:Label>
                            </td>
                        </tr>
                        </tbody>
                     </table>
                    </FooterTemplate>
                </asp:Repeater>
            </div>
            <div class="col-sm-6">
                <asp:Repeater ID="rptDespesas" runat="server">
                    <HeaderTemplate>
                        <table class="table table-striped table-bordered">
                            <thead>
                                <tr>
                                    <th>Cod</th>
                                    <th>Vencimento</th>
                                    <th>Quitação</th>
                                    <th>Valor</th>
                                </tr>
                            </thead>
                            <tbody>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td><%# ((TI_Lab_2015.Model.Despesa)Container.DataItem).Id %></td>
                            <td>
                                <%# ((TI_Lab_2015.Model.Despesa)Container.DataItem).Vencimento.ToShortDateString() %>
                            </td>
                            <td>
                                <%# (((TI_Lab_2015.Model.Despesa)Container.DataItem).DataQuitacao != null ? ((TI_Lab_2015.Model.Despesa)Container.DataItem).DataQuitacao.Value.ToShortDateString():"")
                                %>
                            </td>
                            <td>
                                <%# ((TI_Lab_2015.Model.Despesa)Container.DataItem).Valor.ToString("C") %>
                            </td>
                        </tr>
                    </ItemTemplate>
                    <FooterTemplate>
                        <tr>
                            <td style="text-align: center">
                                <asp:Label ID="lblVazio" runat="server" Visible="false" Text="Nenhum registro encontrado"></asp:Label>
                            </td>
                        </tr>
                        </tbody>
                     </table>
                    </FooterTemplate>
                </asp:Repeater>
            </div>
        </div>
        <style>
            .row_td {
                margin-right: 0;
                margin-left: 0;
            }
        </style>
    </asp:Panel>
</asp:Content>
