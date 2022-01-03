using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Hunters.Clases
{
    public class Ammo
    {
        int id_ammo { get; set; }
        string description { get; set; }
        Caliber caliber { get; set; }
        AmmoType ammo_type { get; set; }
        Brand brand { get; set; }
        Supplier supplier { get; set; }
        int grammage { get; set; }
        int box_ammount { get; set; }
        float unit_price_USD { get; set; }
        int stock { get; set; }

    }
}
