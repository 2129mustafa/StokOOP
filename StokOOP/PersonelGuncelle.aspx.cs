using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAcessLayer;
using BusinessLogicLayer;
using System.Data.SqlClient;
using System.Data;

namespace StokOOP
{
    public partial class PersonelGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            int x = Convert.ToInt32(Request.QueryString["PERSONELID"]);
            TextBox4.Text = x.ToString();
            EntityPersonel ent = new EntityPersonel();
            if (Page.IsPostBack == false)
            {
                SqlCommand komut = new SqlCommand("select * from TBLDEPARTMAN", Baglanti.bgl);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DropDownList1.DataValueField = "DEPARTMANID";
                DropDownList1.DataTextField = "DEPARTMANAD";
                DropDownList1.DataSource = dt;
                DropDownList1.DataBind();

                List<EntityPersonel> PerList = BLLPersonel.BLLPersonelGetir(x);   
                TextBox1.Text = PerList[0].Personelad.ToString();
                TextBox2.Text = PerList[0].Personelsoyad.ToString();
                TextBox3.Text = PerList[0].Personelmaas.ToString();
                DropDownList1.Text = PerList[0].Personeldepartman.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Personelad = TextBox1.Text;
            ent.Personelsoyad = TextBox2.Text;
            ent.Personeldepartman = int.Parse(DropDownList1.SelectedValue);
            ent.Personelmaas = decimal.Parse(TextBox3.Text);
            ent.Personelid = int.Parse(TextBox4.Text);
            BLLPersonel.BLLPersonelGuncelle(ent);
            Response.Redirect("Personel.aspx");
        }
    }
}