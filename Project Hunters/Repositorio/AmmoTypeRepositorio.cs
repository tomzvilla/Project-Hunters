using Project_Hunters.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Hunters.Repositorio
{
    public class AmmoTypeRepositorio
    {

        public List<AmmoType> GetAmmoTypes()
        {
            var ammoTypeList = new List<AmmoType>();
            string sentenciaSQL = "SELECT * FROM AmmoType";
            var tablaConsulta = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSQL);
            foreach (DataRow fila in tablaConsulta.Rows)
            {
                var ammo_type = new AmmoType();
                ammo_type.id_ammo_type = Convert.ToInt32(fila["id_ammo_type"]);
                ammo_type.ammo_type_name = fila["ammo_type_name"].ToString();
                ammoTypeList.Add(ammo_type);

            }
            return ammoTypeList;
        }

    }
}
