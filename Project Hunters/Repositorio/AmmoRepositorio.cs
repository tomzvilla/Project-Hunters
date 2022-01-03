using Project_Hunters.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Hunters.Repositorio
{
    public class AmmoRepositorio
    {
        public List<Ammo> GetAmmos(Ammo ammo_filter, bool stock)
        {
            var ammoList = new List<Ammo>();
            string sentenciaSQL = "SELECT A.id_ammo, A.description, A.grammage, A.box_ammount, A.unit_price_usd, A.stock, C.caliber_name, T.ammo_type_name," +
                                 "B.brand_name, S.supplier_name FROM Ammo A" +
                                " JOIN Caliber C ON A.id_caliber = C.id_caliber" +
                                " JOIN AmmoType T ON A.id_ammo_type = T.id_ammo_type" +
                                " JOIN Brand B ON A.id_brand = B.id_brand" +
                                " JOIN Supplier S ON A.id_supplier = S.id_supplier" +
                                " WHERE A.box_ammount > 0";
            if (ammo_filter.caliber.id_caliber != 0)
            {
                sentenciaSQL += $" AND A.id_caliber = {ammo_filter.caliber.id_caliber}";
            }
            if (ammo_filter.brand.id_brand != 0)
            {
                sentenciaSQL += $" AND A.id_brand = {ammo_filter.brand.id_brand}";
            }
            if (ammo_filter.supplier.id_supplier != 0)
            {
                sentenciaSQL += $" AND A.id_supplier = {ammo_filter.supplier.id_supplier}";
            }
            if (ammo_filter.ammo_type.id_ammo_type != 0)
            {
                sentenciaSQL += $" AND A.id_ammo_type = {ammo_filter.ammo_type.id_ammo_type}";
            }
            if (ammo_filter.description != "")
            {
                sentenciaSQL += $" AND A.description LIKE '%{ammo_filter.description}%'";
            }
            if (stock)
            {
                sentenciaSQL += $" AND A.stock > 0";
            }

            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSQL);
            foreach(DataRow fila in tablaResultado.Rows)
            {

                var ammo = mapearAmmo(fila);
                ammoList.Add(ammo);

               

            }

            return ammoList;
        }

        private Ammo mapearAmmo(DataRow fila)
        {
            var ammo = new Ammo();
            ammo.id_ammo = Convert.ToInt32(fila["id_ammo"]);
            ammo.description = fila["description"].ToString();
            ammo.grammage = Convert.ToInt32(fila["grammage"]);
            ammo.box_ammount = Convert.ToInt32(fila["box_ammount"]);
            ammo.stock = Convert.ToInt32(fila["stock"]);
            ammo.unit_price_USD = Convert.ToDouble(fila["unit_price_USD"]);

            var caliber = new Caliber()
            {
                id_caliber = Convert.ToInt32(fila["id_caliber"]),
                caliber_name = fila["caliber_name"].ToString()
            };

            var supplier = new Supplier()
            {
                id_supplier = Convert.ToInt32(fila["id_supplier"]),
                supplier_name = fila["supplier_name"].ToString()
            };

            var brand = new Brand()
            {
                id_brand = Convert.ToInt32(fila["id_brand"]),
                brand_name = fila["brand_name"].ToString()
            };


            var ammoType = new AmmoType()
            {
                id_ammo_type = Convert.ToInt32(fila["id_ammo_type"]),
                ammo_type_name = fila["ammo_type_name"].ToString()
            };

            ammo.caliber = caliber;
            ammo.supplier = supplier;
            ammo.brand = brand;
            ammo.ammo_type = ammoType;

            return ammo;
        }
    }
}
