using Project_Hunters.Clases;
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
    public partial class AmmoPrice : Form
    {
        private Ammo ammo;
        private double priceUSD;
        private double priceARS;
        public AmmoPrice(Ammo _ammo, double _priceUSD, double _priceARS)
        {
            InitializeComponent();
            ammo = _ammo;
            priceUSD = _priceUSD;
            priceARS = _priceARS;
        }

        private void AmmoPrice_Load(object sender, EventArgs e)
        {
            txt_item.Text = ammo.description;
            txt_precio_usd.Text = "$ "+ priceUSD.ToString() + " USD";
            txt_precio_ars.Text = "$ "+ priceARS.ToString() + " ARS";
            txt_precio_bonificado.Text = "$ " + priceARS.ToString() + " ARS";
        }

        private void txt_bonificacion_TextChanged(object sender, EventArgs e)
        {
 
            if(txt_bonificacion.Text != "")
            {
                double bonificacion = Convert.ToDouble(txt_bonificacion.Text);
                double descuento = bonificacion / 100;
                double precio_bonificado = priceARS - (priceARS * descuento);
                txt_precio_bonificado.Text = "$ "+ Math.Round(precio_bonificado,3,MidpointRounding.AwayFromZero).ToString() +" ARS";
            }
            else
            {
                txt_precio_bonificado.Text = "$ " + priceARS.ToString() + " ARS";
            }

        }

        private void txt_bonificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
