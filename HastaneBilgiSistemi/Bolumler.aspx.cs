
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HastaneBilgiSistemi
{
    public partial class Bolumler : System.Web.UI.Page
    {
        HastaneSistemEntities db = new HastaneSistemEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = db.TblBolum.ToList();
            Repeater1.DataBind();
        }
    }
}