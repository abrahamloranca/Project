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
    public partial class Frmlogin : Form
    {
        int valor;
        public Frmlogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            valor = Valida();
           if(valor==1)
            {
                FrmMenuPrincipal frmMenu = new FrmMenuPrincipal();
                this.Hide();
                frmMenu.Show();
            }
           else
            {
                MessageBox.Show("Error de usuario o contraseña");
            }
            
        }
        public int Valida()
        {
           
            Clases.CLassLogin login = new Clases.CLassLogin(txtuser.Text, txtpass.Text);
            DataSet recuper = login.login();
            valor= Convert.ToInt32( recuper.Tables[0].Rows[0][0]);
            return valor;
        }
    }
}
