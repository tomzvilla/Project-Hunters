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

namespace Project_Hunters.Interfaz.Cotizacion
{
    public partial class QuotationList : Form
    {
        private main main;
        private QuotationServicio quotationServicio;
        private SupplierServicio supplierServicio;
        public QuotationList(main _main)
        {
            InitializeComponent();
            main = _main;
            quotationServicio = new QuotationServicio();
            supplierServicio = new SupplierServicio();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            main.Show();
            this.Dispose();
        }

        private void Quotation_Load(object sender, EventArgs e)
        {
            load_supplier();
            quotation_query();
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

            cmb_supplier.DataSource = conector;
            cmb_supplier.DisplayMember = "supplier_name";
            cmb_supplier.ValueMember = "id_supplier";
            cmb_supplier.SelectedItem = default_supplier;
        }

        private void quotation_query()
        {
            var quotation_filter = new Quotation();
            quotation_filter.supplier = (Supplier)cmb_supplier.SelectedItem;

            var quotations = quotationServicio.GetQuotations(quotation_filter);

            dgv_quotation.Rows.Clear();
            
            foreach(var quotation in quotations)
            {
                var fila = new string[]
                {
                    quotation.supplier.id_supplier.ToString(),
                    quotation.supplier.supplier_name,
                    quotation.quotation.ToString() + " ARS"
                };
                dgv_quotation.Rows.Add(fila);

     
            }
    
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            quotation_query();
        }

        private void QuotationList_FormClosing(object sender, FormClosingEventArgs e)
        {
            main.Show();
            this.Dispose();
        }
    }
}
