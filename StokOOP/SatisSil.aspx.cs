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
    public partial class SatisSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(Request.QueryString["SATISID"]);
            EntitySatis ent = new EntitySatis();
            ent.Satisid = x;
            BLLSatis.BLLSatisSil(ent.Satisid);
            Response.Redirect("Satis.aspx");
        }
    }
}