using Project_Hunters.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Hunters.Repositorio
{
    public class CaliberRepositorio
    {
        public List<Caliber> GetCalibers()
        {
            var caliberList = new List<Caliber>();
            string sentenciaSQL = "SELECT * FROM Caliber";
            var tablaConsulta = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSQL);
            foreach(DataRow fila in tablaConsulta.Rows) {
                var calibre = new Caliber();
                calibre.id_caliber = Convert.ToInt32(fila["id_caliber"]);
                calibre.caliber_name = fila["caliber_name"].ToString();
                caliberList.Add(calibre);
  
            }
            return caliberList;
        }
    }
}
