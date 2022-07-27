
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HastaneBilgiSistemi
{
    public partial class YeniHastaEkle : System.Web.UI.Page
    {
        HastaneSistemEntities db = new HastaneSistemEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void BtnEkle_Click(object sender, EventArgs e)
        {
            TblHasta b = new TblHasta();
            b.Hasta = TxTblHasta.Text;
            b.TC = TxtTC.Text;
            b.Telefon = TxtTelefon.Text;
            b.Cinsiyet = TxtCinsiyet.Text;
            db.TblHasta.Add(b);
            db.SaveChanges();
            Response.Redirect("Hastalar.aspx");
        }
    }
}