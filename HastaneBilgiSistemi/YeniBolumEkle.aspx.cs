
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HastaneBilgiSistemi
{
    public partial class YeniBolumEkle : System.Web.UI.Page
    {
        HastaneSistemEntities db = new HastaneSistemEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnEkle_Click(object sender, EventArgs e)
        {
            TblBolum b = new TblBolum();
            b.Bolum = TxTblBolum.Text;
            db.TblBolum.Add(b);
            db.SaveChanges();
            Response.Redirect("Bolumler.aspx");
        }
    }
}