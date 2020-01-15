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
    public partial class FrmProveedores : Form
    {
        int valorcelda = -1;
        ClassProveedor proveedor= new ClassProveedor();
        public FrmProveedores()
        {
            InitializeComponent();
        }

        private void bntAgregarCajero_Click(object sender, EventArgs e)
        {
            ClassProveedor prove = new ClassProveedor(txtnombre_empresa.Text,txtnombreVendedor.Text,Convert.ToInt32( txttelefono.Text),txtDireccion.Text,txtCorreo.Text);
            prove.Agregar_Proveedor();
            MessageBox.Show("Proveedor Agregado Correctamente");
            actualizargrid();
            limpiarpantalla();
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            actualizargrid();
        }
        public void actualizargrid()
        {
          DataSet recuper=  proveedor.Mostrarprovedores();
           dtProveedores.DataSource= recuper.Tables[0];
        }

        private void dtProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            valorcelda = Convert.ToInt32(dtProveedores.Rows[e.RowIndex].Cells[2].Value.ToString());
            if (dtProveedores.Rows[e.RowIndex].Cells[1].Selected==true)
            {
                if (MessageBox.Show("Desea Eliminar el Proveedor?", "Eliminacion?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    proveedor.Eliminarproveedor(valorcelda);
                    MessageBox.Show("Eliminado");
                }  
            }
            else
            {
               DataSet recuper = proveedor.Mostrardatosmodificar(valorcelda);
                txtnombre_empresa.Text = recuper.Tables[0].Rows[0][1].ToString();
                txtDireccion.Text = recuper.Tables[0].Rows[0][2].ToString();
                txttelefono.Text = recuper.Tables[0].Rows[0][3].ToString();
                txtCorreo.Text = recuper.Tables[0].Rows[0][4].ToString();
                txtnombreVendedor.Text = recuper.Tables[0].Rows[0][5].ToString();
            }
            actualizargrid();
         
        }

        private void btnguardarcambios_Click(object sender, EventArgs e)
        {
            ClassProveedor prove = new ClassProveedor(txtnombre_empresa.Text, txtnombreVendedor.Text, Convert.ToInt32(txttelefono.Text), txtDireccion.Text, txtCorreo.Text);
            prove.modificarProveedor(valorcelda);
            MessageBox.Show("Proveedor Modificado Correctamente");
            actualizargrid();
            limpiarpantalla();
        }

        private void bntLimpiarpantalla_Click(object sender, EventArgs e)
        {
            limpiarpantalla();
        }
        public void limpiarpantalla()
        {
            txtCorreo.Text = "";
            txtDireccion.Text = "";
            txtnombreVendedor.Text = "";
            txtnombre_empresa.Text = "";
            txttelefono.Text = "";
        }
    }
}
