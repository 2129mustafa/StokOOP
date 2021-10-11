using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAcessLayer;

namespace BusinessLogicLayer
{
    public class BLLUrun
    {
        public static List<EntityUrun> BLLUrunListesi()
        {
            return DALUrun.UrunListesi();
        }
        public static int BLLUrunEkle(EntityUrun p)
        {
            if (p.Urunad!="" && p.Urunfiyat!=0 && p.Urunadet!=0 && p.Urunfiyat>=1)
            {
                return DALUrun.UrunEkle(p);
            }
            return -1;
        }
        public static bool BLLUrunSil(int p)
        {
            if (p!=0)
            {
                return DALUrun.UrunSil(p);
            }
            return false;
        }
        public static List<EntityUrun> BLLUrunGetir(int p)
        {
            return DALUrun.UrunGetir(p);
        }
        public static bool BLLUrunGuncelle(EntityUrun p)
        {
            if (p.Urunid > 0 && p.Urunad != "" && p.Urunfiyat>0 && p.Urunadet>0)
            {
                return DALUrun.UrunGuncelle(p);
            }
            return false;

        }
    }
}
