using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoCafeteria
{
    public partial class FrmInventario : Form
    {
        public FrmInventario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.panelContenedor.Controls.Count > 0)

                this.panelContenedor.Controls.RemoveAt(0);
            FrmAgregarAlInventario form = Application.OpenForms.OfType<FrmAgregarAlInventario>().FirstOrDefault();
            FrmAgregarAlInventario hijo1 = form ?? new FrmAgregarAlInventario();
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
            FrmAjustesInventario form = Application.OpenForms.OfType<FrmAjustesInventario>().FirstOrDefault();
            FrmAjustesInventario hijo1 = form ?? new FrmAjustesInventario();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(hijo1);
            this.panelContenedor.Tag = hijo1;
            hijo1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.panelContenedor.Controls.Count > 0)

                this.panelContenedor.Controls.RemoveAt(0);
            FrmProductosBajos form = Application.OpenForms.OfType<FrmProductosBajos>().FirstOrDefault();
            FrmProductosBajos hijo1 = form ?? new FrmProductosBajos();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(hijo1);
            this.panelContenedor.Tag = hijo1;
            hijo1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.panelContenedor.Controls.Count > 0)

                 this.panelContenedor.Controls.RemoveAt(0);
            FrmReporteInventario form = Application.OpenForms.OfType<FrmReporteInventario>().FirstOrDefault();
            FrmReporteInventario hijo1 = form ?? new FrmReporteInventario();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(hijo1);
            this.panelContenedor.Tag = hijo1;
            hijo1.Show();
        }

        private void FrmInventario_Load(object sender, EventArgs e)
        {
            if (this.panelContenedor.Controls.Count > 0)

                this.panelContenedor.Controls.RemoveAt(0);
            FrmReporteInventario form = Application.OpenForms.OfType<FrmReporteInventario>().FirstOrDefault();
            FrmReporteInventario hijo1 = form ?? new FrmReporteInventario();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(hijo1);
            this.panelContenedor.Tag = hijo1;
            hijo1.Show();
        }
    }
}
