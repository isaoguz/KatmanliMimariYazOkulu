using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entity_Layer;
namespace DataAccesLayer
{
    public class DALDers
    {
        public static List<EntityDers> DersListesi()
        {
            //ÖĞRENCİ LİSTELEME
            List<EntityDers> degerler = new List<EntityDers>();
            SqlCommand komut2 = new SqlCommand("Select * From TBLDERSLER", Baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            SqlDataReader oku = komut2.ExecuteReader();
            while (oku.Read())
            {
                EntityDers ent = new EntityDers();
                ent.ID = Convert.ToInt32(oku["DERSID"].ToString());
                ent.DERSAD = oku["DERSAD"].ToString();
                ent.MIN =int.Parse( oku["DERSMINKONT"].ToString());
                ent.MAX = int.Parse(oku["DERSMAKSKONT"].ToString());
                degerler.Add(ent);
            }
            oku.Close();
            return degerler;
        }
        public static int TalepEkle(EntityBasvuruForm parametre)
        {
            SqlCommand komut = new SqlCommand("insert into TBLBASVURUFORMU (OGRID,DERSID) values (@p1,@p2)",Baglanti.bgl);
            komut.Parameters.AddWithValue("@p1",parametre.BASVURUOGRID);
            komut.Parameters.AddWithValue("@p2", parametre.BASVURUDERSID);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            return komut.ExecuteNonQuery();

        }
    }
}
