using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PuntoCafeteria.Clases;

namespace PuntoCafeteria
{
    public partial class FrmConfTicket : Form
    {
        public FrmConfTicket()
        {
            InitializeComponent();
        }

        private void FrmConfTicket_Load(object sender, EventArgs e)
        {
            PopulateInstalledPrintersCombo();
        }
        private void PopulateInstalledPrintersCombo()
        {
            String pkInstalledPrinters;
            for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                pkInstalledPrinters = PrinterSettings.InstalledPrinters[i];
                Cmbimpresora.Items.Add(pkInstalledPrinters);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassConfiguracion conf = new ClassConfiguracion(Cmbimpresora.Text, txtNombreEsta.Text, txtDireccion.Text, Convert.ToInt32(txtTelefono.Text), txttextBox4.Text);
            conf.agregarconfig();
            MessageBox.Show("Configuracion Correcta");
           
        }
    }
}
