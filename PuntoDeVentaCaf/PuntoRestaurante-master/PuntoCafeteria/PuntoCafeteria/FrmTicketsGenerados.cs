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
    public partial class FrmTicketsGenerados : Form
    {
        public FrmTicketsGenerados()
        {
            InitializeComponent();
        }
        ClassVenta venta = new ClassVenta();
        ticket ticket = new ticket();
        private void dtgTickets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id_ticket = Convert.ToInt32(dtgTickets.Rows[e.RowIndex].Cells[0].Value);
            DataSet recuper = venta.detalle_compra(id_ticket);
            dtgdetalle.DataSource = recuper.Tables[0];
        }

        private void FrmTicketsGenerados_Load(object sender, EventArgs e)
        {
            DataSet recuper = ticket.ConsultartodosTicket();
            dtgTickets.DataSource = recuper.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fecha1 = dtp1.Value.ToString("yyyy-MM-dd");
            string fecha2 = dtp2.Value.ToString("yyyy-MM-dd");
            DataSet recuper = ticket.ConsultarTicket(fecha1,fecha2);
            dtgTickets.DataSource = recuper.Tables[0];
        }
    }
}
