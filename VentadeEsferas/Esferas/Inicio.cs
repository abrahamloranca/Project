using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Esferas
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
           
            cmbtrabajadores.DataSource=ClientesDAL.Buscar();
            cmbtrabajadores.DisplayMember = "nombre";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbtrabajadores.Text != "")
            {
                Form1 frm = new Form1();
                frm.label18.Text = cmbtrabajadores.Text;
                this.Close();
                frm.ShowDialog();
            }
            else
            { MessageBox.Show("porfavor seleccione un trabajador"); }
            
           
        }

        private void cmbtrabajadores_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }

        }

        private void cmbtrabajadores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
