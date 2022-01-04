using Project_Hunters.Interfaz.Cotizacion;
using Project_Hunters.Interfaz.ListaPrecios.AmmoList;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Hunters
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void btn_lista_precios_Click(object sender, EventArgs e)
        {
            var lista = new AmmoList(this);
            lista.Show();
            this.Hide();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cotizacion_Click(object sender, EventArgs e)
        {
            var cotizacion = new QuotationList(this);
            cotizacion.Show();
            this.Hide();
        }
    }
}
