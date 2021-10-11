using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using EntityLayer;

namespace DataAcessLayer
{
    public class DALMusteri
    {
        public static List<EntityMusteri> MusteriListesi()
        {
            List<EntityMusteri> degerler = new List<EntityMusteri>();
            SqlCommand komut = new SqlCommand("Select * from TBLMUSTERI", Baglanti.bgl);
            if (komut.Connection.State!=ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityMusteri ent = new EntityMusteri();
                ent.Musteriid = Convert.ToInt16(dr["MUSTERIID"].ToString());
                ent.Musteriad = dr["MUSTERIAD"].ToString();
                ent.Musterisoyad = dr["MUSTERISOYAD"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static int MusteriEkle(EntityMusteri p)
        {
            SqlCommand komut = new SqlCommand("insert into TBLMUSTERI (MUSTERIAD,MUSTERISOYAD) VALUES (@P1,@P2)", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@P1", p.Musteriad);
            komut.Parameters.AddWithValue("@P2", p.Musterisoyad);
            return komut.ExecuteNonQuery();
        }
        public static bool MusteriSil(int p)
        {
            SqlCommand komut = new SqlCommand("Delete from TBLMUSTERI WHERE MUSTERIID=@P1", Baglanti.bgl);
            if (komut.Connection.State!=ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@P1", p);
            return komut.ExecuteNonQuery() > 0;
        }
        public static List<EntityMusteri> MusteriGetir(int id)
        {
            List<EntityMusteri> degerler = new List<EntityMusteri>();
            SqlCommand komut = new SqlCommand("Select * from TBLMUSTERI where MUSTERIID=@P1", Baglanti.bgl);
            komut.Parameters.AddWithValue("@P1", id);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityMusteri ent = new EntityMusteri();
                //ent.Musteriid = Convert.ToInt16(dr["MUSTERIID"].ToString());
                ent.Musteriad = dr["MUSTERIAD"].ToString();
                ent.Musterisoyad = dr["MUSTERISOYAD"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static bool MusterGuncelle(EntityMusteri p)
        {
            SqlCommand komut = new SqlCommand("Update TBLMUSTERI set MUSTERIAD=@P1,MUSTERISOYAD=@P2 where MUSTERIID=@P3", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@P1", p.Musteriad);
            komut.Parameters.AddWithValue("@P2", p.Musterisoyad);
            komut.Parameters.AddWithValue("@P3", p.Musteriid);
            return komut.ExecuteNonQuery() > 0;
        }
    }
}
