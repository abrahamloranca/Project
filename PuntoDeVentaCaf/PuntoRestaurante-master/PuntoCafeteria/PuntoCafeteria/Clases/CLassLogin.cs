using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlServerCe;

namespace PuntoCafeteria.Clases
{
    class CLassLogin
    {
        DB DB = new DB();
        private string usuario { set; get; }
        private string contraseña { set; get; }

        public CLassLogin()
        {
            usuario = "";
            contraseña = "";
        }
        public CLassLogin(string user,string pass)
        {
            usuario = user;
            contraseña = pass;
        }
        public DataSet login()
        {
            DataSet table = new DataSet();
            try
            {
                SqlCeCommand _cmd;
                DB.conectar();
                _cmd = new SqlCeCommand("select count(*) from T_Empleado Where Usuario='"+ usuario+"' and Password='"+contraseña+"'" , DB.conexion());
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
        
    }
}

