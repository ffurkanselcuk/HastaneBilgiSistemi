<%@ Page Title="" Language="C#" MasterPageFile="~/Sayfam.Master" AutoEventWireup="true" CodeBehind="Hastalar.aspx.cs" Inherits="HastaneBilgiSistemi.Hastalar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <form id="form1" runat="server">
        <br />
        <h2  margin-left: 10px">HASTA</h2>
        <br />
        <table class="table table-bordered">
            <tr>
                <th>ID</th>
                <th>HASTA</th>
                <th>TC</th>
                <th>TELEFON</th>
                <th>CİNSİYET</th>
                <th>SİL</th>
                <th>DÜZENLE</th>
            </tr>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("HastaID") %></td>
                        <td><%# Eval("Hasta") %></td>
                        <td><%# Eval("TC") %></td>
                        <td><%# Eval("Telefon") %></td>
                        <td><%# Eval("Cinsiyet")%></td>
                        <td>
                            <asp:HyperLink ID="HyperLink2" NavigateUrl='<%#"HastaSil.aspx?HastaID="+Eval("HastaID")%>' runat="server" CssClass="btn btn-danger">SİL</asp:HyperLink></td>
                        <td>
                            <asp:HyperLink ID="HyperLink1" NavigateUrl='<%#"HastaGuncelle.aspx?HastaID="+Eval("HastaID")%>' runat="server" CssClass="btn btn-info">DÜZENLE</asp:HyperLink></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
        <div style="margin-left: 20px">
            <asp:HyperLink ID="HyperLink1" NavigateUrl="YeniHastaEkle.aspx?ID=" runat="server" CssClass="btn btn-info">Yeni Hasta Ekle</asp:HyperLink>
        </div>
    </form>
</asp:Content>
