using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Data;
using PuntoCafeteria.Clases;

namespace PuntoCafeteria.Clases
{
    class ClassConfiguracion
    {
        DB DB = new DB();
        private string nombre_impresora { set; get; }
        private string nombre_Establecimiento { set; get; }
        private string Direccion { set; get; }
        private double telefono { set; get; }
        private string RFC { set; get; }

        public ClassConfiguracion()
        {
            nombre_impresora = "";
            nombre_Establecimiento = "";
            Direccion = "";
            telefono=0;
            RFC = "";
        }
       public ClassConfiguracion(string nombreimpr,string nombre_establec,string direccion,double tel,string rfc)
        {
            nombre_impresora = nombreimpr;
            nombre_Establecimiento = nombre_establec;
            Direccion = direccion;
            telefono = tel;
            RFC = rfc;
        }
        public void agregarconfig()
        {
            try
            {
                SqlCeCommand _cmd;
                DB.conectar();
                _cmd = new SqlCeCommand("INSERT INTO Configuracion(Nombre_Impresora,Nombre_Establecimiento,Direccion,Telefono,RFC)" +
                    " VALUES('" + nombre_impresora + "','" + nombre_Establecimiento + "','" + Direccion + "" +
                     "','" + telefono + "','" + RFC + "')", DB.conexion());
                _cmd.ExecuteNonQuery();

                DB.deconectar();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }

        }
        public int apagarencenderalerta()
        {
            int alerta;
            
            if(obteneralerta()==true)
            {
                alerta = 0;
            }
            else
            {
                alerta = 1;
            }
            try
            {
                SqlCeCommand _cmd;
                DB.conectar();
                _cmd = new SqlCeCommand("Update Alerta Set Alerta='" +alerta+"'", DB.conexion());
                _cmd.ExecuteNonQuery();
                DB.deconectar();
                


                DB.deconectar();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            return alerta;
        }
        public Boolean obteneralerta()
        {
            Boolean estatus = false;
            try
            {
                SqlCeCommand _cmd;
                DB.conectar();
                _cmd = new SqlCeCommand("Select Alerta from Alerta", DB.conexion());
             estatus= Convert.ToBoolean(  _cmd.ExecuteScalar());
                DB.deconectar();


                DB.deconectar();
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);

            }
            return estatus;
        }

    }
}
