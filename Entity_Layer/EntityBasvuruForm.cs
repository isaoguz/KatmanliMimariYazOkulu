using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer
{
    public class EntityBasvuruForm
    {
        private int basvuruid;
        private int basvurudersid;
        private int basvuruogrid;

        public int BASVURUID { get => basvuruid; set => basvuruid = value; }
        public int BASVURUDERSID { get => basvurudersid; set => basvurudersid = value; }
        public int BASVURUOGRID { get => basvuruogrid; set => basvuruogrid = value; }
    }
}
