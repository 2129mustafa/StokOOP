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
    public partial class DepartmanSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(Request.QueryString["DEPARTMANID"]);
            EntityDepartman ent = new EntityDepartman();
            ent.Departmanid = x;
            BLLDepartman.BLLDepartmanSil(ent.Departmanid);
            Response.Redirect("WebForm1.aspx");
        }
    }
}