
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace HastaneBilgiSistemi
{
    public partial class YeniMuayeneEkle : System.Web.UI.Page
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


            // Dropdownlistte Bölümleri Listeleme işlemi

            SqlCommand komut3 = new SqlCommand("Select BolumID,Bolum from TblBolum", bgl);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                DropBolum.Items.Add(dr3["Bolum"].ToString());
            }
            dr3.Close();
            bgl.Close();

        }

        protected void BtnServisEkle_Click(object sender, EventArgs e)
        {
            TblMuayene b = new TblMuayene();

            // DropDoktordan gelen doktor adını değişkene atamak

            var dropdoktor = DropDoktor.SelectedValue;

            // Değişkendeki isme ait ID yi Doktor tablosunda bulmak ve başka bir değişkene atamak 

            var doktor = db.TblDoktor.Where(x => x.Doktor == dropdoktor).Select(c => c.DoktorID).FirstOrDefault();

            // DropHastadan gelen hasta adını değişkene atamak

            var drophasta = DropHasta.SelectedValue;

            // Değişkendeki isme ait ID yi Hasta tablosunda bulmak ve başka bir değişkene atamak 

            var hasta = db.TblHasta.Where(x => x.Hasta == drophasta).Select(c => c.HastaID).FirstOrDefault();

            // DropBolumden gelen bölüm adını değişkene atamak

            var dropbolum = DropBolum.SelectedValue;

            // Değişkendeki isme ait ID yi Bölüm tablosunda bulmak ve başka bir değişkene atamak 

            var bolum = db.TblBolum.Where(x => x.Bolum == dropbolum).Select(c => c.BolumID).FirstOrDefault();

            // Ekleme işlemleri için atama yapmak 

            b.Doktor = Convert.ToInt32(doktor);
            b.Hasta = Convert.ToInt32(hasta);
            b.Bolum = Convert.ToInt32(bolum);
            b.Oyku = TxtOyku.Text;
            b.Teshis = TxtTeshis.Text;
            b.Tedavi = TxtTedavi.Text;
            b.Ilaclar = TxtIlac.Text;
            db.TblMuayene.Add(b);  // Ekleme methoduna atanmış parametreleri atmak
            db.SaveChanges();  // Değişiklikleri kaydetmek
            Response.Redirect("Muayeneler.aspx");
        }
    }
}