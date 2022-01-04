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
        private SupplierServicio supplierServicio;
        private AmmoServicio ammoServicio;
        private QuotationServicio quotationServicio;
        public AmmoList(main _main)
        {
            InitializeComponent();
            main = _main;
            caliberServicio = new CaliberServicio();
            brandServicio = new BrandServicio();
            ammoTypeServicio = new AmmoTypeServicio();
            supplierServicio = new SupplierServicio();
            ammoServicio = new AmmoServicio();
            quotationServicio = new QuotationServicio();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            ammo_query();
        }

        private void AmmoList_Load(object sender, EventArgs e)
        {
       
            load_caliber();
            load_brand();
            load_ammo_type();
            load_supplier();
            ammo_query();
        }

        private void ammo_query()
        {
            var ammo_filter = new Ammo();
            ammo_filter.ammo_type = (AmmoType)cmb_tipo.SelectedItem;
            ammo_filter.brand = (Brand)cmb_marca.SelectedItem;
            ammo_filter.caliber = (Caliber)cmb_calibre.SelectedItem;
            ammo_filter.supplier = (Supplier)cmb_proveedor.SelectedItem;
            ammo_filter.description = txt_descripcion.Text.Trim();
            bool stock = ck_stock.Checked;
            dgv_ammo_list.Rows.Clear();

            var ammo_list = ammoServicio.GetAmmo(ammo_filter, stock);

            foreach(var ammo in ammo_list)
            {
                var fila = new string[]
                {
                    ammo.id_ammo.ToString(),
                    ammo.caliber.caliber_name,
                    ammo.ammo_type.ammo_type_name,
                    ammo.grammage.ToString() + " gr.",
                    ammo.brand.brand_name,
                    ammo.box_ammount.ToString(),
                    ammo.unit_price_USD.ToString(),
                    ammo.stock.ToString(),
                    ammo.supplier.supplier_name,
                    ammo.description,
                    ammo.supplier.id_supplier.ToString()

                };
                dgv_ammo_list.Rows.Add(fila);
            }

        }

        private void load_supplier()
        {
            var suppliers = supplierServicio.GetSuppliers();
            var default_supplier = new Supplier();
            default_supplier.id_supplier = 0;
            default_supplier.supplier_name = "Seleccionar";
            suppliers.Add(default_supplier);

            var conector = new BindingSource();

            conector.DataSource = suppliers;

            cmb_proveedor.DataSource = conector;
            cmb_proveedor.DisplayMember = "supplier_name";
            cmb_proveedor.ValueMember = "id_supplier";
            cmb_proveedor.SelectedItem = default_supplier;
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

        private void btn_salir_Click(object sender, EventArgs e)
        {
            main.Show();
            this.Dispose();
        }

        private void btn_ver_precio_Click(object sender, EventArgs e)
        {
            // Precio Unitario * Cantidad Caja * 1.21 (IVA) * 1.05 (Flete) * 1.40 (Ganancia)

            double IVA = 1.21;
            double flete = 1.05;
            double ganancia = 1.40;

            if (dgv_ammo_list.SelectedRows.Count == 1)
            {
                var ammo = new Ammo();
                ammo.description = Convert.ToString(dgv_ammo_list.SelectedRows[0].Cells["description"].Value);
                double unit_price = Convert.ToDouble(dgv_ammo_list.SelectedRows[0].Cells["unit_price_usd"].Value);
                int box_ammount = Convert.ToInt32(dgv_ammo_list.SelectedRows[0].Cells["box_ammount"].Value);

                var supplier = new Supplier() {
                    id_supplier = Convert.ToInt32(dgv_ammo_list.SelectedRows[0].Cells["id_supplier"].Value)
            };

                double quotation = quotationServicio.GetQuotation(supplier);

                double final_price_usd = unit_price * box_ammount * IVA * flete * ganancia;

                double final_price_ars = final_price_usd * quotation;

                var priceForm = new AmmoPrice(ammo, Math.Round(final_price_usd,3,MidpointRounding.AwayFromZero), 
                    Math.Round(final_price_ars, 3, MidpointRounding.AwayFromZero));
                priceForm.ShowDialog();
                return;

            }
            else
            {
                MessageBox.Show("Debe seleccionar solo un registro", "Información", MessageBoxButtons.OK);
            }
        }

        private void AmmoList_FormClosing(object sender, FormClosingEventArgs e)
        {
            main.Show();
            this.Dispose();
        }
    }
}
