using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlServerCe;
using System.Data.SqlClient;
using System.Configuration;

namespace PuntoCafeteria.Clases
{
    class DB
    {
       private SqlCeConnection _con { set; get; }
       
  
        public void conectar()
        {
            try
            {
                ConnectionStringSettings Conconf = ConfigurationManager.ConnectionStrings["DBconexion"];
               string conexioncadena = Conconf.ConnectionString;
                _con = new SqlCeConnection(conexioncadena);
                _con.Open();
            }
        catch (Exception e)
            {
            Console.WriteLine("{0} Exception caught.", e);
            }
             
     
        }
        public void deconectar()
        {
            _con.Close();
        }
        public SqlCeConnection conexion()
        {
            return _con;
        }
    }
}
