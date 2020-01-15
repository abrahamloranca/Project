using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Esferas
{
    public partial class Form1 : Form
    {
        int vent;
        Conexion nombreInstancia = new Conexion();
        Totales objeto = new Totales();
        double precioc, preciog, preciolip;
        subtotal total;
        int countRows = 0;
        string preciocarton = "Precio_carton";
        string preciogancho= "precio_ganchos";
        string preciopintura = "precio_pintura";
        double gancho, pintura, carton;
        insumos pCliente = new insumos();
  
        public Form1()
        {
            InitializeComponent();
        }
        class Conexion
        {
            public string datos = @"server=db4free.net;database=esferas123;port=3306;Uid=cabresto5; pwd=cabresto5;";
            public MySqlConnection conexion;

            public void abrir()
            {
                try
                {
                    conexion = new MySqlConnection(datos);
                    conexion.Open();

                    MessageBox.Show("conexion realizada exitosamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            public void cerrar()
            {
                try
                {
                    conexion = new MySqlConnection(datos);
                    conexion.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            nombreInstancia.abrir();

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void rdbUnidad_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            groupBox1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            rdbUnidad.Checked = true;
            groupBox1.Enabled = true;
            groupBox2.Enabled = false;

        }

        private void rdbCaja_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            groupBox1.Enabled = false;
        }
        //boton de insumos
        private void button3_Click(object sender, EventArgs e)
        {
            preciocarton = txtkcarton.Text;
            preciogancho = txtkganchos.Text;
            preciopintura = txtlitrop.Text;
            //mandar a la base de datos los insumos
            pCliente.precio_carton = txtkcarton.Text;
            pCliente.precio_ganchos = txtkganchos.Text;
            pCliente.precio_pintura = txtlitrop.Text;
            int resultado = insumosdad.Agregar(pCliente);
            if (resultado > 0)
            {
                MessageBox.Show("insumo Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar el insumo", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            dataGridView2.DataSource = insumosdad.cosultainsu();

        }


        private void button4_Click(object sender, EventArgs e)
        {


        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            rdfactura.Checked = true;
            dataGridView2.DataSource = insumosdad.cosultainsu();
            dataGridView1.DataSource = ClientesDAL.Buscar();
            label18.Enabled = false;
            rdbUnidad.Checked = true;
            rdbUnidad.Enabled = false;
            rdbCaja.Enabled = false;
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            label20.Text = DateTime.Now.ToShortDateString();
            countRows= dataGridView2.Rows.Count;
            carton =Convert.ToInt32(dataGridView2[preciocarton, countRows -1].Value);
         pintura = Convert.ToInt32(dataGridView2[preciopintura, countRows - 1].Value);
            gancho = Convert.ToInt32(dataGridView2[preciogancho, countRows - 1].Value);
            pCliente.precio_carton = carton.ToString();
            pCliente.precio_ganchos = gancho.ToString();
            pCliente.precio_pintura = pintura.ToString();




         
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnactua_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ClientesDAL.Buscar();
            MessageBox.Show("informacion actualizada");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Cliente pCliente = new Cliente();
            pCliente.Nombre = txtnombre.Text.Trim();
            pCliente.Apellidop = txtapellidop.Text.Trim();
            pCliente.apellidom = txtapellidom.Text.Trim();
            pCliente.edad = numedad.Value.ToString();

            int resultado = ClientesDAL.Agregar(pCliente);
            if (resultado > 0)
            {
                MessageBox.Show("Cliente Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo guardar el cliente", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txttrabajdor_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdbCaja_CheckedChanged_1(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            groupBox1.Enabled = false;
        }

        private void rdbUnidad_CheckedChanged_1(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = false;
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            DateTime dd = DateTime.Now;
            /*/this.vendedor = ven;
            this.producto = product;
            this.tipo_compra = tipo_com;
            this.color = colo;
            this.unidades = unidad;
            this.cantidad = cant;
            this.fechaventa = fecha;
            this.Total = tot;/*/

            if (vent == Convert.ToUInt32(txtventas.Text))
            {
                button4.Enabled = true;
                txtventas.Enabled = true;


                if (precioc != 0 && preciog != 0 && preciolip != 0)
                {
                    if (rdbCaja.Checked)
                    {
                        if (cmbcolorcaja.Text != "" && cmbcajaunidades.Text != "" && cmbdiamcaja.Text != "")
                        {
                            ventasfact pCliente = new ventasfact();

                            if (rdfactura.Checked)
                            {
                                pCliente.tipo_compra = "factura";
                            }
                            else
                            {
                                pCliente.tipo_compra = "nota";
                            }

                            pCliente.fechaventa = dd.ToString("yyyy/MM/dd");
                            label29.Text = total.sumasubtotal().ToString();
                            pCliente.Total = label29.Text;


                            int resultado = ventafactdal.Agregar(pCliente);
                            if (resultado > 0)
                            {
                                MessageBox.Show("Compra realizada Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No se pudo guardar el cliente", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }


                    else
                        if (rdbUnidad.Checked)
                        {
                            if (cmbcolorunidad.Text != "" && cmbdiamunidad.Text != "")
                            {
                                //factura//
                                objeto = new Totales(Convert.ToInt32(nucantunidad.Value), Convert.ToInt32(cmbdiamunidad.Text), Convert.ToInt32(0), precioc, preciog, preciolip);
                                label29.Text = total.sumasubtotal().ToString();
                                ventasfact pCliente = new ventasfact();
                                if (rdfactura.Checked)
                                {
                                    pCliente.tipo_compra = "factura";
                                }
                                else
                                {
                                    pCliente.tipo_compra = "nota";
                                }
                                pCliente.fechaventa = dd.ToString("yyyy/MM/dd");
                                pCliente.Total = label29.Text;
                                int resultado = ventafactdal.Agregar(pCliente);
                                if (resultado > 0)
                                {
                                    MessageBox.Show("Compra realizada Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("No se pudo guardar el cliente", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                }
                else
                {
                    MessageBox.Show("Para realizar compras debe insertar los precios de los insumos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tabControl1.SelectTab(1);
                }
            }
            else
            {
                MessageBox.Show("falta realizar compras");
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (precioc != 0 && preciog != 0 && preciolip != 0)
            {
                if (rdbCaja.Checked)
                {
                    if (cmbcolorcaja.Text != "" && cmbcajaunidades.Text != "" && cmbdiamcaja.Text != "")
                    {
                        objeto = new Totales(Convert.ToInt32(nucantcaja.Value), Convert.ToInt32(cmbdiamcaja.Text), Convert.ToInt32(cmbcajaunidades.Text), precioc, preciog, preciolip);
                        MessageBox.Show(objeto.total(2).ToString());
                    }
                    else
                    { MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                }
                else
                    if (rdbUnidad.Checked)
                    {
                        if (cmbcolorunidad.Text != "" && cmbdiamunidad.Text != "")
                        {
                            objeto = new Totales(Convert.ToInt32(nucantunidad.Value), Convert.ToInt32(cmbdiamunidad.Text), 0, precioc, preciog, preciolip);
                            MessageBox.Show(objeto.total(1).ToString());
                        }
                        else
                        { MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
                    }
            }
            else
            {
                MessageBox.Show("Para realizar compras debe insertar los precios de los insumos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tabControl1.SelectTab(1);
            }


        }

        private void txtlitrop_KeyPress(object sender, KeyPressEventArgs e)
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
                MessageBox.Show("Solo se permiten Numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }

        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void cmbdiamcaja_KeyPress(object sender, KeyPressEventArgs e)
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

        private void rdbCaja_CheckedChanged_2(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = true;
        }

        private void rdbUnidad_CheckedChanged_2(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (cmbventas.Text != "")
            {
                if (cmbventas.Text == "factura")
                {
                    dataGridView3.DataSource = facturasdal.consultaventas();
                }
                if (cmbventas.Text == "nota")
                {
                    dataGridView3.DataSource = facturasdal.consultaventasnot();

                }
            }
            else
            {
                MessageBox.Show("porfavor seleccione un tipo de compra");
            }

        }

        private void cmbventas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            dvprintPreviewDialog1.Document = dvprintDocument1;
            dvprintPreviewDialog1.ShowDialog();
        }

        private void dvprintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bpm = Properties.Resources.nota;
            Bitmap bmp= Properties.Resources.factura;
            Image newImage=bmp;
            if (label29.Text != "")
            {
                if (rdnota.Checked && rdbUnidad.Checked)
                {
                    e.Graphics.DrawImage(bpm, 0, 0);
                    e.Graphics.DrawString(label18.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(94, 74));
                    e.Graphics.DrawString(label20.Text, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(240, 75));
                    e.Graphics.DrawString("se vendieron esferas de color " + cmbcolorcaja.Text, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(0, 130));
                    e.Graphics.DrawString("con diametro de " + cmbdiamcaja.Text +"cm la cantidad de esferas fue "+Convert.ToString(nucantunidad.Value), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(0, 142));
                    e.Graphics.DrawString("y el total de la venta es " + label29.Text + " pesos", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(0, 154));


                }

                if (rdbCaja.Checked && rdnota.Checked)
                {
                    e.Graphics.DrawImage(bpm, 0, 0);
                    e.Graphics.DrawString(label18.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(94, 74));
                    e.Graphics.DrawString(label20.Text, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(240, 75));
                    e.Graphics.DrawString("se vendio caja de esferas de color "+cmbcolorcaja.Text, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(0,130));
                    e.Graphics.DrawString("con diametro de "+cmbdiamcaja.Text+"cm la caja contiene "+cmbcajaunidades.Text+"esferas", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(0,142));
                    e.Graphics.DrawString("y el total de la venta es "+label29.Text +" pesos", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(0, 154));

                }
                
                if (rdbCaja.Checked && rdfactura.Checked)
                {
                    e.Graphics.DrawImage(bmp, 0, 0);
                    e.Graphics.DrawString("Caja Esferas", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, 205));
                    e.Graphics.DrawString(cmbcajaunidades.Text, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(205, 205));
                    e.Graphics.DrawString(cmbcolorcaja.Text, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(81, 205));
                    e.Graphics.DrawString(cmbdiamcaja.Text, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(150, 205));
                    e.Graphics.DrawString(label20.Text, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(300, 205));
                    e.Graphics.DrawString(label18.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(80, 410));
                }
                else
                    if (rdbUnidad.Checked && rdfactura.Checked )
                    {
                        e.Graphics.DrawImage(bmp, 0, 0);
                        e.Graphics.DrawString("Esferas", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, 205));
                        e.Graphics.DrawString(Convert.ToString(nucantunidad.Value), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(205, 205));
                        e.Graphics.DrawString(cmbcolorunidad.Text, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(81, 205));
                        e.Graphics.DrawString(cmbdiamunidad.Text, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(150, 205));
                        e.Graphics.DrawString(label20.Text, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(300, 205));
                        e.Graphics.DrawString(label18.Text, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(80, 410));

                    }
            }
            else
            {
                MessageBox.Show("primero Termine la venta Gracias");
                dvprintPreviewDialog1.Close();
            }
       
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            precioc = carton;
            preciog = gancho;
            preciolip = pintura;

            if (txtventas.Text != "")
            {
                txtventas.Enabled = false;
                groupBox1.Enabled = true;
                rdbUnidad.Enabled=true;
                rdbCaja.Enabled = true;
                button4.Enabled = false;
                total = new subtotal(Convert.ToInt32(txtventas.Text));
                MessageBox.Show("Listo");

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // sub total//
            dalsub sub = new dalsub();
           int max=sub.id_max();
            DateTime dd = DateTime.Now;
                if (rdbCaja.Checked)
                {
                    if (cmbcolorcaja.Text != "" && cmbcajaunidades.Text != "" && cmbdiamcaja.Text != "")
                    {
                        objeto = new Totales(Convert.ToInt32(nucantcaja.Value), Convert.ToInt32(cmbdiamcaja.Text), Convert.ToInt32(cmbcajaunidades.Text), precioc, preciog, preciolip);
                        decimal total1 = Convert.ToDecimal(objeto.total(2));
                        label28.Text = total1.ToString();
                        total.agregar(Convert.ToDouble(total1));
                        sub.id_factura = max + 1;
                        sub.Total = label28.Text;
                        sub.vendedor = label18.Text;
                        sub.producto = rdbCaja.Text;
                        sub.color = cmbcolorcaja.Text;
                        sub.unidades = cmbcajaunidades.Text;
                        sub.cantidad =Convert.ToString(nucantcaja.Value);
                        dalsub.Agregar(sub);
                        vent++;
                        
                   
                    }
                    else
                    {
                        MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }


                else
                    if (rdbUnidad.Checked)
                    {
                        if (cmbcolorunidad.Text != "" && cmbdiamunidad.Text != "")
                        {
                            //factura//
                            objeto = new Totales(Convert.ToInt32(nucantunidad.Value), Convert.ToInt32(cmbdiamunidad.Text), Convert.ToInt32(0), precioc, preciog, preciolip);
                            label28.Text = objeto.total(1).ToString();
                            total.agregar(Convert.ToDouble(label28.Text));
                            sub.id_factura = max + 1;
                            sub.Total = label28.Text;
                            sub.vendedor = label18.Text;
                            sub.producto = rdbUnidad.Text;
                            sub.color = cmbcolorunidad.Text;
                            sub.unidades = "0";
                            sub.cantidad = Convert.ToString(nucantunidad.Value);
                            dalsub.Agregar(sub);
                            vent++;
                        }
                        else
                        {
                            MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
            }

        private void dataGridView3_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("hola");
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Form2 frm = new Form2();
            string valor=dataGridView3.CurrentRow.Cells[0].Value.ToString();
           frm.datasubrorales.DataSource= subtot.consultasubtotales(valor);
           frm.Show();
            
          
          




        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
           

        }
    }

