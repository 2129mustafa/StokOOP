using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAcessLayer;

namespace BusinessLogicLayer
{
    public class BLLSatis
    {
        public static List<EntitySatis> BLLSatisListesi()
        {
            return DALSatis.SatisListesi();
        }
        public static int BLLSatisEkle(EntitySatis p)
        {
            if (p.Fiyat != 0 && p.Musteri != 0 && p.Personel != 0 && p.Urun != 0)
            {
                return DALSatis.SatisEkle(p);
            }
            else
            {
                return -1;
            }
        }
        public static bool BLLSatisSil(int p)
        {
            if (p!=0)
            {
                return DALSatis.SatisSil(p);
            }
            return false;
        }
        public static List<EntitySatis> BLLSatisGetir(int p)
        {
            return DALSatis.SatisGetir(p);
        }
        public static bool BLLSatisGuncelle(EntitySatis p)
        {
            if (p.Urun!=0 && p.Personel!=0 && p.Musteri!=0 && p.Fiyat!=0 && p.Satisid!=0)
            {
                return DALSatis.SatisGuncelle(p);
            }
            return false;

        }

    } 
    
}
