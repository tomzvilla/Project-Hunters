using Project_Hunters.Clases;
using Project_Hunters.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Hunters.Servicio
{
    public class QuotationServicio
    {
        private QuotationRepositorio quotationRepositorio;
        public QuotationServicio(QuotationRepositorio quotationrRepo)
        {
            quotationRepositorio = quotationrRepo;
        }
        public QuotationServicio()
        {
            quotationRepositorio = new QuotationRepositorio();
        }

        public double GetQuotation(Supplier supplier)
        {

            return quotationRepositorio.GetQuotation(supplier);
        }

        public List<Quotation> GetQuotations(Quotation quotation)
        {
            return quotationRepositorio.GetQuotations(quotation);
        }
    }
}
