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
    public partial class Token : Form
    {
        public Token()
        {
            InitializeComponent();
        }

        private void Token_Load(object sender, EventArgs e)
        {
            cmbClase.Items.Clear();
            cmbClase.Items.Add("Clase A");
            cmbClase.Items.Add("Clase B");
            cmbClase.Items.Add("Clase C");

            dgvDesc.Columns.Add("Nombre", "Clase");
            dgvDesc.Columns.Add("Descripción", "Descripción");
            dgvDesc.Rows.Add("Clase A ", "3 Canciones");
            dgvDesc.Rows.Add("Clase B ", "2 Canciones");
            dgvDesc.Rows.Add("Clase C ", "1 Canción");
       

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexión cone = new Conexión();
            ClaDatos token = new ClaDatos();
            Random aleatorio = new Random();

            int id = 0;
            id = aleatorio.Next(100001);

            if (cmbClase.SelectedItem.ToString() == "Clase A")
            {
                token.idToken = id.ToString();
                token.clase = cmbClase.SelectedItem.ToString();
                token.descripcion = dgvDesc.Rows[0].Cells[1].Value.ToString();
            }
            if (cmbClase.SelectedItem.ToString() == "Clase B")
            {
                token.idToken = id.ToString();
                token.clase = cmbClase.SelectedItem.ToString();
                token.descripcion = dgvDesc.Rows[1].Cells[1].Value.ToString();
            }
            if (cmbClase.SelectedItem.ToString() == "Clase A")
            {
                token.idToken = id.ToString();
                token.clase = cmbClase.SelectedItem.ToString();
                token.descripcion = dgvDesc.Rows[2].Cells[1].Value.ToString();
            }

            cone.ManejoDatos(token, "sp_InsertarTok", "Token");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbClase_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
