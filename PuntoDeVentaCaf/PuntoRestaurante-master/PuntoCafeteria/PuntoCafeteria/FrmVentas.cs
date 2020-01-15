using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PuntoCafeteria.Clases;



namespace PuntoCafeteria
{
    public partial class FrmVentas : Form
    {
        textboxEvent eventos = new textboxEvent();
        ClassVenta objventa = new ClassVenta();
        DataSet datas = new DataSet();
        List<DataRow> drlist = new List<DataRow>();
        public FrmVentas()
        {
            InitializeComponent();
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            txtproductos.Focus();
           
        }

        private void button_BuscarProducto_Click(object sender, EventArgs e)
        {
            if (txtproductos.Text != "")
            {
                int valor = 0;

                int cantidad = 0;
                datas = objventa.BusquedaProducto(txtproductos.Text);
                if(datas.Tables[0].Rows.Count>0)
                {
                    if (dataGridView_Ventas.RowCount == 0)
                    {
                        bool verifica = objventa.verificar_cantidad(txtproductos.Text,1);
                        if(verifica==true)
                        {
                            dataGridView_Ventas.Rows.Add(datas.Tables[0].Rows[0][0].ToString(), datas.Tables[0].Rows[0][1].ToString(), datas.Tables[0].Rows[0][2], string.Format("${0:#,###,###,##0.00####}", datas.Tables[0].Rows[0][6]));
                            dataGridView_Ventas.Rows[0].Cells[4].Value = 1;
                        }
                        else
                        {
                            MessageBox.Show("No hay en Existencia");
                        }

                    }
                    else
                    {
                        for (int i = 0; i < dataGridView_Ventas.RowCount; i++)
                        {
                            if (dataGridView_Ventas.Rows[i].Cells[0].Value.ToString() == datas.Tables[0].Rows[0][0].ToString())
                            {
                                string codigo = dataGridView_Ventas.Rows[i].Cells[0].Value.ToString();
                                cantidad = Convert.ToInt32(dataGridView_Ventas.Rows[i].Cells[4].Value) + 1;
                                dataGridView_Ventas.Rows[i].Cells[4].Value = cantidad;
                                valor = 1;
                                valida_existencia(i, cantidad, codigo);

                            }

                        }
                        if (valor == 0)
                        {
                            bool verifica = objventa.verificar_cantidad(txtproductos.Text, 1);
                            if (verifica == true)
                            {
                                dataGridView_Ventas.Rows.Add(datas.Tables[0].Rows[0][0].ToString(), datas.Tables[0].Rows[0][1].ToString(), datas.Tables[0].Rows[0][2], string.Format("${0:#,###,###,##0.00####}", datas.Tables[0].Rows[0][6]));
                                dataGridView_Ventas.Rows[dataGridView_Ventas.RowCount - 1].Cells[4].Value = 1;

                            }
                            else
                                MessageBox.Show("No hay en existencia");

                        }
                    }
                    suma_productos();
                }
                else
                {
                    MessageBox.Show("No Existe ese Codigo");
                }
            }
                
            else
            { MessageBox.Show("Porfavor Ingrese un Codigo de barras"); }
            txtproductos.Focus();
            txtproductos.Text = "";
        }



        private void dataGridView_Ventas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int cantidad = Convert.ToInt32(dataGridView_Ventas.Rows[dataGridView_Ventas.CurrentRow.Index].Cells[4].Value);
            string codigo = dataGridView_Ventas.Rows[dataGridView_Ventas.CurrentRow.Index].Cells[0].Value.ToString();
            valida_existencia(dataGridView_Ventas.CurrentRow.Index, cantidad,codigo);
            suma_productos();

        }
        public void valida_existencia(int index,int cantidad,string codigo)
        {
             bool verifica = objventa.verificar_cantidad(codigo, cantidad);
            if (verifica == false)
            {
                MessageBox.Show(" solo hay en existencia " + "" + objventa.cantidadexistente().ToString() + "");
                dataGridView_Ventas.Rows[index].Cells[4].Value = objventa.cantidadexistente();
            }
            
        }
        public void suma_productos()
        {
            double total = 0;
            double costo = 0;
            string cost = "";
            for (int i = 0; i < dataGridView_Ventas.RowCount; i++)
            {
              int  cantidad = Convert.ToInt32(dataGridView_Ventas.Rows[i].Cells[4].Value);

                 cost = dataGridView_Ventas.Rows[i].Cells[3].Value.ToString();
                cost = cost.Substring(1);
                costo =Convert.ToDouble( cost);
                total += objventa.sumaventas(cantidad, costo);
            }
            label_ImportesVentas.Text =   total.ToString();
        }

        private void textBox_Pagos_KeyPress(object sender, KeyPressEventArgs e)
        {
            eventos.numberDecimalkeypress(textBox_Pagos,e);
        }

        private void textBox_Pagos_TextChanged(object sender, EventArgs e)
        {
            decimal pago = 0;
            if (textBox_Pagos.Text != "")
            {
               
                pago = Convert.ToDecimal(textBox_Pagos.Text.Replace(".",","));

            if (pago >= Convert.ToDecimal(label_ImportesVentas.Text))
            {
                label_SuCambio.Text = "Su Cambio";
                label_SuCambio.ForeColor = Color.Green;
                label_Cambio.Text = Convert.ToString(pago-Convert.ToDecimal(label_ImportesVentas.Text) );

            }
            else
            {
                label_SuCambio.Text = "Pago Insuficiente Falta";
                label_SuCambio.ForeColor = Color.Red;
                label_Cambio.Text = Convert.ToString(Convert.ToDecimal(label_ImportesVentas.Text) - pago);

            }
           }
            else
            {
                label_SuCambio.Text = "Pago Insuficiente Falta";
                label_SuCambio.ForeColor = Color.Red;
                label_Cambio.Text = Convert.ToString(Convert.ToDecimal(label_ImportesVentas.Text) - pago);

            }
            if(label_SuCambio.Text.Equals("Pago Insuficiente Falta"))
            {
                button_Cobrar.Enabled = false;
            }
            else
            {
                button_Cobrar.Enabled = true;
            }

        }

        private void txtproductos_KeyPress(object sender, KeyPressEventArgs e)
        {
            eventos.numberkeypress(e);
        }

        private void button_Cobrar_Click(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToString("yyyy-MM-dd");
            int hora = Convert.ToInt32(DateTime.Now.ToString("HH"));
            int minutos = Convert.ToInt32(DateTime.Now.ToString("mm"));
            ticket ticket = new ticket(fecha, Convert.ToDouble( label_ImportesVentas.Text),Convert.ToDouble( textBox_Pagos.Text),Convert.ToDouble( label_Cambio.Text),0,21,hora,minutos);
           ticket.agregar_ticket();
         int id=ticket.obtener_ultimo_ticket();
            for (int i = 0; i < dataGridView_Ventas.RowCount; i++)
            {
                int cantidad = Convert.ToInt32(dataGridView_Ventas.Rows[i].Cells[4].Value);
               string codigo =dataGridView_Ventas.Rows[i].Cells[0].Value.ToString();
                objventa.agregar_Detalle(id,codigo, cantidad);
                objventa.Cantidad_comprada(codigo, cantidad);
            }
          


        //Ya podemos usar todos sus metodos
        ticket.AbreCajon();//Para abrir el cajon de dinero.

            //De aqui en adelante pueden formar su ticket a su gusto... Les muestro un ejemplo

            //Datos de la cabecera del Ticket.
            ticket.TextoCentro("Cafeteria Pancha");
            ticket.TextoIzquierda("EXPEDIDO EN: LOCAL PRINCIPAL");
            ticket.TextoIzquierda("DIREC: DIRECCION DE LA EMPRESA");
            ticket.TextoIzquierda("TELEF: 4530000");
            ticket.TextoIzquierda("R.F.C: XXXXXXXXX-XX");
            ticket.TextoIzquierda("EMAIL: cmcmarce14@gmail.com");//Es el mio por si me quieren contactar ...
            ticket.TextoIzquierda("");
            ticket.TextoExtremos("Caja # 1", "Ticket # 002-0000006");
            ticket.lineasAsteriscos();

            //Sub cabecera.
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("ATENDIÓ: VENDEDOR");
            ticket.TextoIzquierda("CLIENTE: PUBLICO EN GENERAL");
            ticket.TextoIzquierda("");
            ticket.TextoExtremos("FECHA: " + DateTime.Now.ToShortDateString(), "HORA: " + DateTime.Now.ToShortTimeString());
            ticket.lineasAsteriscos();

            //Articulos a vender.
            ticket.EncabezadoVenta();//NOMBRE DEL ARTICULO, CANT, PRECIO, IMPORTE
            ticket.lineasAsteriscos();
            //Si tiene una DataGridView donde estan sus articulos a vender pueden usar esta manera para agregarlos al ticket.
            //foreach (DataGridViewRow fila in dgvLista.Rows)//dgvLista es el nombre del datagridview
            //{
            //ticket.AgregaArticulo(fila.Cells[2].Value.ToString(), int.Parse(fila.Cells[5].Value.ToString()),
            //decimal.Parse(fila.Cells[4].Value.ToString()), decimal.Parse(fila.Cells[6].Value.ToString()));
            //}
            ticket.AgregaArticulo("Articulo A", 2, 20, 40);
            ticket.AgregaArticulo("Articulo B", 1, 10, 10);
            ticket.AgregaArticulo("Este es un nombre largo del articulo, para mostrar como se bajan las lineas", 1, 30, 30);
            ticket.lineasIgual();

            //Resumen de la venta. Sólo son ejemplos
            ticket.AgregarTotales("         SUBTOTAL......$", 100);
            ticket.AgregarTotales("         IVA...........$", 10.04M);//La M indica que es un decimal en C#
            ticket.AgregarTotales("         TOTAL.........$", 200);
            ticket.TextoIzquierda("");
            ticket.AgregarTotales("         EFECTIVO......$", 200);
            ticket.AgregarTotales("         CAMBIO........$", 0);

            //Texto final del Ticket.
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("ARTÍCULOS VENDIDOS: 3");
            ticket.TextoIzquierda("");
            ticket.TextoCentro("¡GRACIAS POR SU COMPRA!");
            ticket.CortaTicket();
            MessageBox.Show("Compra Realizada Correctamente");
           
        }

        private void dataGridView_Ventas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_Ventas.Rows[e.RowIndex].Cells["Eliminar"].Selected==true)
            {
               
                dataGridView_Ventas .Rows.RemoveAt(dataGridView_Ventas.CurrentRow.Index);
            }
            if (dataGridView_Ventas.Rows.Count>0)
            {
                suma_productos();
            }
            else
            { label_ImportesVentas.Text = "00"; }
        }


    }
}

