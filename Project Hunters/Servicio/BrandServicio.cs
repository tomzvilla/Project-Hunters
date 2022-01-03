using Project_Hunters.Clases;
using Project_Hunters.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Hunters.Servicio
{
    public class BrandServicio
    {
        private BrandRepositorio brandRepositorio;
        public BrandServicio(BrandRepositorio brandRepo)
        {
            brandRepositorio = brandRepo;
        }
        public BrandServicio()
        {
            brandRepositorio = new BrandRepositorio();
        }

        public List<Brand> GetBrands()
        {

            return brandRepositorio.GetBrands();
        }
    }
}

