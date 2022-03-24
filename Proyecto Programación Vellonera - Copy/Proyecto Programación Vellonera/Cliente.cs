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
            if(txtIdCliente.Text != string.Empty)
            {
                cladatos.id = int.Parse(txtIdCliente.Text);
            }
            cladatos.userName = txtUsuario.Text;
            cladatos.Plataforma = txtPlataforma.Text;

            con.ManejoDatos(cladatos, "sp_InsertarCli", "Cliente");

            actualizar();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            actualizar();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + " " + dataGridView1.SelectedRows[0].Cells[1].Value.ToString() + " " + dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
           // txtIdCliente.Text = dataGridView1.SelectedCells[0].Value.ToString();
            //txtUsuario.Text = dataGridView1.SelectedCells[1].Value.ToString();
            //txtPlataforma.Text = dataGridView1.SelectedCells[2].Value.ToString();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            cladatos.id = int.Parse(txtIdCliente.Text);

            con.ManejoDatos(cladatos, "sp_DeleteCli", "Borrar");

            actualizar();
        }

        private void actualizar()
        {
            dataGridView1.DataSource = con.consulta("Select idCli as Cliente, usuCli as Usuario, plaCli as Plataforma from Cliente");
        }
    }
}
