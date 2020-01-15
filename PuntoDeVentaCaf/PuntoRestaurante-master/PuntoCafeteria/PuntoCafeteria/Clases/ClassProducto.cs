using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Data;

namespace PuntoCafeteria.Clases
{
    class ClassProducto
    {
        DB DB = new DB();
        private string codigobarras { set; get; }
        private string nombre { set; get; }
        private string descripcion { set; get; }
        private double costo { set; get; }
        private double ganancia { set; get; }
        private int iva { set; get; }
        private double precioventa { set; get; }
        private int departamento { set; get; }
        private int Cantidad { set; get; }
        private int Minimo { set; get; }
        private int Proveedor { set; get; }

        public ClassProducto()
        {
            this.codigobarras = "";
            this.nombre = "";
            this.descripcion = "";
            this.costo = 0;
            this.ganancia = 0;
            this.iva = 0;
            this.precioventa = 0;
            this.Cantidad = 0;
            this.Minimo = 0;
            this.Proveedor = 0;
        }
        public ClassProducto(string codigobarra,string nombre,string descripcion,double costo
                              ,double ganancia,int iva,double precioventa,int cantidad,int minimo,int departamento,int proveedor)
        {
            this.codigobarras = codigobarra;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.costo = costo;
            this.ganancia = ganancia;
            this.iva = iva;
            this.precioventa = precioventa;
            this.Cantidad = cantidad;
            this.Minimo = minimo;
            this.departamento = departamento;
            this.Proveedor = proveedor;
        }
        public void agregar_producto()
        {
            try
            {
                SqlCeCommand _cmd;
                DB.conectar();
                _cmd = new SqlCeCommand("INSERT INTO T_Producto(CodigoBarras,Nombre,Descripcion,Costo,Ganancia," +
                                                                "iva,PrecioVenta,Cantidad,Minimo,Departamento,Proveedor)" +
                    " VALUES('" + codigobarras + "','" + nombre + "','" + descripcion + "" +
                     "','" + costo + "','" + ganancia + "','" + iva + "','" + precioventa + "','" + Cantidad + 
                     "','" + Minimo + "','" + departamento + "','" + Proveedor+ "')", DB.conexion());
                _cmd.ExecuteNonQuery();
                DB.deconectar();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
        }
        public DataSet Mostrardatosmodificar(string valor)
        {

            DataSet data = new DataSet();
            try
            {
                SqlCeCommand _cmd;
                DB.conectar();
                _cmd = new SqlCeCommand("select CodigoBarras, Nombre,Descripcion,Costo,Ganancia,iva,PrecioVenta,Cantidad,Minimo,Departamento,Proveedor from T_Producto Where CodigoBarras='" + valor+"'", DB.conexion());
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

        public void modifcarProducto(string valor)
        {

            
            try
            {
                SqlCeCommand _cmd;
                DB.conectar();
                _cmd = new SqlCeCommand("Update T_Producto Set Nombre='"+nombre+ "',Descripcion='" + descripcion + "',Costo='" + costo + "',Ganancia='" + ganancia + "',iva='" + iva + "',PrecioVenta='" + precioventa + "'" +
                    ",Cantidad='" + Cantidad + "',Minimo='" + Minimo + "',Departamento='" + departamento+"', Proveedor = '" + Proveedor+"' Where CodigoBarras='" + valor + "'", DB.conexion());
                _cmd.ExecuteNonQuery();
                DB.deconectar();
               

                DB.deconectar();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }

      
        }
        public DataSet EliminarProducto(string valor)
        {

            DataSet data = new DataSet();
            try
            {
                SqlCeCommand _cmd;
                DB.conectar();
                _cmd = new SqlCeCommand("Delete from T_Producto Where CodigoBarras=" + valor, DB.conexion());
                _cmd.ExecuteNonQuery();
                DB.deconectar();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }

            return data;
        }
        public void AgregarCantidad(string valor,int canti)
        {


            try
            {
                SqlCeCommand _cmd;
                DB.conectar();
                _cmd = new SqlCeCommand("Update T_Producto Set Cantidad='" + canti + "'Where CodigoBarras='" + valor + "'", DB.conexion());
                _cmd.ExecuteNonQuery();
                DB.deconectar();


                DB.deconectar();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }


        }
        public DataSet Productosbajos()
        {

            DataSet data = new DataSet();
            try
            {
                SqlCeCommand _cmd;
                DB.conectar();
                _cmd = new SqlCeCommand("Select Nombre,Descripcion,PrecioVenta,Cantidad,Minimo from T_Producto Where Cantidad<Minimo", DB.conexion());
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
        public DataSet ProductosPordepa(int valor)
        {

            DataSet data = new DataSet();
            try
            {
                SqlCeCommand _cmd;
                DB.conectar();
                _cmd = new SqlCeCommand("Select Nombre,Descripcion,PrecioVenta,Cantidad,Minimo from T_Producto Where Departamento="+valor, DB.conexion());
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
        public DataSet TotalesInventario()
        {

            DataSet data = new DataSet();
            try
            {
                SqlCeCommand _cmd;
                DB.conectar();
                _cmd = new SqlCeCommand("select sum(PrecioVenta*Cantidad) as precioventa, sum(Cantidad) as cantidad from T_Producto", DB.conexion());
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
    }
}
