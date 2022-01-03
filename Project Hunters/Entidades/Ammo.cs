using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Hunters.Clases
{
    public class Ammo
    {
        public int id_ammo { get; set; }
        public string description { get; set; }
        public Caliber caliber { get; set; }
        public AmmoType ammo_type { get; set; }
        public Brand brand { get; set; }
        public Supplier supplier { get; set; }
        public int grammage { get; set; }
        public int box_ammount { get; set; }
        public double unit_price_USD { get; set; }
        public int stock { get; set; }

    }
}
