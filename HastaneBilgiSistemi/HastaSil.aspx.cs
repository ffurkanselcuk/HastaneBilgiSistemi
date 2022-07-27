
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HastaneBilgiSistemi
{
    public partial class HastaSil : System.Web.UI.Page
    {
        HastaneSistemEntities db = new HastaneSistemEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["HastaID"]);
            var x = db.TblHasta.Find(id);
            db.TblHasta.Remove(x);
            db.SaveChanges();
            Response.Redirect("Hastalar.aspx");
        }
    }
}