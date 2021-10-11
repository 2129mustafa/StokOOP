using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data;
using System.Data.SqlClient;

namespace DataAcessLayer
{
    public class DALDepartman
    {
        public static List<EntityDepartman> DepartmanListesi()
        {
            List<EntityDepartman> degerler = new List<EntityDepartman>();
            SqlCommand komut = new SqlCommand("Select * from TBLDEPARTMAN", Baglanti.bgl);
            if (komut.Connection.State!=ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityDepartman ent = new EntityDepartman();
                ent.Departmanid = Convert.ToInt16(dr["DEPARTMANID"].ToString());
                ent.Departmanad = dr["DEPARTMANAD"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
        public static int DepartmanEkle(EntityDepartman p)
        {
            SqlCommand komut = new SqlCommand("insert into TBLDEPARTMAN (DEPARTMANAD) VALUES (@P1)", Baglanti.bgl);         
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@P1", p.Departmanad);
            return komut.ExecuteNonQuery();
        }
        public static bool DepartmanSil(int p)
        {
            SqlCommand komut = new SqlCommand("Delete from TBLDEPARTMAN where DEPARTMANID=@P1", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@P1", p);
            return komut.ExecuteNonQuery() > 0;
        }
        public static List<EntityDepartman> DepartmanGetir(int id)
        {
            List<EntityDepartman> degerler = new List<EntityDepartman>();
            SqlCommand komut = new SqlCommand("Select * from TBLDEPARTMAN where DEPARTMANID=@P1", Baglanti.bgl);
            komut.Parameters.AddWithValue("@P1", id);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityDepartman ent = new EntityDepartman();
               // ent.Departmanid = Convert.ToInt16(dr["DEPARTMANID"].ToString());
                ent.Departmanad = dr["DEPARTMANAD"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static bool DepartmanGuncelle(EntityDepartman p)
        {
            SqlCommand komut = new SqlCommand("Update TBLDEPARTMAN set DEPARTMANAD=@P1 where DEPARTMANID=@P2", Baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@P1",p.Departmanad );
            komut.Parameters.AddWithValue("@P2", p.Departmanid);
            return komut.ExecuteNonQuery() > 0;
        }
    }
}
