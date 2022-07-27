
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
    public partial class KonsultasyonIste : System.Web.UI.Page
    {
        HastaneSistemEntities db = new HastaneSistemEntities();
        SqlConnection bgl = new SqlConnection("Data source=GEOPC\\SQLEXPRESS;Initial Catalog=HastaneSistem;Integrated Security=True;");
        protected void Page_Load(object sender, EventArgs e)
        {
            TxtID.Enabled = false;
            TxTblHasta.Enabled = false;

            if (!Page.IsPostBack)
            {

                // Sayfadan dönen ID yi bulmak 

                int id = Convert.ToInt32(Request.QueryString["MuayeneID"]);

                var x = db.TblMuayene.Find(id);
                var hasta = x.Hasta;
                var hastaadi = db.TblHasta.Where(b => b.HastaID == hasta).Select(n => n.Hasta).FirstOrDefault();

                // Muayene tablosundaki IDdeki hastanın adını bulma 

                // Adını Texte yazdırma
                TxTblHasta.Text = hastaadi;
                TxtID.Text = x.MuayeneID.ToString();

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


                // Dropdownlistte Bölümleri Listeleme işlemi

                SqlCommand komut2 = new SqlCommand("Select * from TblBolum", bgl);
                if (komut2.Connection.State != ConnectionState.Open)
                {
                    komut2.Connection.Open();
                }
                SqlDataReader dr2 = komut2.ExecuteReader();
                while (dr2.Read())
                {
                    DropBolum.Items.Add(dr2["Bolum"].ToString());
                }
                dr2.Close();
                bgl.Close();

                //// Dropdownlistte Bölümleri Listeleme işlemi

                //SqlCommand komut3 = new SqlCommand("Select BolumID,Bolum from TblBolum", bgl);
                //if (komut3.Connection.State != ConnectionState.Open)
                //{
                //    komut3.Connection.Open();
                //}
                //SqlDataReader dr3 = komut3.ExecuteReader();
                //while (dr3.Read())
                //{
                //    DropBolum.Items.Add(dr3["Bolum"].ToString());
                //}
                //dr3.Close();
                //bgl.Close();
            }
        }

        protected void BtnEkle_Click(object sender, EventArgs e)
        {
            TblMuayene b = new TblMuayene();

            // Textteki hastanın değişkene atanması

            var hastaadi = TxTblHasta.Text;

            // Değişkendeki hastanın ID sinin bulunması

            var hastaid = db.TblHasta.Where(g => g.Hasta == hastaadi).Select(n => n.HastaID).FirstOrDefault();

            // DropDoktordan gelen doktor adını değişkene atamak

            var dropdoktor = DropDoktor.SelectedValue;

            // Değişkendeki isme ait ID yi Doktor tablosunda bulmak ve başka bir değişkene atamak 

            var doktor = db.TblDoktor.Where(x => x.Doktor == dropdoktor).Select(c => c.DoktorID).FirstOrDefault();

            // DropBolumden gelen bölüm adını değişkene atamak

            var dropbolum = DropBolum.SelectedValue;

            // Değişkendeki isme ait ID yi Bölüm tablosunda bulmak ve başka bir değişkene atamak 

            var bolum = db.TblBolum.Where(x => x.Bolum == dropbolum).Select(c => c.BolumID).FirstOrDefault();

            // Ekleme işlemleri için atama yapmak 

            b.Doktor = Convert.ToInt32(doktor);
            b.Hasta = Convert.ToInt32(hastaid);
            b.Bolum = Convert.ToInt32(bolum);
            b.Oyku = TxtOyku.Text;
            b.Teshis = TxtTeshis.Text;
            b.Tedavi = TxtTedavi.Text;
            b.Ilaclar = TxtIlac.Text;
            db.TblMuayene.Add(b);  // Ekleme methoduna atanmış parametreleri atmak
            db.SaveChanges();  // Değişiklikleri kaydetmek
            Response.Write("<script>alert('Konsültasyon Başarıyla Eklendi !')</script>");
            Response.Redirect("Muayeneler.aspx");
        }
    }
}