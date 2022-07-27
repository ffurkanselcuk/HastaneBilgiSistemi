<%@ Page Title="" Language="C#" MasterPageFile="~/Sayfam.Master" AutoEventWireup="true" CodeBehind="YeniMuayeneEkle.aspx.cs" Inherits="HastaneBilgiSistemi.YeniMuayeneEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <h2  margin-left: 20px">YENİ MUAYENE EKLE</h2>
    <br />
    <form runat="server" style="margin-left: 20px" class="form-group">
        <div>
            <asp:Label for="DropDoktor" Style="color: green" runat="server" Text="Muayene Doktor"></asp:Label>
            <br />
            <br />
            <asp:DropDownList ID="DropDoktor" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <br />
          <div>
            <asp:Label for="DropHasta" Style="color: green" runat="server" Text="Muayene Hasta"></asp:Label>
            <br />
            <br />
            <asp:DropDownList ID="DropHasta" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <br />
          <div>
            <asp:Label for="DropBolum" Style="color: green" runat="server" Text="Muayene Bölüm"></asp:Label>
            <br />
            <br />
            <asp:DropDownList ID="DropBolum" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <br />
        <div>
            <br />
            <asp:TextBox ID="TxtOyku" required="" runat="server" CssClass="form-control" placeholder="Öykü Giriniz"></asp:TextBox>
        </div>
        <br />
        <div>
            <br />
            <asp:TextBox ID="TxtTeshis" required="" runat="server" CssClass="form-control" placeholder="Teşhis Giriniz"></asp:TextBox>
        </div>
        <br />
        <div>
            <br />
            <asp:TextBox ID="TxtTedavi" required="" runat="server" CssClass="form-control" placeholder="Tedavi Giriniz"></asp:TextBox>
        </div>
        <br />
        <div>
            <br />
            <asp:TextBox ID="TxtIlac" required="" runat="server" CssClass="form-control" placeholder="İlaç Giriniz"></asp:TextBox>
        </div>
        <br />
        <asp:Button ID="BtnEkle" runat="server" Text="Yeni Muayene Ekle" CssClass="btn btn-info" OnClick="BtnServisEkle_Click" />
    </form>
    <br />


</asp:Content>
