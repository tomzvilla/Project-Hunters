using Project_Hunters.Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project_Hunters.Interfaz.ListaPrecios.AmmoList
{
    public partial class AmmoList : Form
    {
        private main main;
        public AmmoList(main _main)
        {
            InitializeComponent();
            main = _main;
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            string sentenciaSQL = "SELECT * FROM Ammo";
            DataTable tabla = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSQL);
        }
    }
}
