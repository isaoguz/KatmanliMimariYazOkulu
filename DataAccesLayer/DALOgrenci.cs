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
    public class DALOgrenci
    {
        public static int OgrenciEkle(EntitiyOgrenci parametre)
        {
            //ÖĞRENCİ EKLEME
            SqlCommand komut1 = new SqlCommand("insert into TBLOGRENCILER (OGRAD,OGRSOYAD,OGRNUMARA,OGRFOTO,OGRSIFRE) values (@p1,@p2,@p3,@p4,@p5)",Baglanti.bgl);
            if (komut1.Connection.State!=ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            komut1.Parameters.AddWithValue("@p1",parametre.AD);
            komut1.Parameters.AddWithValue("@p2", parametre.SOYAD);
            komut1.Parameters.AddWithValue("@p3", parametre.NUMARA);
            komut1.Parameters.AddWithValue("@p4", parametre.FOTOGRAF);
            komut1.Parameters.AddWithValue("@p5", parametre.SIFRE);
            return komut1.ExecuteNonQuery();
        }
        public static List<EntitiyOgrenci> OgrenciListesi()
        {
            //ÖĞRENCİ LİSTELEME
            List<EntitiyOgrenci> degerler = new List<EntitiyOgrenci>();
            SqlCommand komut2 = new SqlCommand("Select * From TBLOGRENCILER",Baglanti.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            SqlDataReader oku = komut2.ExecuteReader();
            while (oku.Read())
            {
                EntitiyOgrenci ent = new EntitiyOgrenci();
                ent.ID = Convert.ToInt32(oku["OGRID"].ToString());
                ent.AD = oku["OGRAD"].ToString();
                ent.SOYAD = oku["OGRSOYAD"].ToString();
                ent.NUMARA = oku["OGRNUMARA"].ToString();
                ent.FOTOGRAF = oku["OGRFOTO"].ToString();
                ent.SIFRE = oku["OGRSIFRE"].ToString();
                ent.BAKIYE = Convert.ToDouble(oku["OGRBAKIYE"].ToString());
                degerler.Add(ent);
            }
            oku.Close();
           return degerler;
        }
        public static bool OgrenciSil(int parametre)
        {
            //ÖĞRENCİ SİLME
            SqlCommand komut3 = new SqlCommand("Delete From TBLOGRENCILER Where OGRID=@p1",Baglanti.bgl);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@p1",parametre);
            return komut3.ExecuteNonQuery()>0;
        }

        public static List<EntitiyOgrenci> OgrenciDetayListesi(int id)
        {
            //ÖĞRENCİ LİSTELEME
            List<EntitiyOgrenci> degerler = new List<EntitiyOgrenci>();
            SqlCommand komut4 = new SqlCommand("Select * From TBLOGRENCILER Where OGRID=@p1", Baglanti.bgl);
            komut4.Parameters.AddWithValue("@p1",id);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            SqlDataReader oku = komut4.ExecuteReader();
            while (oku.Read())
            {
                EntitiyOgrenci ent = new EntitiyOgrenci();
                ent.AD = oku["OGRAD"].ToString();
                ent.SOYAD = oku["OGRSOYAD"].ToString();
                ent.NUMARA = oku["OGRNUMARA"].ToString();
                ent.FOTOGRAF = oku["OGRFOTO"].ToString();
                ent.SIFRE = oku["OGRSIFRE"].ToString();
                ent.BAKIYE = Convert.ToDouble(oku["OGRBAKIYE"].ToString());
                degerler.Add(ent);
            }
            oku.Close();
            return degerler;
        }

        public static bool OgrenciGuncelle(EntitiyOgrenci deger)
        {
            SqlCommand komut5 = new SqlCommand("Update TBLOGRENCILER SET OGRAD=@P1,OGRSOYAD=@P2," +
                "OGRNUMARA=@P3,OGRFOTO=@P4,OGRSIFRE=@P5 WHERE OGRID=@P6",Baglanti.bgl);
            if (komut5.Connection.State!=ConnectionState.Open)
            {
                komut5.Connection.Open();
            }
            komut5.Parameters.AddWithValue("@P1",deger.AD);
            komut5.Parameters.AddWithValue("@P2", deger.SOYAD);
            komut5.Parameters.AddWithValue("@P3", deger.NUMARA);
            komut5.Parameters.AddWithValue("@P4", deger.FOTOGRAF);
            komut5.Parameters.AddWithValue("@P5", deger.SIFRE);
            komut5.Parameters.AddWithValue("@P6", deger.ID);
            return komut5.ExecuteNonQuery() >0;

        }
    }
}
