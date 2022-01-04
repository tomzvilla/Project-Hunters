using Project_Hunters.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Hunters.Repositorio
{
    public class QuotationRepositorio
    {
        public double GetQuotation(Supplier supplier)
        {
            double todays_quotation = 0;

            string setenciaSQL = $"SELECT * FROM Quotation WHERE id_supplier ={supplier.id_supplier}";

            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(setenciaSQL);

            foreach(DataRow fila in tablaResultado.Rows)
            {
                var quotation = new Quotation();
                quotation.quotation = Convert.ToDouble(fila["quotation"]);
                todays_quotation = quotation.quotation;
            }

            return todays_quotation;
        }

        public List<Quotation> GetQuotations(Quotation quotation_filter)
        {
            var quotation_list = new List<Quotation>();

            string sentenciaSQL = $"SELECT Q.*, S.supplier_name FROM Quotation Q JOIN Supplier S ON S.id_supplier = Q.id_supplier";

            if(quotation_filter.supplier.id_supplier != 0)
            {
                sentenciaSQL += $" WHERE Q.id_supplier = {quotation_filter.supplier.id_supplier}";
            }

            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSQL);

            foreach(DataRow fila in tablaResultado.Rows)
            {
                var quotation = new Quotation();
                quotation.quotation = Convert.ToDouble(fila["quotation"]);

                var supplier = new Supplier()
                {
                    id_supplier = Convert.ToInt32(fila["id_supplier"]),
                    supplier_name = fila["supplier_name"].ToString()
                };
                quotation.supplier = supplier;

                quotation_list.Add(quotation);
            }

            return quotation_list;
        }
    }
}
