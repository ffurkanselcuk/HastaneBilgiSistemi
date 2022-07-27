
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HastaneBilgiSistemi
{
    public partial class YeniDoktorEkle : System.Web.UI.Page
    {
        HastaneSistemEntities db = new HastaneSistemEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnEkle_Click(object sender, EventArgs e)
        {
            TblDoktor b = new TblDoktor();
            b.Doktor = TxTblDoktor.Text;
            db.TblDoktor.Add(b);
            db.SaveChanges();
            Response.Redirect("Doktorlar.aspx");
        }
    }
}