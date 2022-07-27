<%@ Page Title="" Language="C#" MasterPageFile="~/Sayfam.Master" AutoEventWireup="true" CodeBehind="LaboratuvarSonucEkle.aspx.cs" Inherits="HastaneBilgiSistemi.LaboratuvarSonucEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <br />
    <h2  margin-left: 20px">TAHLİL SONUÇ GİR</h2>
    <br />
    <form runat="server" style="margin-left: 20px" class="form-group">
        <div>
            <br />
            <asp:TextBox ID="TxtID" required="" runat="server" CssClass="form-control" placeholder="ID Giriniz"></asp:TextBox>
        </div>
        <br />
        <div>
            <br />
            <asp:TextBox ID="TxtSonuc" required="" runat="server" CssClass="form-control" placeholder="Tahlil Sonucu Giriniz"></asp:TextBox>
        </div>
        <br />
        <asp:Button ID="BtnEkle" runat="server" Text="Tahlil Sonucunu Kaydet" CssClass="btn btn-info" OnClick="BtnEkle_Click"/>
    </form>
    <br />
</asp:Content>
