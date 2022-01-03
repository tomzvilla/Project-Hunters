using Project_Hunters.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Hunters.Repositorio
{
    public class SupplierRepositorio
    {
        public List<Supplier> GetSuppliers()
        {
            var supplierList = new List<Supplier>();
            string sentenciaSQL = "SELECT * FROM Supplier";
            var tablaConsulta = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSQL);
            foreach (DataRow fila in tablaConsulta.Rows)
            {
                var supplier = new Supplier();
                supplier.id_supplier = Convert.ToInt32(fila["id_supplier"]);
                supplier.supplier_name = fila["supplier_name"].ToString();
                supplierList.Add(supplier);

            }
            return supplierList;
        }

    }
}

