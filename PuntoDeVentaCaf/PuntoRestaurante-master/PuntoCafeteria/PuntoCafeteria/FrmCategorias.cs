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
    public partial class FrmCategorias : Form
    {
        int valorcelda;
        ClassDepartamento depa = new ClassDepartamento();
        public FrmCategorias()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassDepartamento departamento = new ClassDepartamento(textBox1.Text);
            departamento.Agregar_departamento();
            llenargried();
            MessageBox.Show("Departamento Agregado");
        }
        private void llenargried()
        {
            DataSet recuerp = depa.departamentos();
            dtgDepa.DataSource=recuerp.Tables[0];
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            llenargried();
        }

        private void dtgDepa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            valorcelda = Convert.ToInt32(dtgDepa.Rows[e.RowIndex].Cells[1].Value.ToString());
            if (dtgDepa.Rows[e.RowIndex].Cells[0].Selected == true)
            {
                if (MessageBox.Show("¡Si Elimina Un Departamento Eliminara los productos del mismo departamento!", "Alerta", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    depa.Eliminardepa(valorcelda);
                    MessageBox.Show("Eliminado");
                }
        
            }
            else
            {
                DataSet recuper = depa.Mostrardatosmodificar(valorcelda);
                textBox1.Text = recuper.Tables[0].Rows[0][1].ToString();

            }
            llenargried();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClassDepartamento depa = new ClassDepartamento(textBox1.Text);
            depa.modificardepa(valorcelda);
            MessageBox.Show("Departamento Actualizado");
            llenargried();
        }
    }
}
