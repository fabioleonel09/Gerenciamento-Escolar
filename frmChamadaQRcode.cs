using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using System.Media;

namespace GestaoEscolarSistemasLua
{
    public partial class frmChamadaQRcode : Form
    {
        public frmChamadaQRcode()
        {
            InitializeComponent();
          
            btnSairBiblioteca.Enabled = false;
            btnSairBiblioteca.BackColor = Color.WhiteSmoke;
            button3.Enabled = false;
            button3.BackColor = Color.WhiteSmoke;
            btnStart.Enabled = true;
            btnBiblioteca.Enabled = true;            
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;
        SoundPlayer som;

        private void frmChamadaQRcode_Load(object sender, EventArgs e)
        {            
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                cboDevice.Items.Add(filterInfo.Name);
            cboDevice.SelectedIndex = 0;         
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            txtQRCode.Clear();

            captureDevice = new VideoCaptureDevice(filterInfoCollection[cboDevice.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();

            btnStart.Enabled = false;
            btnStart.BackColor = Color.WhiteSmoke;
            btnBiblioteca.Enabled = false;
            btnBiblioteca.BackColor = Color.WhiteSmoke;
            btnSairBiblioteca.Enabled = false;
            btnSairBiblioteca.BackColor = Color.WhiteSmoke;
            button3.Enabled = true;
            button3.BackColor = Color.Gold;
        }

        private void CaptureDevice_NewFrame (Object sender, NewFrameEventArgs eventArgs)
        {
           pictureBox.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            if (captureDevice.IsRunning)
            {
                captureDevice.Stop();
            }

            MessageBox.Show("Clique em imprimir para o programa gerar a lista de chamada para a impressão!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnSairBiblioteca.Enabled = false;
            btnSairBiblioteca.BackColor = Color.WhiteSmoke;
            button3.Enabled = false;
            button3.BackColor = Color.WhiteSmoke;
            btnStart.Enabled = true;
            btnStart.BackColor = Color.LightGreen;
            btnBiblioteca.Enabled = true;
            btnBiblioteca.BackColor = Color.LightSkyBlue;        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pictureBox.Image);

                if (result != null )
                {
                    txtQRCode.Text += result.ToString() + "\r\n" + "\r\n";

                    som = new SoundPlayer(Properties.Resources.efeitoSonoro);
                    som.Play();
                }

            }
        }

        private void btnSairJanela_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBiblioteca_Click(object sender, EventArgs e)
        {
            txtQRCode.Clear();

            captureDevice = new VideoCaptureDevice(filterInfoCollection[cboDevice.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();

            btnSairBiblioteca.Enabled = true;
            btnSairBiblioteca.BackColor = Color.White;
            button3.Enabled = false;
            button3.BackColor = Color.WhiteSmoke;
            btnStart.Enabled = false;
            btnStart.BackColor = Color.WhiteSmoke;
            btnBiblioteca.Enabled = false;
            btnBiblioteca.BackColor = Color.WhiteSmoke;
        }

        private void btnSairBiblioteca_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            if (captureDevice.IsRunning)
            {
                captureDevice.Stop();
            }

            MessageBox.Show("Clique em imprimir para o programa gerar a lista de livros para a impressão!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
         
            btnSairBiblioteca.Enabled = false;
            btnSairBiblioteca.BackColor = Color.WhiteSmoke;
            button3.Enabled = false;
            button3.BackColor = Color.WhiteSmoke;
            btnStart.Enabled = true;
            btnStart.BackColor = Color.LightGreen;
            btnBiblioteca.Enabled = true;
            btnBiblioteca.BackColor = Color.LightSkyBlue;         
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            frmImprimirChamadaBiblioteca ficb = new frmImprimirChamadaBiblioteca(txtQRCode.Text);
            ficb.Show();
        }
    }
}
