using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using EntityLayer;
using BusinessLogicLayer;
using DataAcessLayer;

namespace StokOOP
{
    public partial class UrunGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(Request.QueryString["URUNID"]);
            TextBox4.Text = x.ToString();
            
            if (Page.IsPostBack == false)
            {
                SqlCommand komut = new SqlCommand("Select * from TBLURUN", Baglanti.bgl);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DropDownListUrun.DataValueField = "URUNID";
                DropDownListUrun.DataTextField = "URUNAD";         
                DropDownListUrun.DataSource = dt;
                DropDownListUrun.DataBind();

                List<EntityUrun> UrunList = BLLUrun.BLLUrunGetir(x);
                TextBox2.Text = UrunList[0].Urunfiyat.ToString();
                TextBox3.Text = UrunList[0].Urunadet.ToString();
               // DropDownListUrun.Text = UrunList[0].Urunad.ToString();
           }
        }

        

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityUrun ent = new EntityUrun();
            ent.Urunad =DropDownListUrun.SelectedValue;
            ent.Urunfiyat =decimal.Parse (TextBox2.Text);
            ent.Urunadet = int.Parse(TextBox3.Text);
            ent.Urunid = int.Parse(TextBox4.Text);
            BLLUrun.BLLUrunGuncelle(ent);
            Response.Redirect("Urun.aspx");
        }
    }
}