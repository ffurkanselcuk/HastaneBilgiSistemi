<%@ Page Title="" Language="C#" MasterPageFile="~/Sayfam.Master" AutoEventWireup="true" CodeBehind="Muayeneler.aspx.cs" Inherits="HastaneBilgiSistemi.Muayeneler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <br />
        <h2  margin-left: 10px">MUAYENE </h2>
        <br />
        <table class="table table-bordered">
            <tr>
                <th>ID</th>
                <th>DOKTOR</th>
                <th>HASTA</th>
                <th>BÖLÜM</th>
                <th>ÖYKÜ</th>
                <th>TEŞHİS</th>
                <th>TEDAVİ</th>
                <th>İLAÇ</th>
                <th>SİL</th>
                <th>KONSÜLTASYON</th>
            </tr>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("MuayeneID") %></td>
                        <td><%# Eval("Doktor") %></td>
                        <td><%# Eval("Hasta") %></td>
                        <td><%# Eval("Bolum") %></td>
                        <td><%# Eval("Oyku") %></td>
                        <td><%# Eval("Teshis") %></td>
                        <td><%# Eval("Tedavi") %></td>
                        <td><%# Eval("Ilaclar") %></td>
                         <td>
                            <asp:HyperLink ID="HyperLink2" NavigateUrl='<%#"MuayeneSil.aspx?MuayeneID="+Eval("MuayeneID")%>' runat="server" CssClass="btn btn-danger">SİL</asp:HyperLink></td>
                        <td>
                            <asp:HyperLink ID="HyperLink1" NavigateUrl='<%#"KonsultasyonIste.aspx?MuayeneID="+Eval("MuayeneID")%>' runat="server" CssClass="btn btn-info">KONSÜLTASYON İSTE</asp:HyperLink></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
    </form>
</asp:Content>
