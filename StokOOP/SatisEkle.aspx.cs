using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;
using DataAcessLayer;
using BusinessLogicLayer;

namespace StokOOP
{
    public partial class SatisEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack==false)
            {
                SqlCommand komut = new SqlCommand("Select * from TBLURUN", Baglanti.bgl);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DropDownListUrun.DataValueField = "URUNID";
                DropDownListUrun.DataTextField = "URUNAD";
                DropDownListUrun.DataSource = dt;
                DropDownListUrun.DataBind();

                SqlCommand komut2 = new SqlCommand("SELECT PERSONELID,(PERSONELAD+' '+PERSONELSOYAD) AS 'PERSONELADSOYAD' FROM TBLPERSONEL", Baglanti.bgl);
                SqlDataAdapter da2 = new SqlDataAdapter(komut2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                DropDownListPersonel.DataValueField = "PERSONELID";
                DropDownListPersonel.DataTextField = "PERSONELADSOYAD";
                DropDownListPersonel.DataSource = dt2;
                DropDownListPersonel.DataBind();

                SqlCommand komut3 = new SqlCommand("SELECT MUSTERIID,(MUSTERIAD+' '+MUSTERISOYAD) AS 'MUSTERIADSOYAD' FROM TBLMUSTERI", Baglanti.bgl);
                SqlDataAdapter da3 = new SqlDataAdapter(komut3);
                DataTable dt3= new DataTable();
                da3.Fill(dt3);
                DropDownListMusteri.DataValueField = "MUSTERIID";
                DropDownListMusteri.DataTextField = "MUSTERIADSOYAD";
                DropDownListMusteri.DataSource = dt3;
                DropDownListMusteri.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntitySatis ent = new EntitySatis();
            ent.Urun = int.Parse(DropDownListUrun.SelectedValue);
            ent.Personel = int.Parse(DropDownListPersonel.SelectedValue);
            ent.Musteri = int.Parse(DropDownListMusteri.SelectedValue);
            ent.Fiyat = decimal.Parse(TextBox1.Text);
            BLLSatis.BLLSatisEkle(ent);
            Response.Redirect("Satis.aspx");
        }
    }
}