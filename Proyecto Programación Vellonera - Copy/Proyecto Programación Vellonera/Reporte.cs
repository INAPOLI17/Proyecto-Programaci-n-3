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
        int tipo;
        public Reporte()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            //Clientes
            string sqlString = "Select idCli as Id, usuCli as Usuario, plaCli as Plataforma from Cliente";
            dataGridView1.DataSource = con.consulta(sqlString);
            tipo = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Canciones
            string sqlString = "Select idCan as Id, nomCan as Titulo, artCan as Artista from Cancion";
            dataGridView1.DataSource = con.consulta(sqlString);
            tipo = 2;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Más escuchadas
            string sqlString = "Select idCli as 'Id Cliente', idCan as 'Id Cancion', timPlay as 'Tiempo Reproducción' from Historial";
            dataGridView1.DataSource = con.consulta(sqlString);
            tipo = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Playlist
            string sqlString = "Select idCan as 'Id Cancion', numOrd as Orden, idTok as Token from Playlist";
            dataGridView1.DataSource = con.consulta(sqlString);
            tipo = 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Imprimir
            if(tipo == 1)
            {
                Imprimir("Reporte de Clientes", "Id", "Usuario", "Plataforma");
            } else if(tipo == 2)
            {
                Imprimir("Reporte de Canciones", "Id", "Título", "Album");
            }
            else if (tipo == 3)
            {
                Imprimir("Reporte de Canciones Más Escuchadas", "Id", "Título", "Album");
            }
            else if (tipo == 4)
            {
                Imprimir("Reporte de Playlists", "Id", "Título", "Album");
            }

        }   

            private void Imprimir(string tipoReporte, string par1, string par2, string par3)
        {
            SaveFileDialog impReporte = new SaveFileDialog();
            impReporte.FileName = "Reporte" + DateTime.Now.ToString("dd-mm-yyyy-hh-mm")+".pdf";
            
            string paginaTexto = Properties.Resources.plantillaReporte.ToString();
            paginaTexto = paginaTexto.Replace("@Reporte", tipoReporte);
            paginaTexto = paginaTexto.Replace("@Col1", par1);
            paginaTexto = paginaTexto.Replace("@Col2", par2);
            paginaTexto = paginaTexto.Replace("@Col3", par3);
            paginaTexto = paginaTexto.Replace("@Fecha", DateTime.Now.ToString("dd-mm-yyyy      hh:mm tt"));

            string filas = string.Empty;
           
             for(int i= 0; i< dataGridView1.Rows.Count -1 ; i++)
            {
                filas += "<tr>";
                filas += "<td>" + dataGridView1.Rows[i].Cells[0].Value.ToString() + "</td>";
                filas += "<td>" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "</td>";
                filas += "<td>" + dataGridView1.Rows[i].Cells[2].Value.ToString() + "</td>";
                filas += "</tr>";

            }
            
            
            paginaTexto = paginaTexto.Replace("@Filas", filas);
            

            if (impReporte.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fileStream = new FileStream(impReporte.FileName, FileMode.Create))
                {
                    Document doc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(doc, fileStream);

                    doc.Open();
                    doc.Add(new Phrase(""));

                    using (StringReader reader = new StringReader(paginaTexto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, doc, reader);
                    }

                    doc.Close();
                    fileStream.Close();
                }
            }
        }

        private void Reporte_Load(object sender, EventArgs e)
        {

        }
    }
}
