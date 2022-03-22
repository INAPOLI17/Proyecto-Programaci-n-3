using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;

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

        private void button5_Click(object sender, EventArgs e)
        {
            //Imprimir
            SaveFileDialog impReporte = new SaveFileDialog();
            impReporte.FileName = "Reporte" + DateTime.Now.ToString("dd-mm-yyyy") + ".pdf";
            impReporte.ShowDialog();

            if(impReporte.ShowDialog()== DialogResult.OK)
            {
                using (FileStream fileStream = new FileStream(impReporte.FileName, FileMode.Create))
                {
                    Document doc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(doc, fileStream);

                    doc.Open();
                    doc.Add(new Phrase("Prueba PDF"));
                    doc.Close();
                    fileStream.Close();
                }
                

            }
        }
    }
}
