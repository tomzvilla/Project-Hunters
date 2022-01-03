using Project_Hunters.Clases;
using Project_Hunters.Servicio;
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
        private CaliberServicio caliberServicio;
        private BrandServicio brandServicio;
        private AmmoTypeServicio ammoTypeServicio;
        public AmmoList(main _main)
        {
            InitializeComponent();
            main = _main;
            caliberServicio = new CaliberServicio();
            brandServicio = new BrandServicio();
            ammoTypeServicio = new AmmoTypeServicio();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {

        }

        private void AmmoList_Load(object sender, EventArgs e)
        {
            load_caliber();
            load_brand();
            load_ammo_type();
        }

        private void load_caliber()
        {
            var calibers = caliberServicio.GetCalibers();
            var default_caliber = new Caliber();
            default_caliber.id_caliber = 0;
            default_caliber.caliber_name = "Seleccionar";
            calibers.Add(default_caliber);

            var conector = new BindingSource();

            conector.DataSource = calibers;

            cmb_calibre.DataSource = conector;
            cmb_calibre.DisplayMember = "caliber_name";
            cmb_calibre.ValueMember = "id_caliber";
            cmb_calibre.SelectedItem = default_caliber;
        }

        private void load_brand()
        {
            var brands = brandServicio.GetBrands();
            var default_brand = new Brand();
            default_brand.id_brand = 0;
            default_brand.brand_name = "Seleccionar";
            brands.Add(default_brand);

            var conector = new BindingSource();

            conector.DataSource = brands;

            cmb_marca.DataSource = conector;
            cmb_marca.DisplayMember = "brand_name";
            cmb_marca.ValueMember = "id_brand";
            cmb_marca.SelectedItem = default_brand;
        }

        private void load_ammo_type()
        {
            var ammo_types = ammoTypeServicio.GetAmmoTypes();
            var default_ammo_type = new AmmoType();
            default_ammo_type.id_ammo_type = 0;
            default_ammo_type.ammo_type_name = "Seleccionar";
            ammo_types.Add(default_ammo_type);

            var conector = new BindingSource();

            conector.DataSource = ammo_types;

            cmb_tipo.DataSource = conector;
            cmb_tipo.DisplayMember = "ammo_type_name";
            cmb_tipo.ValueMember = "id_ammo_type";
            cmb_tipo.SelectedItem = default_ammo_type;
        }
    }
}
