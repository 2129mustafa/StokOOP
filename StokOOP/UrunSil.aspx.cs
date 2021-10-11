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
    public partial class UrunSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(Request.QueryString["URUNID"]);
            EntityUrun ent = new EntityUrun();
            ent.Urunid = x;
            BLLUrun.BLLUrunSil(ent.Urunid);
            Response.Redirect("Urun.aspx");
        }
    }
}