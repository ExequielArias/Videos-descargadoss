using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;  

namespace Videos_descargadoss
{
    public partial class frmReproductor : Form
    {
        public frmReproductor()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            wmpReproductor.uiMode = "full"; //se puede cambiar a none para esconder los controladores del reproductor de video
            StreamReader sr = new StreamReader("Links.txt");
            string linea;
            while (sr.EndOfStream == false)
            {
                linea = sr.ReadLine();
                string[] datos = linea.Split(',');
                cboSeleccion.Items.Add(datos[1]);  
            }
            cboSeleccion.SelectedIndex = 0; 

            sr.Close();
            sr.Dispose(); 
        }

        private void cboSeleccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string video = "video" + (cboSeleccion.SelectedIndex + 1).ToString() + ".mp4";
            wmpReproductor.URL = video;  
        }
    }
}
