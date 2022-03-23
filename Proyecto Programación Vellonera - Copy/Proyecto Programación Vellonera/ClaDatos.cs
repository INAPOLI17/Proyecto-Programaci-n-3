using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Programación_Vellonera
{
    public class ClaDatos
    {
// Token
        public string idToken { get; set; }
        public string clase { get; set; }
        public string descripcion { get; set; }

//Cliente
        public int id { get; set; }
        public string userName { get; set; }
        public string Plataforma { get; set; }

//Playlist

        public string orden { get; set; }

//Cancion
        
        public string idCan { get; set; }
        public string Nombre { get; set; }
        public string Artista { get; set; }
        public string Album { get; set; }
        public string link { get; set; }

    }
}
