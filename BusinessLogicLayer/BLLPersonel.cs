using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAcessLayer;

namespace BusinessLogicLayer
{
    public class BLLPersonel
    {
        public static List<EntityPersonel> PersonelListesi()
        {
            return DALPersonel.PersonelListesi();
        }
        public static int BLLPersonelEkle(EntityPersonel p)
        {
            if (p.Personelad != "" && p.Personelsoyad != "" && p.Personeldepartman>0)
            {
                return DALPersonel.PersonelEkle(p);
            }
            return -1;
        }
        public static bool BLLPersonelSil(int p)
        {
            if (p!=0)
            {
                return DALPersonel.PersonelSil(p);
            }
            return false;
        }
        public static List<EntityPersonel> BLLPersonelGetir(int p)
        {
            return DALPersonel.PersonelGetir(p);
        }
        public static bool BLLPersonelGuncelle(EntityPersonel p)
        {
            if (p.Personelad!= "" && p.Personelsoyad != "" && p.Personelmaas>0 && p.Personelid>0 && p.Personeldepartman!=0)
            {
                return DALPersonel.PersonelGuncelle(p);
            }
            return false;
          
        }

    }
}
