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
    public partial class Frmproducto : Form
    {
        FrmProductonuevo hijo1;
        FrmProductonuevo form = Application.OpenForms.OfType<FrmProductonuevo>().FirstOrDefault();

        public Frmproducto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrir_contenedor();
            hijo1.btngenerar.Visible = true;
            hijo1.txtcodigobarra.Enabled = false;
            hijo1.button3.Visible = false;
            hijo1.btncambios.Visible = false;
            hijo1.button1.Visible = true;
            hijo1.button2.Visible =  true;
            hijo1.btneliminar.Visible = false;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            abrir_contenedor();
            hijo1.button3.Visible=true;
            hijo1.btncambios.Visible = true;
            hijo1.button1.Visible = false;
            hijo1.button2.Visible = false;
            hijo1.btneliminar.Visible = false;
            hijo1.txtcodigobarra.Enabled = true;
            hijo1.btngenerar.Visible = false;
            hijo1.BtnGuardar.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            abrir_contenedor();
            hijo1.button3.Visible = true;
            hijo1.btncambios.Visible = false;
            hijo1.button1.Visible = false;
            hijo1.button2.Visible = false;
            hijo1.btneliminar.Visible = true;
            hijo1.btngenerar.Visible = false;
            hijo1.BtnGuardar.Visible = false;
        }
        public void abrir_contenedor()
        {
            if (this.panelContenedor.Controls.Count > 0)

                this.panelContenedor.Controls.RemoveAt(0);
            hijo1 = form ?? new FrmProductonuevo();
            hijo1.TopLevel = false;
            hijo1.FormBorderStyle = FormBorderStyle.None;
            hijo1.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(hijo1);
            this.panelContenedor.Tag = hijo1;
            hijo1.Show();
        }
    }
}
