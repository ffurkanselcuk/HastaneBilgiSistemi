<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="HastaneBilgiSistemi.Login" %>
<!DOCTYPE html>
<html lang="en">
<head>
    <title>Giriş Yap</title>
</head>
<body>
    <style>
        form {
            border: 3px solid #f1f1f1;
        }

        input[type=text], input[type=password] {
            width: 100%;
            padding: 12px 20px;
            margin: 8px 0;
            display: inline-block;
            border: 1px solid #ccc;
            box-sizing: border-box;
        }

        .button {
            background-color: #04AA6D;
            color: white;
            padding: 14px 20px;
            margin: 8px 0;
            border: none;
            cursor: pointer;
            width: 100%;
        }

            .button:hover {
                opacity: 0.8;
            }
        .container {
            padding: 16px;
        }

        span.psw {
            float: right;
            padding-top: 16px;
        }

        @media screen and (max-width: 300px) {
            span.psw {
                display: block;
                float: none;
            }

        }
    </style>
    <h1>Hastane Sistemi Giriş Paneli</h1>
    <form runat="server" method="post" >
        <div class="container">
            <label for="uname"><b>Kullanıcı Adı</b></label>
            <asp:TextBox ID="TxtKullanici" type="text" runat="server" placeholder="Kullanıcı Adı Giriniz"></asp:TextBox>
            <label for="psw"><b>Parola</b></label>
            <asp:TextBox ID="TxtSifre" type="password" runat="server" placeholder="Parola Giriniz"></asp:TextBox>
            <asp:Button ID="BtnGiris" class="button" runat="server" Text="Giriş Yap" OnClick="BtnGiris_Click" />
        </div>
    </form>
</body>
</html>
