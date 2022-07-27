
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
    public partial class YeniLaboratuvarEkle : System.Web.UI.Page
    {
        HastaneSistemEntities db = new HastaneSistemEntities();
        SqlConnection bgl = new SqlConnection("Data source=GEOPC\\SQLEXPRESS;Initial Catalog=HastaneSistem;Integrated Security=True;");
        protected void Page_Load(object sender, EventArgs e)
        {

            // Dropdownlistte Doktorları Listeleme işlemi

            SqlCommand komut = new SqlCommand("Select * from TblDoktor", bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                DropDoktor.Items.Add(dr["Doktor"].ToString());
            }
            dr.Close();
            bgl.Close();


            // Dropdownlistte Hastaları Listeleme işlemi

            SqlCommand komut2 = new SqlCommand("Select HastaID,Hasta from TblHasta", bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                DropHasta.Items.Add(dr2["Hasta"].ToString());
            }
            dr2.Close();
            bgl.Close();

        }

        protected void BtnEkle_Click(object sender, EventArgs e)
        {
            TblLaboratuvar b = new TblLaboratuvar();

            // DropDoktordan gelen doktor adını değişkene atamak

            string dropdoktor = DropDoktor.SelectedValue;

            // Değişkendeki isme ait ID yi Doktor tablosunda bulmak ve başka bir değişkene atamak 

            int doktor = db.TblDoktor.Where(x => x.Doktor == dropdoktor).Select(c => c.DoktorID).FirstOrDefault();

            // DropHastadan gelen hasta adını değişkene atamak

            string drophasta = DropHasta.SelectedValue;

            // Değişkendeki isme ait ID yi Hasta tablosunda bulmak ve başka bir değişkene atamak 

            int hasta = db.TblHasta.Where(x => x.Hasta == drophasta).Select(c => c.HastaID).FirstOrDefault();

            // Ekleme işlemleri için atama yapmak 

            b.Doktor = Convert.ToInt32(doktor);
            b.Hasta = Convert.ToInt32(hasta);
            b.Talep = TxtTahlil.Text;
            db.TblLaboratuvar.Add(b);  // Ekleme methoduna atanmış parametreleri atmak
            db.SaveChanges();  // Değişiklikleri kaydetmek
            Response.Redirect("Laboratuvarlar.aspx");
        }
    }
}