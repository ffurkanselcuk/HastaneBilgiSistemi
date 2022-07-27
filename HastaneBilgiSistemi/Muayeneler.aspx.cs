
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HastaneBilgiSistemi
{
    public partial class Muayeneler : System.Web.UI.Page
    {
        HastaneSistemEntities db = new HastaneSistemEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = (from c in db.TblMuayene select new { c.MuayeneID, c.TblDoktor.Doktor, c.TblHasta.Hasta, c.TblBolum.Bolum, c.Oyku, c.Teshis, c.Tedavi, c.Ilaclar }).ToList();
            Repeater1.DataBind();
        }
    }
}