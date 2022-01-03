using Project_Hunters.Clases;
using Project_Hunters.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Hunters.Servicio
{
    public class CaliberServicio
    {
        private CaliberRepositorio caliberRepositorio;
        public CaliberServicio(CaliberRepositorio caliberRepo)
        {
            caliberRepositorio = caliberRepo;
        }
        public CaliberServicio()
        {
            caliberRepositorio = new CaliberRepositorio();
        }

        public List<Caliber> GetCalibers() {

            return caliberRepositorio.GetCalibers();
        }
    }
}
