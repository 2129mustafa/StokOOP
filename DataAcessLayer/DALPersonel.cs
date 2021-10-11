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
    public class DALPersonel
    {
        public static List<EntityPersonel> PersonelListesi()
        {
            List<EntityPersonel> degerler = new List<EntityPersonel>();
            SqlCommand komut = new SqlCommand("DEPARTMANLIST", Baglanti.bgl);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State!=ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader(); //js
            while (dr.Read())
            {
                EntityPersonel ent = new EntityPersonel();
                ent.Personelid = int.Parse(dr["PERSONELID"].ToString());
                ent.Personelad = dr["PERSONELAD"].ToString();
                ent.Personelsoyad = dr["PERSONELSOYAD"].ToString();
                ent.Personelmaas = decimal.Parse(dr["PERSONELMAAS"].ToString());
                //ent.Personeldepartman = Convert.ToInt16(dr["PERSONELDEPARTMAN"].ToString());
                ent.Personeldep = dr["DEPARTMANAD"].ToString();
                ent.Personelfotograf = dr["PERSONELFOTOGRAF"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static int PersonelEkle(EntityPersonel p)
        {
            SqlCommand komut = new SqlCommand("insert into TBLPERSONEL (PERSONELAD,PERSONELSOYAD,PERSONELDEPARTMAN,PERSONELMAAS) VALUES (@P1,@P2,@P3,@P4)", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@P1", p.Personelad);
            komut.Parameters.AddWithValue("@P2", p.Personelsoyad);
            komut.Parameters.AddWithValue("@P3", p.Personeldepartman);
            komut.Parameters.AddWithValue("@P4", p.Personelmaas);
            return komut.ExecuteNonQuery();
        }
        public static bool PersonelSil(int p)
        {
            SqlCommand komut = new SqlCommand("Delete from TBLPERSONEL WHERE PERSONELID=@P1", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@P1", p);
            return komut.ExecuteNonQuery() > 0;
        }
        public static List<EntityPersonel> PersonelGetir(int id)
        {
            List<EntityPersonel> degerler = new List<EntityPersonel>();
            SqlCommand komut = new SqlCommand("SELECT * FROM TBLPERSONEL WHERE PERSONELID=@P1", Baglanti.bgl);
            komut.Parameters.AddWithValue("@P1", id);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader(); //js
            while (dr.Read())
            {
                EntityPersonel ent = new EntityPersonel();
               // ent.Personelid = int.Parse(dr["PERSONELID"].ToString());
                ent.Personelad = dr["PERSONELAD"].ToString();
                ent.Personelsoyad = dr["PERSONELSOYAD"].ToString();
                ent.Personelmaas = decimal.Parse(dr["PERSONELMAAS"].ToString());
                ent.Personeldepartman = Convert.ToInt16(dr["PERSONELDEPARTMAN"].ToString());
               // ent.Personeldep = dr["PERSONELDEPARTMAN"].ToString();
                //ent.Personelfotograf = dr["PERSONELFOTOGRAF"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static bool PersonelGuncelle(EntityPersonel p)
        {
            SqlCommand komut = new SqlCommand("Update TBLPERSONEL set PERSONELAD=@P1,PERSONELSOYAD=@P2,PERSONELDEPARTMAN=@P3,PERSONELMAAS=@P4 where PERSONELID=@P5", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@P1", p.Personelad);
            komut.Parameters.AddWithValue("@P2", p.Personelsoyad);
            komut.Parameters.AddWithValue("@P3", p.Personeldepartman);
            komut.Parameters.AddWithValue("@P4", p.Personelmaas);
            komut.Parameters.AddWithValue("@P5", p.Personelid);
            return komut.ExecuteNonQuery() > 0;
        }
    }
}
