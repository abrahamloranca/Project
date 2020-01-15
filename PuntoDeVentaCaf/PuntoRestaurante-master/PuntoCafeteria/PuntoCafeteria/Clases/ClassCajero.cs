using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Data;
namespace PuntoCafeteria.Clases
{
    class ClassCajero
    {
        //propiedades y contructores//
        private string idsuario { get; set; }
        private string usuario { get; set; }
        private string contraseña { get; set; }
        private string nombrecompleto { get; set; }
        private string direccion { get; set; }
        private int telefono { get; set; }
        private int Rol { get; set; }
        //clase base de datos//
        DB DB = new Clases.DB();

        public ClassCajero()
        {
            this.usuario = "";
            this.contraseña = "";
            this.nombrecompleto = "";
            this.direccion = "";
            this.telefono = 0;
            this.Rol = 0;
         }

        public ClassCajero(string usuario,string contraseña,string nombre,
                            string direccion,int telefono,int rol)
        {
            this.usuario = usuario;
            this.contraseña = contraseña;
            this.nombrecompleto = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            this.Rol = rol;
        }
        //metodos de la clase//
        public void agregar_cajero()
        {
            try
            {
                SqlCeCommand _cmd;
                DB.conectar();
                _cmd = new SqlCeCommand("INSERT INTO T_Empleado(Usuario,Password,Nombre,Direccion,Telefono,Rol)"+
                    " VALUES('"+usuario+"','"+contraseña+"','"+nombrecompleto+""+
                     "','"+direccion+"','"+telefono+"','"+Rol+"')", DB.conexion());
                _cmd.ExecuteNonQuery();
          
                DB.deconectar();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
           
           
        }
        public int Verificar_usuario()
        {
            int Resultado = 0;
            try
            {
                SqlCeCommand _cmd;
                DB.conectar();
                _cmd = new SqlCeCommand("select count(Usuario) from T_Empleado where Usuario ='" + usuario + "'", DB.conexion());
                 Resultado= Convert.ToInt32( _cmd.ExecuteScalar());

                DB.deconectar();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return Resultado;

        }
        public DataSet MostrarUsuario()
        {
            DataSet table = new  DataSet();
            try
            {
                SqlCeCommand _cmd;
                DB.conectar();
                _cmd = new SqlCeCommand("select Idusuario,Nombre from T_Empleado", DB.conexion());
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
                _cmd = new SqlCeCommand("select Idusuario,Usuario,Password,Nombre,Direccion,Telefono,Rol from T_Empleado Where Idusuario="+valor, DB.conexion());
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
        public DataSet Eliminarcajro(int valor)
        {

            DataSet data = new DataSet();
            try
            {
                SqlCeCommand _cmd;
                DB.conectar();
                _cmd = new SqlCeCommand("Delete from T_Empleado Where Idusuario=" + valor, DB.conexion());
                _cmd.ExecuteNonQuery();
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

