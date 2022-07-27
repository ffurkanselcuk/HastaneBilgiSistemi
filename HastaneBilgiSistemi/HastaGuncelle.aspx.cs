
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HastaneBilgiSistemi
{
    public partial class HastaGuncelle : System.Web.UI.Page
    {
        HastaneSistemEntities db = new HastaneSistemEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            TxtID.Enabled = false;
            if (!Page.IsPostBack)
            {
                int id = Convert.ToByte(Request.QueryString["HastaID"]);
                var x = db.TblHasta.Find(id);
                TxtTC.Text = x.TC;
                TxTblHasta.Text = x.Hasta;
                TxtID.Text = x.HastaID.ToString();
                TxtTelefon.Text = x.Telefon;
                TxtCinsiyet.Text = x.Cinsiyet;
            }
        }

        protected void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToByte(Request.QueryString["HastaID"]);
            var x = db.TblHasta.Find(id);
            x.TC = TxtTC.Text;
            x.Hasta = TxTblHasta.Text;
            x.Telefon = TxtTelefon.Text;
            x.Cinsiyet = TxtCinsiyet.Text;
            db.SaveChanges();
            Response.Redirect("Hastalar.aspx");
        }
    }
}