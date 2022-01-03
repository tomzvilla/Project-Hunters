using Project_Hunters.Clases;
using Project_Hunters.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Hunters.Servicio
{
    public class SupplierServicio
    {
        private SupplierRepositorio supplierRepositorio;
        public SupplierServicio(SupplierRepositorio supplierRepo)
        {
            supplierRepositorio = supplierRepo;
        }
        public SupplierServicio()
        {
            supplierRepositorio = new SupplierRepositorio();
        }

        public List<Supplier> GetSuppliers()
        {

            return supplierRepositorio.GetSuppliers();
        }
    }
}
