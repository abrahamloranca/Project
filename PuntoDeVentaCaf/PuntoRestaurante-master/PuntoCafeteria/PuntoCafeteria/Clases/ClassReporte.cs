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
    class ClassReporte
    {
        DB DB = new DB();    
        public DataSet Consultarmasvendido(string valor,string valor2)
        {

            DataSet data = new DataSet();
            try
            {
                SqlCeCommand _cmd;
                DB.conectar();
                _cmd = new SqlCeCommand("select p.Nombre,Sum(d.Cantidad) as vendidos from T_Producto p " +
                    "inner join T_DetalleCompra d on d.IdProducto=p.CodigoBarras" +
                    " inner join T_Ticket t on d.Ticket=t.Ticket where t.FechaVenta BETWEEN '"+valor+"' AND '"+valor2+"'" +
                    " group by d.IdProducto,p.Nombre order by vendidos desc", DB.conexion());
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
