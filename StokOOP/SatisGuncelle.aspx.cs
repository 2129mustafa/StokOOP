using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using EntityLayer;
using DataAcessLayer;
using BusinessLogicLayer;

namespace StokOOP
{
    public partial class SatisGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(Request.QueryString["SATISID"]);
            TextBox2.Text = x.ToString();
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
                DataTable dt3 = new DataTable();
                da3.Fill(dt3);
                DropDownListMusteri.DataValueField = "MUSTERIID";
                DropDownListMusteri.DataTextField = "MUSTERIADSOYAD";
                DropDownListMusteri.DataSource = dt3;
                DropDownListMusteri.DataBind();

                List<EntitySatis> SatList = BLLSatis.BLLSatisGetir(x);
                TextBox1.Text = SatList[0].Fiyat.ToString();
        


            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntitySatis ent = new EntitySatis();
            ent.Fiyat = decimal.Parse(TextBox1.Text);
            ent.Urun = Convert.ToInt16(DropDownListUrun.SelectedValue);
            ent.Personel = Convert.ToInt16(DropDownListPersonel.SelectedValue);
            ent.Musteri = Convert.ToInt16(DropDownListMusteri.SelectedValue);
            ent.Satisid = Convert.ToInt16(TextBox2.Text);
            BLLSatis.BLLSatisGuncelle(ent);
            Response.Redirect("Satis.aspx");
        }
    }
}