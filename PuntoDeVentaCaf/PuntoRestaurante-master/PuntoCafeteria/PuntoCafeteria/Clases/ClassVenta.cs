using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlServerCe;

namespace PuntoCafeteria.Clases
{
    class ClassVenta: ClassProducto
    {
        
        DB DB = new DB();
        private int ticket { set; get; }
        private double Importe { set; get; }
        private int cantidad { set; get; }
        private double precioventa { set; get; }
        public ClassVenta()
        {
            ticket = 0;
            
            Importe = 0;
        }
       public  ClassVenta(int idticket,double importe)
        {
            ticket = idticket;
            Importe = importe;
        }
        public void Cantidad_comprada(string producto, int cantidad)
        {
            try
            {
                SqlCeCommand _cmd;
                DB.conectar();
                _cmd = new SqlCeCommand("update T_Producto set Cantidad=Cantidad-"+cantidad+" where CodigoBarras="+producto, DB.conexion());
                _cmd.ExecuteNonQuery();
                DB.deconectar();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
        }
        public DataSet detalle_compra(int ticket)
        {
            DataSet data = new DataSet();

            try
            {
                SqlCeCommand _cmd;
                DB.conectar();
                _cmd = new SqlCeCommand("select p.Nombre, p.PrecioVenta,d.Cantidad,t.TotalTicket,t.Pago,t.Cambio from T_Producto p inner join T_DetalleCompra" +
                    " d on d.IdProducto=p.CodigoBarras inner join T_Ticket t on d.Ticket=t.Ticket where t.Ticket="+ticket, DB.conexion());
                SqlCeDataAdapter res = new SqlCeDataAdapter();
                res.SelectCommand = _cmd;
                res.Fill(data);
                DB.deconectar();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return data;
        }
        public void agregar_Detalle(int ticket, string producto,int cantidad)
        {
            try
            {
                SqlCeCommand _cmd;
                DB.conectar();
                _cmd = new SqlCeCommand("INSERT INTO T_DetalleCompra(Ticket,IdProducto,Cantidad)" +
                    " VALUES('" + ticket + "','" + producto + "','" + cantidad + "')", DB.conexion());
                _cmd.ExecuteNonQuery();
                DB.deconectar();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
        }
       

        public DataSet BusquedaProducto(string valor)
        {
            DataSet data = new DataSet();
            ClassVenta classVenta = new ClassVenta();
            data =classVenta.Mostrardatosmodificar(valor);
            return data;
        }
        public bool verificar_cantidad(string codigo,int cantidad_selec)
        {
            bool verificar;
            
            try
            {
                SqlCeCommand _cmd;
                DB.conectar();
                _cmd = new SqlCeCommand("select Cantidad from T_Producto Where CodigoBarras="+codigo, DB.conexion());
              this.cantidad=Convert.ToInt32( _cmd.ExecuteScalar());
                DB.deconectar();


                DB.deconectar();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            if (cantidad>=cantidad_selec && cantidad>0)
            {
                verificar = true;
            }
            else
            {
                verificar = false;
            }
            return verificar;
        }
        public int cantidadexistente()
        {
            return cantidad;
        }
        public double sumaventas(int cantidad,double costo)
        {
            double total = 0;
            this.cantidad = cantidad;
            this.precioventa = costo;
            total = total + precioventa * cantidad;
            return total;
        }
        
    }

}
