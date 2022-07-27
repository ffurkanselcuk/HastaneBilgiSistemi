using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace HastaneBilgiSistemi
{
    public partial class Sayfam : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string kullanici = Session["Rol"].ToString();
            LblKullanici.Text = $"Hoşgeldiniz Sayın '{kullanici}'";
        }
    }
}