//using WMPLib;
using System.Media;

namespace Proyecto_Programación_Vellonera
{
    public partial class Form1 : Form
    {
        //WMPLib.WindowaMediaPlayer wplayer;
        Conexión con = new Conexión();
        public Form1() 
        {
            InitializeComponent();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void PlayFile(String url)
        {
            //wplayer = new WMPLib.WindowsMediaPlayer();
            //wplayer.PlayStateChange += wplayer.PlayStateChange;
            //wplayer.URL = url;
            //wplayer.controls.play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog1.ShowDialog();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sqlUrl = "Select * from Cancion";
            dataGridView1.DataSource = con.consulta(sqlUrl);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Reporte rep = new Reporte();
            rep.Show();
        }

        private void Musica_Click(object sender, EventArgs e)
        {
            Musica musica = new Musica();
            musica.Show();
        }
    }
}