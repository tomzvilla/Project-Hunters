using Project_Hunters.Clases;
using Project_Hunters.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Hunters.Servicio
{
    public class AmmoTypeServicio
    {
        private AmmoTypeRepositorio ammoTypeRepositorio;

        public AmmoTypeServicio(AmmoTypeRepositorio ammoTypeRepo)
        {
            ammoTypeRepositorio = ammoTypeRepo;
        }
        public AmmoTypeServicio()
        {
            ammoTypeRepositorio = new AmmoTypeRepositorio();
        }

        public List<AmmoType> GetAmmoTypes()
        {

            return ammoTypeRepositorio.GetAmmoTypes();
        }
    }
}
