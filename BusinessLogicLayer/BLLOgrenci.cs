using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity_Layer;
using DataAccesLayer;
namespace BusinessLogicLayer
{
    public class BLLOgrenci
    {
        public static int OgrenciEkleBLL(EntitiyOgrenci p)
        {
            if (p.AD!=null && p.SOYAD!=null && p.NUMARA!=null && p.SIFRE!=null && p.FOTOGRAF!=null)
            {
                return DALOgrenci.OgrenciEkle(p);
            }
            return -1;
        } 
        public static List<EntitiyOgrenci> BLLListele()
        {
            return DALOgrenci.OgrenciListesi();
        }

        public static bool OgrenciSilBLL(int p)
        {
            if (p >=0)
            {
                return DALOgrenci.OgrenciSil(p);
            }
            return false;
        }

        public static List<EntitiyOgrenci> BLLOgrenciDetayListele(int p)
        {
            return DALOgrenci.OgrenciDetayListesi(p);
        }

        public static bool OgrenciGuncelleBLL(EntitiyOgrenci p)
        {
            if (p.AD!=null && p.AD!="" && p.SOYAD!=null&& p.SOYAD != "" && p.NUMARA!=null  && p.NUMARA != "" && p.SIFRE!=null && p.SIFRE != "" && p.FOTOGRAF!=null && p.SIFRE != "" && p.ID!=null )
            {
                return DALOgrenci.OgrenciGuncelle(p);
            }
            return false;
        }
    }
}
