<%@ Page Title="" Language="C#" MasterPageFile="~/Sayfam.Master" AutoEventWireup="true" CodeBehind="HastaGuncelle.aspx.cs" Inherits="HastaneBilgiSistemi.HastaGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <h2  margin-left: 20px">HASTA GÜNCELLE</h2>
    <br />
    <form runat="server" style="margin-left: 20px" class="form-group">
         <div>
            <asp:TextBox ID="TxtID" required="" runat="server" CssClass="form-control" placeholder="ID Giriniz"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:TextBox ID="TxtTC" required="" runat="server" CssClass="form-control" placeholder="TC Giriniz"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:TextBox ID="TxTblHasta" required="" runat="server" CssClass="form-control" placeholder="Hasta Giriniz"></asp:TextBox>
        </div>
        <br />
         <div>
            <asp:TextBox ID="TxtTelefon" required="" runat="server" CssClass="form-control" placeholder="Telefon Giriniz"></asp:TextBox>
        </div>
         <br />
         <div>
            <asp:TextBox ID="TxtCinsiyet" required="" runat="server" CssClass="form-control" placeholder="Cinsiyet Giriniz"></asp:TextBox>
        </div>
            <br />
        <asp:Button ID="BtnGuncelle" runat="server" Text="Hasta Bilgilerini Kaydet" CssClass="btn btn-info" OnClick="BtnGuncelle_Click" />
    </form>
    <br />
</asp:Content>
