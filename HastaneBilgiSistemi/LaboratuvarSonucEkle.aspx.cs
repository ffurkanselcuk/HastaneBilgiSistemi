
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HastaneBilgiSistemi
{
    public partial class LaboratuvarSonucEkle : System.Web.UI.Page
    {
        HastaneSistemEntities db = new HastaneSistemEntities();
        SqlConnection bgl = new SqlConnection("Data source=GEOPC\\SQLEXPRESS;Initial Catalog=HastaneSistem;Integrated Security=True;");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                TxtID.Enabled = false;
                int id = Convert.ToInt32(Request.QueryString["LaboratuvarID"]);
                var b = db.TblLaboratuvar.Find(id);
                TxtSonuc.Text = b.Sonuc;
                TxtID.Text = b.LaboratuvarID.ToString();
            }

        }

        protected void BtnEkle_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(Request.QueryString["LaboratuvarID"]);
            var b = db.TblLaboratuvar.Find(id);
            b.Sonuc = TxtSonuc.Text;
            // Ekleme methoduna atanmış parametreleri atmak
            db.SaveChanges();  // Değişiklikleri kaydetmek
            Response.Redirect("Laboratuvarlar.aspx");
        }
    }
}