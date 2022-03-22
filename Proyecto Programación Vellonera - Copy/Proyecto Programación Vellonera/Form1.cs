//using WMPLib;
using System.Media;

namespace Proyecto_Programación_Vellonera
{
    public partial class Form1 : Form
    {
        //WMPLib.WindowaMediaPlayer wplayer;
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
    }
}