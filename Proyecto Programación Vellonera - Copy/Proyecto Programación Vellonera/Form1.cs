//using WMPLib;
using System.Media;

namespace Proyecto_Programación_Vellonera
{
    public partial class Form1 : Form
    {
        //WMPLib.WindowaMediaPlayer wplayer;
        Conexión con = new Conexión();
        public string rol;
        public  Form1() 
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
            //folderBrowserDialog1 = new FolderBrowserDialog();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "C:\\Hits";
            openFileDialog1.ShowDialog();
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sqlUrl = "Select * from Cancion";
            dataGridView1.DataSource = con.consulta(sqlUrl);

            
            
            if( rol == "Ray")
             {
                btnRorte.Visible=true;
            }
            else
            {               
                btnRorte.Visible = false;
            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void Musica_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            

        }

        private void panelReportes_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnmusica_Click(object sender, EventArgs e)
        {
            Musica musica = new Musica();
            musica.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Show();
        }

        private void btnToken_Click(object sender, EventArgs e)
        {
            Token token = new Token();
            token.Show();
        }

        private void btnRorte_Click(object sender, EventArgs e)
        {
            Reporte rep = new Reporte();
            rep.Show();
        }
    }
}