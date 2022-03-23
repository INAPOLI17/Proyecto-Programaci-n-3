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

        public void ManejoDatos(ClaDatos datos, string stpsql, string tipo)
        {
            SqlCommand cmd = new SqlCommand(stpsql, conectar);
            conectar.Open();
            if (tipo == "Token")
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", datos.idToken);
                cmd.Parameters.AddWithValue("@Clase", datos.clase);
                cmd.Parameters.AddWithValue("@Descripción", datos.descripcion);

                cmd.ExecuteNonQuery();
            }
            if (tipo == "Cliente")
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", datos.id);
                cmd.Parameters.AddWithValue("@Usuario", datos.userName);
                cmd.Parameters.AddWithValue("@Plataforma", datos.Plataforma);


                cmd.ExecuteNonQuery();
            }
            if(tipo == "Play")
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IdCan", datos.idCan);
                cmd.Parameters.AddWithValue("@Orden", datos.orden);
                cmd.Parameters.AddWithValue("@Token", datos.idToken);

                cmd.ExecuteNonQuery();
            }
            if (tipo == "Cancion")
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", datos.idCan);
                cmd.Parameters.AddWithValue("@Nombre", datos.Nombre);
                cmd.Parameters.AddWithValue("@Artista", datos.Artista);
                cmd.Parameters.AddWithValue("@Album", datos.Album);
                cmd.Parameters.AddWithValue("@link", datos.link);

                cmd.ExecuteNonQuery();
            }
            if (tipo == "Borrar")
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", datos.id);


                cmd.ExecuteNonQuery();
            }

            conectar.Close();
        }
    }
}
