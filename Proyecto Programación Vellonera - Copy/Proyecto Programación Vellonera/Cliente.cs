using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Programación_Vellonera
{
    
    public partial class Cliente : Form
    {
        ClaDatos cladatos = new ClaDatos();
        Conexión con = new Conexión();
        public Cliente()
        {
            InitializeComponent();
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtIdCliente.Clear();
            txtUsuario.Clear();
            txtPlataforma.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
