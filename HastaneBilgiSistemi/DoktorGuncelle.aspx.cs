
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HastaneBilgiSistemi
{
    public partial class DoktorGuncelle : System.Web.UI.Page
    {
        HastaneSistemEntities db = new HastaneSistemEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            TxtID.Enabled = false;
            if (!Page.IsPostBack)
            {
                int id = Convert.ToByte(Request.QueryString["DoktorID"]);
                var x = db.TblDoktor.Find(id);
                TxTblDoktor.Text = x.Doktor;
                TxtID.Text = x.DoktorID.ToString();
            }
        }

        protected void BtnEkle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToByte(Request.QueryString["DoktorID"]);
            var x = db.TblDoktor.Find(id);
            x.Doktor = TxTblDoktor.Text;
            db.SaveChanges();
            Response.Redirect("Doktorlar.aspx");
        }
    }
}