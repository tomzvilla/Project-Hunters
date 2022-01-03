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
        private CaliberServicio caliberService;
        public AmmoList(main _main)
        {
            InitializeComponent();
            main = _main;
            caliberService = new CaliberServicio();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {

        }

        private void AmmoList_Load(object sender, EventArgs e)
        {
            load_caliber();
        }

        private void load_caliber()
        {
            var calibers = caliberService.GetCalibers();
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
    }
}
