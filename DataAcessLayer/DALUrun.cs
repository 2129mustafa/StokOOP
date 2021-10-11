using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;

namespace DataAcessLayer
{
    public class DALUrun
    {
        public static List<EntityUrun> UrunListesi()
        {
            List<EntityUrun> degerler = new List<EntityUrun>();
            SqlCommand komut = new SqlCommand("Select * from TBLURUN", Baglanti.bgl);
            if (komut.Connection.State!=ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityUrun ent = new EntityUrun();
                ent.Urunid = Convert.ToInt16(dr["URUNID"].ToString());
                ent.Urunad = dr["URUNAD"].ToString();
                ent.Urunfiyat = decimal.Parse(dr["URUNFIYAT"].ToString());
                ent.Urunadet = Convert.ToInt16(dr["URUNADET"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static int UrunEkle(EntityUrun p)
        {
            SqlCommand komut = new SqlCommand("insert into TBLURUN (URUNAD,URUNFIYAT,URUNADET) VALUES (@P1,@P2,@P3)", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@P1", p.Urunad);
            komut.Parameters.AddWithValue("@P2", p.Urunfiyat);
            komut.Parameters.AddWithValue("@P3", p.Urunadet);
            return komut.ExecuteNonQuery();
        }
        public static bool UrunSil(int p)
        {
            SqlCommand komut = new SqlCommand("Delete from TBLURUN WHERE URUNID=@P1", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@P1", p);
            return komut.ExecuteNonQuery() > 0;
        }
        public static List<EntityUrun> UrunGetir(int id)
        {
            List<EntityUrun> degerler = new List<EntityUrun>();
            SqlCommand komut = new SqlCommand("Select * from TBLURUN where URUNID=@P1", Baglanti.bgl);
            komut.Parameters.AddWithValue("@P1", id);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityUrun ent = new EntityUrun();
               // ent.Urunid = Convert.ToInt16(dr["URUNID"].ToString());
                ent.Urunad = dr["URUNAD"].ToString();
                ent.Urunfiyat = decimal.Parse(dr["URUNFIYAT"].ToString());
                ent.Urunadet = Convert.ToInt16(dr["URUNADET"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static bool UrunGuncelle(EntityUrun p)
        {
            SqlCommand komut = new SqlCommand("Update TBLURUN set URUNAD=@P1,URUNFIYAT=@P2,URUNADET=@P3 where URUNID=@P4", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@P1", p.Urunad);
            komut.Parameters.AddWithValue("@P2", p.Urunfiyat);
            komut.Parameters.AddWithValue("@P3", p.Urunadet);
            komut.Parameters.AddWithValue("@P4", p.Urunid);
            return komut.ExecuteNonQuery() > 0;
        }
    }
}
