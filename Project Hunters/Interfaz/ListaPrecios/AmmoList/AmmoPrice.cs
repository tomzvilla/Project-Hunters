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
        }
    }
}
