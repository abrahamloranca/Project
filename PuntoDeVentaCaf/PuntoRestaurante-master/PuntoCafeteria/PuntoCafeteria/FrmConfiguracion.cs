using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PuntoCafeteria.Clases;

namespace PuntoCafeteria
{
    public partial class FrmConfiguracion : Form
    {
        public FrmConfiguracion()
        {
            InitializeComponent();
        }
        ClassConfiguracion config = new ClassConfiguracion();
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.panelContenedor.Controls.Count > 0)

                this.panelContenedor.Controls.RemoveAt(0);
            FrmConfTicket form = Application.OpenForms.OfType<FrmConfTicket>().FirstOrDefault();
            FrmConfTicket hijo1 = form ?? new FrmConfTicket();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(hijo1);
            this.panelContenedor.Tag = hijo1;
            hijo1.Show();
        }

        private void FrmConfiguracion_Load(object sender, EventArgs e)
        {
            colorbotonalarma();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.panelContenedor.Controls.Count > 0)

                this.panelContenedor.Controls.RemoveAt(0);
            FrmCategorias form = Application.OpenForms.OfType<FrmCategorias>().FirstOrDefault();
            FrmCategorias hijo1 = form ?? new FrmCategorias();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(hijo1);
            this.panelContenedor.Tag = hijo1;
            hijo1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            config.apagarencenderalerta();
             Boolean resultado=   config.obteneralerta();
            if (resultado==true)
            {
                MessageBox.Show("Alarma de inventario Activada");
            }
            else if(resultado==false)
            {
                MessageBox.Show("Alarma de inventario Desactivada");
            }
            colorbotonalarma();
        }
        public void colorbotonalarma()
        {
            if (config.obteneralerta() == true)
            {
                btnalarma.ForeColor = Color.Red;
            }
            else
            {
                btnalarma.ForeColor = Color.Black;
            }
        }
    }
}
