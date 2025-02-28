﻿using System;
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
    public partial class MusteriGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["MUSTERIID"]);
            TextBox3.Text = x.ToString();
            EntityMusteri ent = new EntityMusteri();
            if (Page.IsPostBack==false)
            {
                List<EntityMusteri> MusList = BLLMusteri.BLLMusteriGetir(x);
                TextBox1.Text = MusList[0].Musteriad.ToString();
                TextBox2.Text = MusList[0].Musterisoyad.ToString();
            }
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityMusteri ent = new EntityMusteri();
            ent.Musteriad = TextBox1.Text;
            ent.Musterisoyad = TextBox2.Text;
            ent.Musteriid = Convert.ToInt16(TextBox3.Text);
            BLLMusteri.BLLMusteriGuncelle(ent);
            Response.Redirect("Musteriler.aspx");
        }
    }
}