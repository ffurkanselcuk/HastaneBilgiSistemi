
<%@ Page Title="" Language="C#" MasterPageFile="~/Sayfam.Master" AutoEventWireup="true" CodeBehind="Bolumler.aspx.cs" Inherits="HastaneBilgiSistemi.Bolumler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <br />
        <h2 style="color:purple;">BÖLÜM </h2>
        <br />
        <table class="table table-bordered">
            <tr>
                <th>ID</th>
                <th>BÖLÜM</th>
                <th>SİL</th>
                <th>DÜZENLE</th>
            </tr>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("BolumID") %></td>
                        <td><%# Eval("Bolum") %></td>
                        <td>
                            <asp:HyperLink ID="HyperLink2" NavigateUrl='<%#"BolumSil.aspx?BolumID="+Eval("BolumID")%>' runat="server" CssClass="btn btn-danger">SİL</asp:HyperLink></td>
                        <td>
                            <asp:HyperLink ID="HyperLink1" NavigateUrl='<%#"BolumGuncelle.aspx?BolumID="+Eval("BolumID")%>' runat="server" CssClass="btn btn-info">DÜZENLE</asp:HyperLink></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
        <div style="margin-left: 20px">
            <asp:HyperLink ID="HyperLink1" NavigateUrl="YeniBolumEkle.aspx" runat="server" CssClass="btn btn-info">Yeni Bölüm Ekle</asp:HyperLink>
        </div>
    </form>
</asp:Content>
