using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entity_Layer;
using DataAccesLayer;
using BusinessLogicLayer;
namespace YazOkulu
{
    public partial class OgrenciGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["OGRID"]);
            Txtid.Text = x.ToString();
            Txtid.Enabled = false;

            if (Page.IsPostBack==false)
            {


            EntitiyOgrenci ent = new EntitiyOgrenci();
            List<EntitiyOgrenci> OgrList = BLLOgrenci.BLLOgrenciDetayListele(x);
            TxtAd.Text = OgrList[0].AD.ToString();
            TxtSoyad.Text = OgrList[0].SOYAD.ToString();
            TxtNumara.Text = OgrList[0].NUMARA.ToString();
            TxtFotograf.Text = OgrList[0].FOTOGRAF.ToString();
            TxtSifre.Text = OgrList[0].SIFRE.ToString();

            }
        }

        protected void BtnGuncelle_Click(object sender, EventArgs e)
        {
            EntitiyOgrenci ent = new EntitiyOgrenci();
            ent.AD = TxtAd.Text;
            ent.SOYAD = TxtSoyad.Text;
            ent.SIFRE = TxtSifre.Text;
            ent.NUMARA = TxtNumara.Text;
            ent.FOTOGRAF = TxtFotograf.Text;
            ent.ID =  Convert.ToInt32( Txtid.Text);
            BLLOgrenci.OgrenciGuncelleBLL(ent);
            Response.Redirect("OgrenciListesi.aspx");

        }
    }
}