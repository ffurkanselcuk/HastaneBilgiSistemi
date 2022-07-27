using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace HastaneBilgiSistemi
{
    public partial class Login : System.Web.UI.Page
    {
        HastaneSistemEntities db = new HastaneSistemEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnGiris_Click(object sender, EventArgs e)
        {
            var x = db.TblAdmin.Where(b => b.Kullanici == TxtKullanici.Text && b.Sifre == TxtSifre.Text).Select(n => n.Rol).FirstOrDefault();
            if (x != null && x != "")
            {
                Session["Rol"] = x;
                Response.Redirect("Bolumler.aspx");
            }
            else
            {
                Response.Write("<script>alert('Hatalı Kullanıcı Adı Veya Şifre')</script>");
            }
        }
    }
}