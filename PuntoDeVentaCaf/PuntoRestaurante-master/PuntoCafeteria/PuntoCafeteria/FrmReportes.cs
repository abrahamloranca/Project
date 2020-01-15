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
    public partial class FrmReportes : Form
    {
        ticket ticket = new ticket();
        ClassVenta venta = new ClassVenta();
        public FrmReportes()
        {
            InitializeComponent();
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {
          
            
        }

        private void dtgTickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.panelContenedor.Controls.Count > 0)

                this.panelContenedor.Controls.RemoveAt(0);
            FrmTicketsGenerados form = Application.OpenForms.OfType<FrmTicketsGenerados>().FirstOrDefault();
            FrmTicketsGenerados hijo1 = form ?? new FrmTicketsGenerados();
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
            FrmReportesVentas form = Application.OpenForms.OfType<FrmReportesVentas>().FirstOrDefault();
            FrmReportesVentas hijo1 = form ?? new FrmReportesVentas();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(hijo1);
            this.panelContenedor.Tag = hijo1;
            hijo1.Show();
        }
    }
}
