<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConsultarPagamento.aspx.cs" Inherits="TI_Lab_2015.Sistema.ConsultarPagamento" %>

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
            <div class="col-sm-4">
                <asp:DropDownList ID="ddlCondominio" CssClass="form-control" runat="server">
                </asp:DropDownList>
            </div>
            <div class="col-sm-2">
                <label>Data:</label>
            </div>
            <div class="col-sm-4">
                <asp:TextBox ID="txtData" TextMode="Date" CssClass="form-control area" runat="server"></asp:TextBox>
            </div>
            <div class="col-sm-2">
                <label>Vencimento:</label>
            </div>
            <div class="col-sm-4">
                <asp:TextBox ID="txtVencimento" TextMode="Date" CssClass="form-control area" runat="server"></asp:TextBox>
            </div>
            <div class="col-sm-2">
                <label>Status:</label>
            </div>
            <div class="col-sm-4">
                <asp:DropDownList ID="ddlSituacao" CssClass="form-control" runat="server">
                    <asp:ListItem Text="Todos" Value="null" />
                    <asp:ListItem Text="Em aberto" Value="a" />
                    <asp:ListItem Text="Pagos" Value="p" />
                    <asp:ListItem Text="Vencidos" Value="v" />
                </asp:DropDownList>
            </div>
            <div class="col-sm-12 group-button">
                <asp:Button ID="btnLimpar" CssClass="btn btn-default" runat="server" Text="Limpar" OnClick="btnLimpar_Click" />
                <asp:Button ID="btnPesquisar" CssClass="btn btn-default" runat="server" Text="Pesquisar" OnClick="btnPesquisar_Click" />
            </div>
        </div>
        <div>
            <asp:Repeater ID="rptDespesas" runat="server">
                <HeaderTemplate>
                    <table class="table table-striped table-bordered">
                        <thead>
                            <tr>
                                <th>Condominio</th>
                                <th>Descrição</th>
                                <th>Valor</th>
                                <th>Vencimento</th>
                                <th>Data realizado</th>
                                <th>Status</th>
                                <th>Editar</th>
                            </tr>
                        </thead>
                        <tbody>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td><%# ((TI_Lab_2015.Model.Despesa)Container.DataItem).Condominio.Nome %></td>
                        <td>
                            <%# ((TI_Lab_2015.Model.Despesa)Container.DataItem).Descricao %>
                        </td>
                        <td>
                            <%# ((TI_Lab_2015.Model.Despesa)Container.DataItem).Valor.ToString("C") %>
                        </td>
                        <td>
                            <%# ((TI_Lab_2015.Model.Despesa)Container.DataItem).Vencimento.ToShortDateString() %>
                        </td>
                        <td>
                            <%# ((TI_Lab_2015.Model.Despesa)Container.DataItem).DataRealizacao.ToShortDateString() %>
                        </td>
                        <td>
                            <%# ((TI_Lab_2015.Model.Despesa)Container.DataItem).retornarSituacao() %>
                        </td>
                        <td>
                            <a class="btn btn-default"
                                href="RegistroDespesa.aspx?id=<%# ((TI_Lab_2015.Model.Despesa)Container.DataItem).Id %>">Editar</a>
                        </td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </tbody>
                     </table>
                </FooterTemplate>
            </asp:Repeater>
        </div>
        <style>
            .row_td {
                margin-right: 0;
                margin-left: 0;
            }
        </style>
    </asp:Panel>
</asp:Content>
