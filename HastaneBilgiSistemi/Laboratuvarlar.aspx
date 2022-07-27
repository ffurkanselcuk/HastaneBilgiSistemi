<%@ Page Title="" Language="C#" MasterPageFile="~/Sayfam.Master" AutoEventWireup="true" CodeBehind="Laboratuvarlar.aspx.cs" Inherits="HastaneBilgiSistemi.Laboratuvarlar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <br />
        <h2  margin-left: 10px">LABORATUVAR </h2>
        <br />
        <table class="table table-bordered">
            <tr>
                <th>ID</th>
                <th>DOKTOR</th>
                <th>HASTA</th>
                <th>TALEP</th>
                <th>SONUÇ</th>
                <th>SİL</th>
                <th>SONUÇ GİR</th>
            </tr>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("LaboratuvarID") %></td>
                        <td><%# Eval("Doktor") %></td>
                        <td><%# Eval("Hasta") %></td>
                        <td><%# Eval("Talep") %></td>
                        <td><%# Eval("Sonuc") %></td>
                        <td>
                            <asp:HyperLink ID="HyperLink1" NavigateUrl='<%#"LaboratuvarSil.aspx?LaboratuvarID="+Eval("LaboratuvarID")%>' runat="server" CssClass="btn btn-danger">SİL</asp:HyperLink></td>
                        <td>
                            <asp:HyperLink ID="HyperLink2" NavigateUrl='<%#"LaboratuvarSonucEkle.aspx?LaboratuvarID="+Eval("LaboratuvarID")%>' runat="server" CssClass="btn btn-primary">SONUÇ GİR</asp:HyperLink></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
    </form>
</asp:Content>
