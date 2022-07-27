
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HastaneBilgiSistemi
{
    public partial class Laboratuvarlar : System.Web.UI.Page
    {
        HastaneSistemEntities db = new HastaneSistemEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = (from x in db.TblLaboratuvar select new { x.LaboratuvarID, x.TblDoktor.Doktor, x.TblHasta.Hasta, x.Talep, x.Sonuc }).ToList();
            Repeater1.DataBind();
        }
    }
}