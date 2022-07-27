
<%@ Page Title="" Language="C#" MasterPageFile="~/Sayfam.Master" AutoEventWireup="true" CodeBehind="Doktorlar.aspx.cs" Inherits="HastaneBilgiSistemi.Doktorlar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <br />
        <h2  margin-left: 10px">DOKTOR </h2>
        <br />
        <table class="table table-bordered">
            <tr>
                <th>ID</th>
                <th>DOKTOR</th>
                <th>SİL</th>
                <th>DÜZENLE</th>
            </tr>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("DoktorID") %></td>
                        <td><%# Eval("Doktor") %></td>
                        <td>
                            <asp:HyperLink ID="HyperLink2" NavigateUrl='<%#"DoktorSil.aspx?DoktorID="+Eval("DoktorID")%>' runat="server" CssClass="btn btn-danger">SİL</asp:HyperLink></td>
                        <td>
                            <asp:HyperLink ID="HyperLink1" NavigateUrl='<%#"DoktorGuncelle.aspx?DoktorID="+Eval("DoktorID")%>' runat="server" CssClass="btn btn-info">DÜZENLE</asp:HyperLink></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
        <div style="margin-left: 20px">
            <asp:HyperLink ID="HyperLink1" NavigateUrl="YeniDoktorEkle.aspx?ID=" runat="server" CssClass="btn btn-info">Yeni Doktor Ekle</asp:HyperLink>
        </div>
    </form>
</asp:Content>
