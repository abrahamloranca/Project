using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace PuntoCafeteria
{
    public partial class FrmMenuPrincipal : Form
    {
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        Clases.ClassConfiguracion conf = new Clases.ClassConfiguracion();
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            if(this.panelContenedor.Controls.Count > 0)

            this.panelContenedor.Controls.RemoveAt(0);
            FrmVentas form = Application.OpenForms.OfType<FrmVentas>().FirstOrDefault();
            FrmVentas hijo1 = form ?? new FrmVentas();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(hijo1);
            this.panelContenedor.Tag = hijo1;
            hijo1.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (this.panelContenedor.Controls.Count > 0)

                this.panelContenedor.Controls.RemoveAt(0);
            FrmCajeros form = Application.OpenForms.OfType<FrmCajeros>().FirstOrDefault();
            FrmCajeros hijo1 = form ?? new FrmCajeros();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(hijo1);
            this.panelContenedor.Tag = hijo1;
            hijo1.Show();

        }

        private void button_Ventas_Click(object sender, EventArgs e)
        {
            if (this.panelContenedor.Controls.Count > 0)

                this.panelContenedor.Controls.RemoveAt(0);
            FrmVentas form = Application.OpenForms.OfType<FrmVentas>().FirstOrDefault();
            FrmVentas hijo1 = form ?? new FrmVentas();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(hijo1);
            this.panelContenedor.Tag = hijo1;
            hijo1.Show();
        }

        private void button_Clientes_Click(object sender, EventArgs e)
        {
            if (this.panelContenedor.Controls.Count > 0)

                this.panelContenedor.Controls.RemoveAt(0);
            FrmCajeros form = Application.OpenForms.OfType<FrmCajeros>().FirstOrDefault();
            FrmCajeros hijo1 = form ?? new FrmCajeros();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(hijo1);
            this.panelContenedor.Tag = hijo1;
            hijo1.Show();
        }

        private void button_Productos_Click(object sender, EventArgs e)
        {
            if (this.panelContenedor.Controls.Count > 0)

                this.panelContenedor.Controls.RemoveAt(0);
            Frmproducto form = Application.OpenForms.OfType<Frmproducto>().FirstOrDefault();
            Frmproducto hijo1 = form ?? new Frmproducto();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(hijo1);
            this.panelContenedor.Tag = hijo1;
            hijo1.Show();
        }

        private void button_Dpto_Click(object sender, EventArgs e)
        {
            if (this.panelContenedor.Controls.Count > 0)

                this.panelContenedor.Controls.RemoveAt(0);
            FrmInventario form = Application.OpenForms.OfType<FrmInventario>().FirstOrDefault();
            FrmInventario hijo1 = form ?? new FrmInventario();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(hijo1);
            this.panelContenedor.Tag = hijo1;
            hijo1.Show();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            if (conf.obteneralerta()==true)
            {
                FrmAlertasProductos frm = new FrmAlertasProductos();
                frm.ShowDialog();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.panelContenedor.Controls.Count > 0)

                this.panelContenedor.Controls.RemoveAt(0);
           FrmReportes form = Application.OpenForms.OfType<FrmReportes>().FirstOrDefault();
            FrmReportes hijo1 = form ?? new FrmReportes();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(hijo1);
            this.panelContenedor.Tag = hijo1;
            hijo1.Show();
        }

        private void button_Compras_Click(object sender, EventArgs e)
        {
            if (this.panelContenedor.Controls.Count > 0)

                this.panelContenedor.Controls.RemoveAt(0);
            FrmProveedores form = Application.OpenForms.OfType<FrmProveedores>().FirstOrDefault();
            FrmProveedores hijo1 = form ?? new FrmProveedores();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(hijo1);
            this.panelContenedor.Tag = hijo1;
            hijo1.Show();
        }

        private void button_Config_Click(object sender, EventArgs e)
        {
            if (this.panelContenedor.Controls.Count > 0)

                this.panelContenedor.Controls.RemoveAt(0);
            FrmConfiguracion form = Application.OpenForms.OfType<FrmConfiguracion>().FirstOrDefault();
            FrmConfiguracion hijo1 = form ?? new FrmConfiguracion();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(hijo1);
            this.panelContenedor.Tag = hijo1;
            hijo1.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (this.panelContenedor.Controls.Count > 0)

                this.panelContenedor.Controls.RemoveAt(0);
            FrmMesas form = Application.OpenForms.OfType<FrmMesas>().FirstOrDefault();
            FrmMesas hijo1 = form ?? new FrmMesas();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(hijo1);
            this.panelContenedor.Tag = hijo1;
            hijo1.Show();
        }
    }
}

