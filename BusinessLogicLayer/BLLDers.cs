using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesLayer;
using Entity_Layer;
namespace BusinessLogicLayer
{
    public class BLLDers
    {
        public static List<EntityDers> BLLListele()
        {
            return DALDers.DersListesi();
        }

        public static int BLLTalepEkle(EntityBasvuruForm p)
        {
            if (p.BASVURUOGRID!=null && p.BASVURUDERSID!=null )
            {
                return DALDers.TalepEkle(p);
            }
            return -1;
        }

    }
}
