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
    public partial class FrmAjustesInventario : Form
    {
        Clases.ClassProducto objproducto = new Clases.ClassProducto();
        public FrmAjustesInventario()
        {
            InitializeComponent();
        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
            {
                consulta();
            }
        }
        public void consulta()
        {
            DataSet recuper = objproducto.Mostrardatosmodificar(txtcodigo.Text);
            lbldescripcion.Text = recuper.Tables[0].Rows[0][1].ToString();
            lblcantidad.Text = recuper.Tables[0].Rows[0][6].ToString();
        }

        private void txtcmodificarcanti_TextChanged(object sender, EventArgs e)
        {
            int res = 0;
            if (txtcmodificarcanti.Text == "")
            {

            }
            else
            {
                int cantidad = Convert.ToInt32(lblcantidad.Text);
                int modificacion = Convert.ToInt32(txtcmodificarcanti.Text);
                res =Math.Abs( cantidad - modificacion);
                if (Convert.ToInt32( txtcmodificarcanti.Text)<Convert.ToInt32( lblcantidad.Text))
                {
             
                    lbldiferencia.Text = "-"+res.ToString();
                }
               else
                {
                    lbldiferencia.Text = "+" + res.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            objproducto.AgregarCantidad(txtcodigo.Text, Convert.ToInt32(txtcmodificarcanti.Text));
            consulta();
        }
    }
}
