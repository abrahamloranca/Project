using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace Esferas
{
    public class BdComun
    {

        //conexion a la base de datos 

        public static MySqlConnection ObtenerConexion()
        {

            MySqlConnection conectar = new MySqlConnection("server=db4free.net;database=esferas123;port=3306;Uid=cabresto5; pwd=cabresto5;");



            conectar.Open();

            return conectar;

        }



    }
    //clase donde guardara los datos para asignarlos a la base de datos mediante un metodo
    //se llama cliente pero es de los trbajadores
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidop { get; set; }
        public string apellidom { get; set; }
        public string edad { get; set; }

        public Cliente() { }

        public Cliente(int pId, string pNombre, string pApellidopa, string apellidoma, string Edad)
        {
            this.Id = pId;
            this.Nombre = pNombre;
            this.Apellidop = pApellidopa;
            this.apellidom = apellidoma;
            this.edad = Edad;
        }

    }

    //metodos de insertado y consultas 
    public class ClientesDAL
    {

        public static int Agregar(Cliente pCliente)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into Trabajador (nombre, apellido_paterno, apellido_materno, edad) values ('{0}','{1}','{2}', '{3}')",
               pCliente.Nombre, pCliente.Apellidop, pCliente.apellidom, pCliente.edad), BdComun.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;

        }

        public static List<Cliente> Buscar()
        {

            List<Cliente> _lista = new List<Cliente>();



            MySqlCommand _comando = new MySqlCommand(String.Format(

           "SELECT * FROM Trabajador"), BdComun.ObtenerConexion());

            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {

                Cliente pCliente = new Cliente();

                pCliente.Id = _reader.GetInt32(0);  
                pCliente.Nombre = _reader.GetString(1);

                pCliente.Apellidop = _reader.GetString(2);

                pCliente.apellidom = _reader.GetString(3);

                pCliente.edad = _reader.GetString(4);






                _lista.Add(pCliente);

            }



            return _lista;



        }
        public static List<Cliente> nombres()
        {
            List<Cliente> _lista = new List<Cliente>();
            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT nombre FROM Trabajador"), BdComun.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Cliente pCliente = new Cliente();

           
                pCliente.Nombre = _reader.GetString(0);


            }



            return _lista;



        }


    }
    public class ventasfact

    {
        public int id { get; set; }
       
        public string tipo_compra { get; set; }
        public string fechaventa { get; set; }
        public string Total { get; set; }

        public ventasfact() { }

        public ventasfact(int pid,string ven, string product, string tipo_com, string colo, string unidad, string cant, string fecha,string tot)
        {
            this.id = pid;
            this.tipo_compra = tipo_com;
            this.fechaventa = fecha;
            this.Total = tot;
        }

    }
    public class ventafactdal
    {

        public static int Agregar(ventasfact ventas)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into factura (tipo_compra,fecha_venta, Total) values ('{0}','{1}','{2}')",
            ventas.tipo_compra, ventas.fechaventa, ventas.Total), BdComun.ObtenerConexion());
           retorno = comando.ExecuteNonQuery();
            return retorno;
        }
    }
    public class Totales
    {
        public int Cantidad_esfera { get; set; }
        public int diametroesfera { get; set; }
        public int unidades { get; set; }
        public double precio_pintura { get; set; }
        public double precio_carton { get; set; }
        public double precio_ganchos { get; set; }
        public Totales() { }

        public Totales(int Cantidad, int diamentro, int unidad, double precarton, double precioganchos, double preciopintu)
        {

            Cantidad_esfera = Cantidad;
            unidades = unidad;
            diametroesfera = diamentro;
            precio_carton = precarton;
            precio_ganchos = precioganchos;
            precio_pintura = preciopintu;

        }



        public double total(int tipo_venta)
        {
            double total = 0;
            double ppintura;
            double pgancho;
            double pcarton;
            double porcentaje;
            if (tipo_venta == 1)//tipo de venta por unidad 
            {
                if (diametroesfera == 3)
                {
                    ppintura = precio_pintura * 1 / 300;
                    pgancho = precio_ganchos * 1 / 700;
                    porcentaje = ppintura + pgancho;
                    porcentaje = porcentaje * .30 + porcentaje;
                    total = porcentaje * Cantidad_esfera;
                }
                else
                    if (diametroesfera == 5)
                    {
                        ppintura = precio_pintura * 1 / 265;
                        pgancho = precio_ganchos * 1 / 700;
                        porcentaje = ppintura + pgancho;
                        porcentaje = porcentaje * .30 + porcentaje;
                        total = porcentaje * Cantidad_esfera;
                    }
            }
            if (tipo_venta == 2)//tipo de venta por caja 
            {
                if (diametroesfera == 3 && unidades == 6)
                {
                    ppintura = precio_pintura * 6 / 300;
                    pgancho = precio_ganchos * 6 / 700;
                    pcarton = precio_carton * 1 / 30;
                    porcentaje = ppintura + pgancho + pcarton;
                    porcentaje = porcentaje * .30 + porcentaje;
                    total = porcentaje * Cantidad_esfera;

                }
                else
                {
                    if (diametroesfera == 3 && unidades == 12)
                    {

                        ppintura = precio_pintura * 12 / 300;
                        pgancho = precio_ganchos * 12 / 700;
                        pcarton = precio_carton * 1 / 20;
                        porcentaje = ppintura + pgancho + pcarton;
                        porcentaje = porcentaje * .30 + porcentaje;
                        total = porcentaje * Cantidad_esfera;
                    }
                    else
                    {
                        if (diametroesfera == 3 && unidades == 24)
                        {
                            ppintura = precio_pintura * 24 / 300;
                            pgancho = precio_ganchos * 24 / 700;
                            pcarton = precio_carton * 1 / 15;
                            porcentaje = ppintura + pgancho + pcarton;
                            porcentaje = porcentaje * .30 + porcentaje;
                            total = porcentaje * Cantidad_esfera;
                        }
                        else
                        {
                            if (diametroesfera == 5 && unidades == 6)
                            {
                                ppintura = precio_pintura * 6 / 265;
                                pgancho = precio_ganchos * 6 / 700;
                                pcarton = precio_carton * 1 / 30;
                                porcentaje = ppintura + pgancho + pcarton;
                             porcentaje = porcentaje * .30 + porcentaje;
                                total = porcentaje * Cantidad_esfera;
                            }
                            else
                            {
                                if (diametroesfera == 5 && unidades == 12)
                                {
                                    ppintura = precio_pintura * 12 / 265;
                                    pgancho = precio_ganchos * 12 / 700;
                                    pcarton = precio_carton * 1 / 20;
                                    porcentaje = ppintura + pgancho + pcarton;
                                    porcentaje = porcentaje * .30 + porcentaje;
                                    total = porcentaje * Cantidad_esfera;
                                }
                                else
                                {
                                    if (diametroesfera == 5 && unidades == 24)
                                    {
                                        ppintura = precio_pintura * 24 / 265;
                                        pgancho = precio_ganchos * 24 / 700;
                                        pcarton = precio_carton * 1 / 15;
                                        porcentaje = ppintura + pgancho + pcarton;
                                        porcentaje = porcentaje * .30 + porcentaje;
                                        total = porcentaje * Cantidad_esfera;
                                    }
                                }
                            }
                        }
                    }
                }
            }


            return Math.Round(total);
        }

    }
    public class insumos
    {

        public int Id { get; set; }
        public string precio_carton { get; set; }
        public string precio_ganchos { get; set; }
        public string precio_pintura { get; set; }

        public insumos() { }

        public insumos(int pId, string carton, string gancho, string pintura)
        {
            this.Id = pId;
            this.precio_carton = carton;
            this.precio_ganchos = gancho;
            this.precio_pintura = pintura;
        }

    }
    public class insumosdad
    {

        public static int Agregar(insumos ventas)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into Insumos (precio_carton,precio_gancho,precio_pintura) values ('{0}','{1}','{2}')",
               ventas.precio_carton, ventas.precio_ganchos, ventas.precio_pintura), BdComun.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
        public static List<insumos> cosultainsu()
        {

            List<insumos> _lista = new List<insumos>();



            MySqlCommand _comando = new MySqlCommand(String.Format(

           "SELECT * FROM Insumos"), BdComun.ObtenerConexion());

            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {

                insumos pCliente = new insumos();

                pCliente.Id = _reader.GetInt32(0);
                pCliente.precio_carton = _reader.GetString(1);
                pCliente.precio_ganchos = _reader.GetString(2);
                pCliente.precio_pintura = _reader.GetString(3);
                _lista.Add(pCliente);

            }



            return _lista;


        }




    }
    public class totalesdalfact
    {

        public static int Agregar(ventasfact ventas)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into Insumos (vendedor,producto,tipo_compra,color,unidades,cantidad,fecha_venta,total) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
            ventas.tipo_compra,ventas.fechaventa,ventas.Total), BdComun.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;

            
        }
    }
    public class facturasdal
    {

        public static List<ventasfact> consultaventas()
        {

            List<ventasfact> _lista = new List<ventasfact>();



            MySqlCommand _comando = new MySqlCommand(String.Format(

           "SELECT * FROM factura where tipo_compra='factura'"), BdComun.ObtenerConexion());

            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {

                ventasfact pCliente = new ventasfact();

                pCliente.id = _reader.GetInt32(0);
                pCliente.tipo_compra = _reader.GetString(1);
                pCliente.fechaventa = _reader.GetString(2);
                pCliente.Total = _reader.GetString(3);

                _lista.Add(pCliente);

            }



            return _lista;


        }

        public static List<ventasfact> consultaventasnot()
        {

            List<ventasfact> _lista = new List<ventasfact>();



            MySqlCommand _comando = new MySqlCommand(String.Format(

           "SELECT * FROM factura where tipo_compra='nota'"), BdComun.ObtenerConexion());

            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {

                ventasfact pCliente = new ventasfact();

                 pCliente.id = _reader.GetInt32(0);
                pCliente.tipo_compra = _reader.GetString(1);
                pCliente.fechaventa = _reader.GetString(2);
                pCliente.Total = _reader.GetString(3);

                _lista.Add(pCliente);

            }



            return _lista;


        }

       






    }
    public class subtotal
    { 
      

        private int tam;
        private double[] sub_total ;
        int pos;

        public subtotal() { }

        public subtotal(int t)
        {
            sub_total = new double [t];
            tam = t;
    
        }

        public void agregar(double dato)
        {
            if (pos < tam)
            {
                sub_total[pos] = dato;
                pos++;
            }
            else
            {
                MessageBox.Show("llego al limite de Ventas que usted selecciono Termine La compra abajo");
            }

        }

        public double sumasubtotal()
        {
            double total2=0;
            for(int i=0;i<tam;i++)
            {
                total2 += sub_total[i];
            }
            return total2;
        }

        ////////////////////////////////clase subtotales///////

    }
    public class dalsub
    {
          public int subtotal1 { get; set; }
    public int id_factura { get; set; }
        public string vendedor { get; set; }
        public string producto { get; set; }
        public string color { get; set; }
        public string unidades { get; set; }
        public string cantidad { get; set; }
        public string fechaventa { get; set; }
        public string Total { get; set; }

        public dalsub() { }

        public dalsub(int subtot,int id_factura,int pid, string ven, string product, string colo, string unidad, string cant,string tot)
        {
            this.subtotal1 =subtot;
            this.id_factura = id_factura;
            this.vendedor = ven;
            this.producto = product;
            this.color = colo;
            this.unidades = unidad;
            this.cantidad = cant;
            this.Total = tot;
        }

        public static int Agregar(dalsub subtot)
        {

            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("Insert into subtotal (id_factura,vendedor,producto,color,unidades,cantidad,subtotal) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
             subtot.id_factura, subtot.vendedor, subtot.producto, subtot.color, subtot.unidades,subtot.cantidad, subtot.Total), BdComun.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;


        }

        public int  id_max()
        {
            int max;
            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT max(id_factura) FROM factura"), BdComun.ObtenerConexion());




            max =(Int32)_comando.ExecuteScalar();

              return max;


        }

       



            



        }
    public class subtot
    {
        public string vendedor { get; set; }
        public string producto { get; set; }
        public string color { get; set; }
        public string unidades { get; set; }
        public string cantidad { get; set; }
       
        public string Total { get; set; }

        public subtot() { }

        public subtot(int subtot,int id_factura,int pid, string ven, string product, string colo, string unidad, string cant,string tot)
        {
     
            this.vendedor = ven;
            this.producto = product;
            this.color = colo;
            this.unidades = unidad;
            this.cantidad = cant;
            this.Total = tot;
        }




        public static List<subtot> consultasubtotales(String dato)
        {

            List<subtot> _lista = new List<subtot>();



            MySqlCommand _comando = new MySqlCommand(String.Format(

           "SELECT * FROM subtotal where id_factura=" + dato), BdComun.ObtenerConexion());

            MySqlDataReader _reader = _comando.ExecuteReader();

            while (_reader.Read())
            {

                subtot pCliente = new subtot();

                pCliente.vendedor = _reader.GetString(2);
                pCliente.producto = _reader.GetString(3);
                pCliente.color = _reader.GetString(4);
                pCliente.unidades = _reader.GetString(5);
                pCliente.cantidad = _reader.GetString(6);
                pCliente.Total = _reader.GetString(7);

                _lista.Add(pCliente);

            }



            return _lista;


        }

    }



    






    }



   


        
