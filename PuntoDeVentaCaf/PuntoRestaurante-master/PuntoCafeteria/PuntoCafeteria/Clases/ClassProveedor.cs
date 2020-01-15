using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Data;

namespace PuntoCafeteria.Clases
{
    class ClassProveedor
    {
        DB DB = new DB();
        private string Nombre_Empresa { set; get; }
        private string Nombre_vendedor { set; get; }
        private int Numero { set; get; }
        private string  Direccion{ set; get; }
        private string Correo { set; get; }

       public ClassProveedor()
        {
            Nombre_Empresa = "";
            Nombre_vendedor = "";
            Numero = 0;
            Direccion = "";
            Correo = "";
        }
        public ClassProveedor(string nombreEmpr,string nombrev,int numero,string direccion,string correo)
        {
            Nombre_Empresa =  nombreEmpr;
            Nombre_vendedor = nombrev;
            Numero = numero;
            Direccion = direccion;
            Correo = correo;
        }
        public void Agregar_Proveedor()
        {
            try
            {
                SqlCeCommand _cmd;
                DB.conectar();
                _cmd = new SqlCeCommand("INSERT INTO T_Proovedor(Nombre,Direccion,Telefono,Correo,Nombre_vend)" +
                    " VALUES('" + Nombre_Empresa + "','" + Direccion + "','" + Numero + "" +
                     "','" + Correo + "','" + Nombre_vendedor + "')", DB.conexion());
                _cmd.ExecuteNonQuery();

                DB.deconectar();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            

        }
        public void Eliminarproveedor(int valor)
        {

    
            try
            {
                SqlCeCommand _cmd;
                DB.conectar();
                _cmd = new SqlCeCommand("Delete from T_Proovedor Where Idproovedor=" + valor, DB.conexion());
                _cmd.ExecuteNonQuery();
                DB.deconectar();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }

           
        }
        public DataSet Mostrarprovedores()
        {
            DataSet table = new DataSet();
            try
            {
                SqlCeCommand _cmd;
                DB.conectar();
                _cmd = new SqlCeCommand("select * from T_Proovedor", DB.conexion());
                SqlCeDataAdapter res = new SqlCeDataAdapter();
                res.SelectCommand = _cmd;
                res.Fill(table);
                DB.deconectar();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }

            return table;
        }
        public DataSet Mostrardatosmodificar(int valor)
        {

            DataSet data = new DataSet();
            try
            {
                SqlCeCommand _cmd;
                DB.conectar();
                _cmd = new SqlCeCommand("select Idproovedor,Nombre,Direccion,Telefono,Correo,Nombre_vend from T_Proovedor Where Idproovedor=" + valor, DB.conexion());
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
        public DataSet EliminarProveedor(int valor)
        {

            DataSet data = new DataSet();
            try
            {
                SqlCeCommand _cmd;
                DB.conectar();
                _cmd = new SqlCeCommand("Delete from T_Proovedor Where Idproovedor=" + valor, DB.conexion());
                _cmd.ExecuteNonQuery();
                DB.deconectar();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }

            return data;
        }
        public void modificarProveedor(int valor)
        {


            try
            {
                SqlCeCommand _cmd;
                DB.conectar();
                _cmd = new SqlCeCommand("Update T_Proovedor Set Nombre='" + Nombre_Empresa + "',Direccion='" + Direccion + "',Telefono='" + Numero + "',Correo='" + Correo + "',Nombre_Vend='" + Nombre_vendedor +"' Where Idproovedor='" + valor + "'", DB.conexion());
                _cmd.ExecuteNonQuery();
                DB.deconectar();


                DB.deconectar();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }


        }
    }

}

