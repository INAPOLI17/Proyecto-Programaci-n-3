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
    public partial class Musica : Form
    {
        ClaDatos cladatos = new ClaDatos();
        Conexión con = new Conexión();

        public Musica()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtIdCancion.Clear();
            txtNomCan.Clear();
            txtCanArt.Clear();
            txtAlbCan.Clear();
            txtCanLin.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cladatos.idCan = txtIdCancion.Text;
            cladatos.Nombre= txtNomCan.Text;
            cladatos.Artista= txtCanArt.Text;
            cladatos.Album= txtAlbCan.Text;
            cladatos.link = txtCanLin.Text;


            con.ManejoDatos(cladatos, "sp_InsertarCan", "Cancion");
            actualizar();
            
        }

        private void Musica_Load(object sender, EventArgs e)
        {
            actualizar();
        }

        private void actualizar()
        {
            dataGridView1.DataSource = con.consulta("Select idCan as ID, nomCan as Título, artCan as Artista, albCan as Album, linCan as Ubicación from Cancion");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            cladatos.id = int.Parse(txtIdCancion.Text);

            con.ManejoDatos(cladatos, "sp_DeleteCan", "Borrar");
            actualizar();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            txtIdCancion.Text = dataGridView1.SelectedCells[0].Value.ToString();
            txtNomCan.Text = dataGridView1.SelectedCells[1].Value.ToString();
            txtCanArt.Text = dataGridView1.SelectedCells[2].Value.ToString();
            txtAlbCan.Text = dataGridView1.SelectedCells[3].Value.ToString();
            txtCanLin.Text = dataGridView1.SelectedCells[4].Value.ToString();

        }
    }
}
