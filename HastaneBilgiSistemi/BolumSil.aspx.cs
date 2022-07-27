
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HastaneBilgiSistemi
{
    public partial class BolumSil : System.Web.UI.Page
    {
        HastaneSistemEntities db = new HastaneSistemEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["BolumID"]);
            var x = db.TblBolum.Find(id);
            db.TblBolum.Remove(x);
            db.SaveChanges();
            Response.Redirect("Bolumler.aspx");
        }
    }
}