using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarcodeLib;

namespace PuntoCafeteria
{
    public partial class FrmProductonuevo : Form
    {
        Clases.ClassDepartamento departamento = new Clases.ClassDepartamento();
        Clases.ClassProducto objproducto = new Clases.ClassProducto();
        int iva;
        double costo;
        public FrmProductonuevo()
        {
            InitializeComponent();
        }

        private void FrmProductonuevo_Load(object sender, EventArgs e)
        {
         cargar();
         txtprecioventa.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            objeto();
            objproducto.agregar_producto();
            MessageBox.Show("Producto Guardado");
        }
        public void cargar()
        {
            Clases.ClassProveedor prove = new Clases.ClassProveedor();
            DataTable table = departamento.listar_departamento();
            cmbdepartamento.ValueMember = "Id";
            cmbdepartamento.DisplayMember = "departamento";
            cmbdepartamento.DataSource = table;
            DataSet proveed = prove.Mostrarprovedores();
            cmbproveedor.ValueMember = "Idproovedor";
            cmbproveedor.DisplayMember = "Nombre";
            cmbproveedor.DataSource = proveed.Tables[0];
        }
        public void Limpiar()
        {
            txtcantidad.Text = "";
            txtcodigobarra.Text = "";
            txtcosto.Text = "";
            txtDecripcion.Text = "";
            txtminimo.Text = "";
            chiva.Checked = false;
            numganancia.Value = 0;
            txtprecioventa.Text = "";
            txtnombre.Text = "";
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataSet recuper = objproducto.Mostrardatosmodificar(txtcodigobarra.Text);
            if(recuper.Tables[0].Rows.Count!=0)
            {
            txtnombre.Text = recuper.Tables[0].Rows[0][1].ToString();
            txtDecripcion.Text = recuper.Tables[0].Rows[0][2].ToString();
            txtcosto.Text = recuper.Tables[0].Rows[0][3].ToString();
            numganancia.Text = recuper.Tables[0].Rows[0][4].ToString();
            chiva.Checked = Convert.ToBoolean(recuper.Tables[0].Rows[0][5]);
            txtprecioventa.Text = recuper.Tables[0].Rows[0][6].ToString();
            txtcantidad.Text = recuper.Tables[0].Rows[0][7].ToString();
            txtminimo.Text = recuper.Tables[0].Rows[0][8].ToString();
            cmbdepartamento.SelectedValue = recuper.Tables[0].Rows[0][9].ToString();
                cmbproveedor.SelectedValue = recuper.Tables[0].Rows[0][10].ToString();
            }
            else
            {
                MessageBox.Show("Codigo de barras no encontrado");
            }
        }

        private void btncambios_Click(object sender, EventArgs e)
        {
            objeto();
            objproducto.modifcarProducto(txtcodigobarra.Text);
            MessageBox.Show("Producto modificado con exito");
        }
        public void objeto()
        {
            if (chiva.Checked == true)
            {
                iva = 1;
             
            }
            else
            {
                iva = 0;
             }
            objproducto = new Clases.ClassProducto(txtcodigobarra.Text, txtnombre.Text, txtDecripcion.Text, Convert.ToDouble(txtcosto.Text),
                Convert.ToDouble(numganancia.Value), iva, Convert.ToDouble(txtprecioventa.Text), Convert.ToInt32(txtcantidad.Text), Convert.ToInt32(txtminimo.Text), Convert.ToInt32(cmbdepartamento.SelectedValue),Convert.ToInt32(cmbproveedor.SelectedValue));
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            objproducto.EliminarProducto(txtcodigobarra.Text);
            MessageBox.Show("Producto eliminado");
        }

        private void numganancia_ValueChanged(object sender, EventArgs e)
        {
            calculo();
        }

        private void chiva_CheckedChanged(object sender, EventArgs e)
        {
            double totaliva;
            if(chiva.Checked==true)
            {
                totaliva = Convert.ToDouble(txtprecioventa.Text) * 16 / 100;
                txtprecioventa.Text =  Convert.ToString(Math.Round(totaliva + Convert.ToDouble(txtprecioventa.Text)));

            }
            else
            {
                calculo();
            }
        }
        public void calculo()
        {
            costo = Convert.ToDouble(txtcosto.Text);
            costo = costo*Convert.ToDouble( numganancia.Value) / 100;
            txtprecioventa.Text = Convert.ToString(Math.Round( costo + Convert.ToInt32(txtcosto.Text)));

        }

        private void txtcosto_TextChanged(object sender, EventArgs e)
        {
            calculo();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PanelRes.Visible = true;
            Random random = new Random();
            int numerito = random.Next(100000, 1000000);
            txtcodigobarra.Text = numerito.ToString();
            Barcode barras = new Barcode();
            barras.IncludeLabel = true;
            PanelRes.BackgroundImage = barras.Encode(BarcodeLib.TYPE.CODE128, txtcodigobarra.Text, Color.Black, Color.White, 400, 100);
            BtnGuardar.Visible = true;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Image imgFinal = (Image)PanelRes.BackgroundImage.Clone();
         SaveFileDialog CajaDeDiaologoGuardar = new SaveFileDialog();
            CajaDeDiaologoGuardar.AddExtension = true;
            CajaDeDiaologoGuardar.Filter = "Image PNG (*.png)|*.png";
            CajaDeDiaologoGuardar.ShowDialog();
            if (!string.IsNullOrEmpty(CajaDeDiaologoGuardar.FileName))
            {
                imgFinal.Save(CajaDeDiaologoGuardar.FileName, ImageFormat.Png);
            }
            imgFinal.Dispose();
        }
    }
}
