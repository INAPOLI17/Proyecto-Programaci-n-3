using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Proyecto_Programación_Vellonera
{
    public class Conexión
    {
        SqlConnection conectar = new SqlConnection(@"Data Source = (local); Initial Catalog = Musica; Integrated Security = True;");

        public DataTable consulta (string str)
        {
            DataTable tl = new DataTable();
            SqlDataAdapter sd = new SqlDataAdapter(str, conectar);
            sd.Fill (tl);
            return tl;
        }


    }
}
