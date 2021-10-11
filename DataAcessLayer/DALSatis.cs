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
    public class DALSatis
    {
        public static List<EntitySatis> SatisListesi()
        {
            List<EntitySatis> degerler = new List<EntitySatis>();
            SqlCommand komut = new SqlCommand("SATISLAR", Baglanti.bgl);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntitySatis ent = new EntitySatis();
                ent.Satisid = Convert.ToInt16(dr["SATISID"].ToString());
                ent.Urunad = dr["URUNAD"].ToString();
                ent.Personelad = dr["PERSONEL"].ToString();
                //ent.Personelsoyad = dr["PERSONELSOYAD"].ToString();
                ent.Musteriad = dr["MUSTERI"].ToString();
                //ent.Musterisoyad = dr["MUSTERISOYAD"].ToString();
                ent.Fiyat = decimal.Parse(dr["TUTAR"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static int SatisEkle(EntitySatis p)
        {
            SqlCommand komut = new SqlCommand("insert into TBLSATIS (URUN,PERSONEL,MUSTERI,TUTAR) VALUES (@P1,@P2,@P3,@P4)", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@P1", p.Urun);
            komut.Parameters.AddWithValue("@P2", p.Personel);
            komut.Parameters.AddWithValue("@P3", p.Musteri);
            komut.Parameters.AddWithValue("@P4", p.Fiyat);
            return komut.ExecuteNonQuery();
        }
        public static bool SatisSil(int p)
        {
            SqlCommand komut = new SqlCommand("Delete from TBLSATIS WHERE SATISID=@P1", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@P1", p);
            return komut.ExecuteNonQuery() > 0;
        }
        public static List<EntitySatis> SatisGetir(int id)
        {
            List<EntitySatis> degerler = new List<EntitySatis>();
            SqlCommand komut = new SqlCommand("select * FROM TBLSATIS WHERE SATISID=@P1", Baglanti.bgl);
            komut.Parameters.AddWithValue("@P1", id);
           
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntitySatis ent = new EntitySatis();
               // ent.Satisid = Convert.ToInt16(dr["SATISID"].ToString());
                ent.Urunad = dr["URUN"].ToString();
                ent.Personelad = dr["PERSONEL"].ToString();
                //ent.Personelsoyad = dr["PERSONELSOYAD"].ToString();
                ent.Musteriad = dr["MUSTERI"].ToString();
                //ent.Musterisoyad = dr["MUSTERISOYAD"].ToString();
                ent.Fiyat = decimal.Parse(dr["TUTAR"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static bool SatisGuncelle(EntitySatis p)
        {
            SqlCommand komut = new SqlCommand("Update TBLSATIS set URUN=@P1,PERSONEL=@P2,MUSTERI=@P3,TUTAR=@P4 where SATISID=@P5", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@P1", p.Urun);
            komut.Parameters.AddWithValue("@P2", p.Personel);
            komut.Parameters.AddWithValue("@P3", p.Musteri);
            komut.Parameters.AddWithValue("@P4", p.Fiyat);
            komut.Parameters.AddWithValue("@P5", p.Satisid);
            return komut.ExecuteNonQuery() > 0;
        }
    }
}
