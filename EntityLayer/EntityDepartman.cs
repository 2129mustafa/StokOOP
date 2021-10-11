using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityDepartman
    {
        private int departmanid;
        private string departmanad;

        public int Departmanid { get => departmanid; set => departmanid = value; }
        public string Departmanad { get => departmanad; set => departmanad = value; }
    }
}
