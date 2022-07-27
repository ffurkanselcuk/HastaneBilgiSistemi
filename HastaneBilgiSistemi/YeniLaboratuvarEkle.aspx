<%@ Page Title="" Language="C#" MasterPageFile="~/Sayfam.Master" AutoEventWireup="true" CodeBehind="YeniLaboratuvarEkle.aspx.cs" Inherits="HastaneBilgiSistemi.YeniLaboratuvarEkle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <h2  margin-left: 20px">YENİ TAHLİL TALEBİ EKLE</h2>
    <br />
    <form runat="server" style="margin-left: 20px" class="form-group">
        <br />
        <div>
            <asp:Label for="DropDoktor" Style="color: green" runat="server" Text="Tahlili İsteyen Doktor"></asp:Label>
            <br />
            <br />
            <asp:DropDownList ID="DropDoktor" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <br />
        <div>
            <asp:Label for="DropHasta" Style="color: green" runat="server" Text="Tahlili İstenen Hasta"></asp:Label>
            <br />
            <br />
            <asp:DropDownList ID="DropHasta" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <br />
        <div>
            <br />
            <asp:TextBox ID="TxtTahlil" required="" runat="server" CssClass="form-control" placeholder="Tahlil Talebi Giriniz"></asp:TextBox>
        </div>
        <br />
        <asp:Button ID="BtnEkle" runat="server" Text="Yeni Tahlil Talebi Ekle" CssClass="btn btn-info" OnClick="BtnEkle_Click"/>
    </form>
    <br />
</asp:Content>
