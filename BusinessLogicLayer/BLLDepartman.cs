using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcessLayer;
using EntityLayer;

namespace BusinessLogicLayer
{
    public class BLLDepartman
    {
        public static List<EntityDepartman> BLLDepartmanListele()
        {
            return DALDepartman.DepartmanListesi();
        }
        public static int BLLDepartmanEkle(EntityDepartman p)
        {
            if (p.Departmanad!="")
            {
                return DALDepartman.DepartmanEkle(p);
            }
            return -1;
        }
        public static bool BLLDepartmanSil(int p)
        {
            if (p!=0)
            {
                return DALDepartman.DepartmanSil(p);
            }
            return false;
        }
        public static List<EntityDepartman> BLLDepartmanGetir(int p)
        {
            return DALDepartman.DepartmanGetir(p);
        }
        public static bool BLLDepartmanGuncelle(EntityDepartman p)
        {
            if (p.Departmanad != "" && p.Departmanid != 0)
            {
                return DALDepartman.DepartmanGuncelle(p);
            }
            return false;
        }
    }
}
