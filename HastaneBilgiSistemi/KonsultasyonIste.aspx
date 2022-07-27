<%@ Page Title="" Language="C#" MasterPageFile="~/Sayfam.Master" AutoEventWireup="true" CodeBehind="KonsultasyonIste.aspx.cs" Inherits="HastaneBilgiSistemi.KonsultasyonIste" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <h2  margin-left: 20px">KONSULTASYON</h2>
    <br />
    <form runat="server" style="margin-left: 20px" class="form-group">
        <div>
            <asp:Label for="TxtID" Style="color: green" runat="server" Text="ID"></asp:Label>
            <br />
            <asp:TextBox ID="TxtID" required="" runat="server" CssClass="form-control" placeholder="ID Giriniz"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label for="TxTblHasta" Style="color: green" runat="server" Text="Hasta"></asp:Label>
            <br />
            <asp:TextBox ID="TxTblHasta" required="" runat="server" CssClass="form-control" placeholder="Hasta Giriniz"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Label for="DropDoktor" Style="color: green" runat="server" Text="Muayene Doktor"></asp:Label>
            <br />
            <br />
            <asp:DropDownList ID="DropDoktor" runat="server" CssClass="form-control"></asp:DropDownList>
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
        <asp:Button ID="BtnEkle" runat="server" Text="Konsültasyon Oluştur" CssClass="btn btn-info" OnClick="BtnEkle_Click" />
    </form>
    <br />
</asp:Content>
