using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlServerCe;

namespace PuntoCafeteria.Clases
{
    class ClassDepartamento
    {
        DB DB = new DB();
       
        private string nombre { set; get; }

        public ClassDepartamento()
        {
            
            this.nombre = "";
        }
        public ClassDepartamento(string nombre)
        {
            
            this.nombre = nombre;
        }
        public void Agregar_departamento()
        {
            
            try
            {
                SqlCeCommand _cmd;
                DB.conectar();
                _cmd = new SqlCeCommand("INSERT INTO T_Departamento(departamento) Values('" + nombre + "')", DB.conexion());
                SqlCeDataAdapter res = new SqlCeDataAdapter();
                _cmd.ExecuteNonQuery();
                DB.deconectar();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }

   
        }
        public DataTable listar_departamento()
        {
            DataTable table = new DataTable();
            try
            {
                SqlCeCommand _cmd;
                DB.conectar();
                _cmd = new SqlCeCommand("select Id,departamento from T_Departamento", DB.conexion());
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
        public DataSet departamentos()
        {
            DataSet table = new DataSet();
            try
            {
                SqlCeCommand _cmd;
                DB.conectar();
                _cmd = new SqlCeCommand("select Id,departamento from T_Departamento", DB.conexion());
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
        public void Eliminardepa(int valor)
        {

            
            try
            {
                SqlCeCommand _cmd;
                DB.conectar();
                _cmd = new SqlCeCommand("Delete from T_Departamento Where Id=" + valor, DB.conexion());
                _cmd.ExecuteNonQuery();
                DB.deconectar();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }

           
        }
        public DataSet Mostrardatosmodificar(int valor)
        {

            DataSet data = new DataSet();
            try
            {
                SqlCeCommand _cmd;
                DB.conectar();
                _cmd = new SqlCeCommand("select Id,departamento from T_Departamento Where Id=" + valor, DB.conexion());
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
        public void modificardepa(int valor)
        {


            try
            {
                SqlCeCommand _cmd;
                DB.conectar();
                _cmd = new SqlCeCommand("Update T_Departamento Set departamento='" + nombre + "' Where Id='" + valor + "'", DB.conexion());
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
