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
   
    public partial class FrmAgregarAlInventario : Form
    {
        Clases.ClassProducto objproducto = new Clases.ClassProducto();
        public FrmAgregarAlInventario()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
          
            if (e.KeyChar == (int)Keys.Enter)
            {
                consulta();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cantidad = 0;
            if(Convert.ToInt32( txtcantiagrgar.Text) <=0)
            {
                MessageBox.Show("Ingrese un numero mayor a 0");
            }
            else
            {
                cantidad = Convert.ToInt32(lblcantidad.Text) + Convert.ToInt32(txtcantiagrgar.Text);
                objproducto.AgregarCantidad(txtcodigo.Text, cantidad);
                consulta();
            }
           
        }
        public void consulta()
        {
            DataSet recuper = objproducto.Mostrardatosmodificar(txtcodigo.Text);
            lbldescripcion.Text = recuper.Tables[0].Rows[0][1].ToString();
            lblcantidad.Text = recuper.Tables[0].Rows[0][6].ToString();
        }

        private void FrmAgregarAlInventario_Load(object sender, EventArgs e)
        {

        }
    }
}
