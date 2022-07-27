using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HastaneBilgiSistemi
{
    public partial class MuayeneSil : System.Web.UI.Page
    {
        HastaneSistemEntities db = new HastaneSistemEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["MuayeneID"]);
            var x = db.TblMuayene.Find(id);
            db.TblMuayene.Remove(x);
            db.SaveChanges();
            Response.Redirect("Muayeneler.aspx");
        }
    }
}