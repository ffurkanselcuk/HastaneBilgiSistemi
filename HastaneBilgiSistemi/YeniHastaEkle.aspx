<%@ Page Title="" Language="C#" MasterPageFile="~/Sayfam.Master" AutoEventWireup="true" CodeBehind="YeniHastaEkle.aspx.cs" Inherits="HastaneBilgiSistemi.YeniHastaEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
    <h2  margin-left: 20px">YENİ HASTA EKLE</h2>
    <br />
    <form runat="server" style="margin-left: 20px" class="form-group">
        <div>
            <br />
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
        <asp:Button ID="BtnEkle" runat="server" Text="Yeni Hasta Ekle" CssClass="btn btn-info" OnClick="BtnEkle_Click" />
    </form>
    <br />
</asp:Content>
