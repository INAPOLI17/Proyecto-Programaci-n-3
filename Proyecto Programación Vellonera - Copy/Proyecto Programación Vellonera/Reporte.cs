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
    
    public partial class Reporte : Form
    {
        Conexión con = new Conexión();
        public Reporte()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            //Clientes
            string sqlString = "Select * from Cliente";
            dataGridView1.DataSource = con.consulta(sqlString);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Canciones
            string sqlString = "Select * from Cancion";
            dataGridView1.DataSource = con.consulta(sqlString);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Más escuchadas
            string sqlString = "Select * from Historial";
            dataGridView1.DataSource = con.consulta(sqlString);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Playlist
            string sqlString = "Select * from Playlist";
            dataGridView1.DataSource = con.consulta(sqlString);
        }
    }
}
