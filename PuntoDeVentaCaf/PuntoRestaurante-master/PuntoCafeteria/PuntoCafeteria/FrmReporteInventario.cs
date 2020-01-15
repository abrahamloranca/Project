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
    public partial class FrmReporteInventario : Form
    {
        Clases.ClassDepartamento departamento = new Clases.ClassDepartamento();
        Clases.ClassProducto obproducto = new Clases.ClassProducto();
        public FrmReporteInventario()
        {
            InitializeComponent();
        }

        private void FrmReporteInventario_Load(object sender, EventArgs e)
        {
            cargar();
        }
        public void cargar()
        {
            DataTable table = departamento.listar_departamento();
            cmbdepartamento.ValueMember = "Id";
            cmbdepartamento.DisplayMember = "departamento";
            cmbdepartamento.DataSource = table;
            DataSet recuper = obproducto.TotalesInventario();
           lblcostoinventario.Text = recuper.Tables[0].Rows[0][0].ToString();
            lblProductos.Text = recuper.Tables[0].Rows[0][1].ToString();
        }

        private void cmbdepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet recuper = obproducto.ProductosPordepa(Convert.ToInt32(cmbdepartamento.SelectedValue));
            dtreporteinventario.DataSource = recuper.Tables[0];
            dtreporteinventario.Columns[1].Width = 270;
            }
    }
}
