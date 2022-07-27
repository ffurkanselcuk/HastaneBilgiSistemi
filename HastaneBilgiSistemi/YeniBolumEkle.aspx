<%@ Page Title="" Language="C#" MasterPageFile="~/Sayfam.Master" AutoEventWireup="true" CodeBehind="YeniBolumEkle.aspx.cs" Inherits="HastaneBilgiSistemi.YeniBolumEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <h2  margin-left: 20px">YENİ BÖLÜM EKLE</h2>
    <br />
    <form runat="server" style="margin-left: 20px" class="form-group">
        <div>
            <br />
            <asp:TextBox ID="TxTblBolum" required="" runat="server" CssClass="form-control" placeholder="Bölüm Giriniz"></asp:TextBox>
        </div>
        <br />
        <asp:Button ID="BtnEkle" runat="server" Text="Yeni Bölüm Ekle" CssClass="btn btn-info" OnClick="BtnEkle_Click" />
    </form>
    <br />
</asp:Content>
