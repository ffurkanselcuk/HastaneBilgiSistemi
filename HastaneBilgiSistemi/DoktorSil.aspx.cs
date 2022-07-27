
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HastaneBilgiSistemi
{
    public partial class DoktorSil : System.Web.UI.Page
    {
        HastaneSistemEntities db = new HastaneSistemEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["DoktorID"]);
            var x = db.TblDoktor.Find(id);
            db.TblDoktor.Remove(x);
            db.SaveChanges();
            Response.Redirect("Doktorlar.aspx");
        }
    }
}