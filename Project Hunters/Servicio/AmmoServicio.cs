using Project_Hunters.Clases;
using Project_Hunters.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Hunters.Servicio
{
     public class AmmoServicio
    {
        private AmmoRepositorio ammoRepositorio;

        public AmmoServicio(AmmoRepositorio ammoRepo)
        {
            ammoRepositorio = ammoRepo;
        }
        public AmmoServicio()
        {
            ammoRepositorio = new AmmoRepositorio();
        }

        public List<Ammo> GetAmmo(Ammo ammo_filter, bool stock)
        {

            return ammoRepositorio.GetAmmos(ammo_filter, stock);
        }
    }
}
