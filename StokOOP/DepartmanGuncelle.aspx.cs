using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAcessLayer;
using BusinessLogicLayer;

namespace StokOOP
{
    public partial class DepartmanGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["DEPARTMANID"]);
            TextBox1.Text = x.ToString();
            EntityDepartman ent = new EntityDepartman();
            if (Page.IsPostBack == false)
            {
                List<EntityDepartman> DepList = BLLDepartman.BLLDepartmanGetir(int.Parse(TextBox1.Text));
                TextBox2.Text = DepList[0].Departmanad.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityDepartman ent = new EntityDepartman();
            ent.Departmanid = Convert.ToInt16(TextBox1.Text);
            ent.Departmanad = TextBox2.Text;
            BLLDepartman.BLLDepartmanGuncelle(ent);
            Response.Redirect("WebForm1.aspx");
        }
    }
}