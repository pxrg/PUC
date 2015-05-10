<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ControleConsumo.aspx.cs" Inherits="TI_Lab_2015.Sistema.ControleConsumo" %>

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
                <asp:TextBox ID="txtData" TextMode="Date" CssClass="form-control area" runat="server"></asp:TextBox>
            </div>
            <div class="col-sm-2">
                <label><span class="obrigatorio">*</span> Imovel:</label>
            </div>
            <div class="col-sm-4">
                <asp:DropDownList ID="ddlImovel" CssClass="form-control" runat="server"></asp:DropDownList>
            </div>
            <div class="col-sm-12 group-button">
                <asp:Button ID="btnLimpar" CssClass="btn btn-default" CausesValidation="false" runat="server" Text="Limpar" OnClick="btnLimpar_Click" />
                <asp:Button ID="btnPesquisar" CssClass="btn btn-default" runat="server" Text="Pesquisar" OnClick="btnPesquisar_Click" />
            </div>
        </div>
        <div>
            <asp:Repeater ID="rptConsumos" runat="server">
                <HeaderTemplate>
                    <table class="table table-striped table-bordered">
                        <thead>
                            <tr>
                                <th>Imovel</th>
                                <th>Data Referencia</th>
                                <th>Valor Agua</th>
                                <th>Valor Gás</th>
                                <th>Valor Energia</th>
                            </tr>
                        </thead>
                        <tbody>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td><%# ((TI_Lab_2015.Model.LeituraConsumo)Container.DataItem).Imovel.Bloco +"-"+ ((TI_Lab_2015.Model.LeituraConsumo)Container.DataItem).Imovel.Numero %></td>
                        <td>
                            <%# ((TI_Lab_2015.Model.LeituraConsumo)Container.DataItem).DataReferencia.ToShortDateString() %>
                        </td>
                        <td>
                            <div class="row row_td">
                                <div class="col-sm-7">
                                    <%# ((TI_Lab_2015.Model.LeituraConsumo)Container.DataItem).ValorAgua.ToString("C") %>
                                </div>
                                <div class="col-sm-4">
                                    <asp:CheckBox ID="chkPagAgua" OnCheckedChanged="chkPagAgua_CheckedChanged" 
                                        AutoPostBack="true" ValidationGroup="<%# ((TI_Lab_2015.Model.LeituraConsumo)Container.DataItem).Id %>"  runat="server" 
                                        Checked="<%# ((TI_Lab_2015.Model.LeituraConsumo)Container.DataItem).PagamentoAgua != null %>" /> Pago
                                    <asp:HiddenField ID="hfId" runat="server" Value="<%# ((TI_Lab_2015.Model.LeituraConsumo)Container.DataItem).Id %>" />
                                </div>
                            </div>
                        </td>
                        <td>
                            <div class="row row_td">
                                <div class="col-sm-7">
                                    <%# ((TI_Lab_2015.Model.LeituraConsumo)Container.DataItem).ValorGas.ToString("C") %>
                                </div>
                                <div class="col-sm-4">
                                    <asp:CheckBox ID="chkPagGas" OnCheckedChanged="chkPagGas_CheckedChanged"
                                        AutoPostBack="true" ValidationGroup="<%# ((TI_Lab_2015.Model.LeituraConsumo)Container.DataItem).Id %>"  runat="server" 
                                        Checked="<%# ((TI_Lab_2015.Model.LeituraConsumo)Container.DataItem).PagamentoGas != null %>" /> Pago
                                </div>
                            </div>
                        </td>
                        <td>
                            <div class="row row_td">
                                <div class="col-sm-7">
                                    <%# ((TI_Lab_2015.Model.LeituraConsumo)Container.DataItem).ValorEnergia.ToString("C") %>
                                </div>
                                <div class="col-sm-4">
                                    <asp:CheckBox ID="chkPagEnergia"  OnCheckedChanged="chkPagEnergia_CheckedChanged"
                                        AutoPostBack="true" ValidationGroup="<%# ((TI_Lab_2015.Model.LeituraConsumo)Container.DataItem).Id %>"  runat="server" 
                                        Checked="<%# ((TI_Lab_2015.Model.LeituraConsumo)Container.DataItem).PagamentoEnergia != null %>" /> Pago
                                </div>
                            </div>
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
