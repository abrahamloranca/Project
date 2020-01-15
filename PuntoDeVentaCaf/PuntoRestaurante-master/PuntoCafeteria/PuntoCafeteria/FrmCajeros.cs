using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlServerCe;
using System.Data.SqlClient;

namespace PuntoCafeteria
{
  
    public partial class FrmCajeros : Form
    {

        Clases.ClassCajero objcajero = new Clases.ClassCajero();
        int valorcelda;
        public FrmCajeros()
        {
            InitializeComponent();
        }

        private void FrmCajeros_Load(object sender, EventArgs e)
        {
            Inicializador_form();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bntAgregarCajero.Visible = true;
            limpiarcontroles();
            btnguardarcambios.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            objcajero = new Clases.ClassCajero(txtusuario.Text, txtcontraseña.Text, txtnombre.Text, txtdireccion.Text,Convert.ToInt32(txttelefono.Text),cmbRoles.SelectedIndex);
            if (objcajero.Verificar_usuario()!=1)
            {
                objcajero.agregar_cajero();
                DialogResult res = new DialogResult();
                Form mensaje = new FrmShowdialog();
                res = mensaje.ShowDialog();
                //Limpiar Controles//
                lblverfuser.Hide();
                dtusuarios.Rows.Remove(dtusuarios.CurrentRow);
                Inicializador_form();

            }
            else
            {
                lblverfuser.Visible = true;

            }
            

        
        
            
        }


        private void button4_Click(object sender, EventArgs e)
        {
            limpiarcontroles();
        }

        private void dtusuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bntAgregarCajero.Visible = false;
            btnguardarcambios.Visible = true;
         valorcelda =Convert.ToInt32(dtusuarios.Rows[e.RowIndex].Cells[1].Value.ToString());
          DataSet recuper=  objcajero.Mostrardatosmodificar(valorcelda);
         txtusuario.Text=   recuper.Tables[0].Rows[0][1].ToString();
          txtcontraseña.Text = recuper.Tables[0].Rows[0][2].ToString();
            txtnombre.Text = recuper.Tables[0].Rows[0][3].ToString();
            txtdireccion.Text = recuper.Tables[0].Rows[0][4].ToString();
            txttelefono.Text = recuper.Tables[0].Rows[0][5].ToString();

        }

        private void BtnEliminarcajero_Click(object sender, EventArgs e)
        {
            objcajero.Eliminarcajro(valorcelda);
            MessageBox.Show("Se elimino Correctamente");
            dtusuarios.Rows.Remove(dtusuarios.CurrentRow);
            limpiarcontroles();
            Inicializador_form();
        }
        public void Inicializador_form()
        {
            lblverfuser.Hide();
            DataSet recuper = objcajero.MostrarUsuario();
            dtusuarios.DataSource = recuper.Tables[0];
            dtusuarios.Columns[2].Width = 235;
            dtusuarios.Columns[1].HeaderText = "Clave";
            btnguardarcambios.Visible = false;
        }
        public void limpiarcontroles()
        {
            txtcontraseña.Clear();
            txtusuario.Clear();
            txtdireccion.Clear();
            txttelefono.Clear();
            txtnombre.Clear();
            cmbRoles.Text = "";
        }
    }
}
