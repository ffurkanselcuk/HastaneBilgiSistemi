
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HastaneBilgiSistemi
{
    public partial class BolumGuncelle : System.Web.UI.Page
    {
        HastaneSistemEntities db = new HastaneSistemEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            TxtID.Enabled = false;
            if (!Page.IsPostBack)
            {
                int id = Convert.ToByte(Request.QueryString["BolumID"]);
                var x = db.TblBolum.Find(id);
                TxTblBolum.Text = x.Bolum;
                TxtID.Text = x.BolumID.ToString();
            }
        }

        protected void BtnEkle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToByte(Request.QueryString["BolumID"]);
            var x = db.TblBolum.Find(id);
            x.Bolum = TxTblBolum.Text;
            db.SaveChanges();
            Response.Redirect("Bolumler.aspx");
        }
    }
}