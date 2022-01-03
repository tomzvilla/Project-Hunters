using Project_Hunters.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Hunters.Repositorio
{
    public class BrandRepositorio
    {
        public List<Brand> GetBrands()
        {
            var brandList = new List<Brand>();
            string sentenciaSQL = "SELECT * FROM Brand";
            var tablaConsulta = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSQL);
            foreach (DataRow fila in tablaConsulta.Rows)
            {
                var brand = new Brand();
                brand.id_brand = Convert.ToInt32(fila["id_brand"]);
                brand.brand_name = fila["brand_name"].ToString();
                brandList.Add(brand);

            }
            return brandList;
        }
    }
}
