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
    public partial class YazOkuluAnasayfa1 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntitiyOgrenci ent = new EntitiyOgrenci();
            ent.AD = TxtAd.Text;
            ent.SOYAD = TxtSoyad.Text;
            ent.NUMARA = TxtNumara.Text;
            ent.SIFRE = TxtSifre.Text;
            ent.FOTOGRAF = TxtFotograf.Text;
            BLLOgrenci.OgrenciEkleBLL(ent);
        }
    }
}