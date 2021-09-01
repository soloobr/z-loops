using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpdateLM
{
    public partial class Atualizando : Form
    {
        private int counter = 5;

        public Atualizando()
        {
            InitializeComponent();
        }

        private void Atualizando_Load(object sender, EventArgs e)
        {
            var client = new WebClient();

            System.Threading.Thread.Sleep(5000);
            if (File.Exists(@".\LM-Financiamentos.exe"))
            {
              File.Delete(@".\LM-Financiamentos.exe");
            }
            if (File.Exists(@".\update.zip"))
            {
                File.Delete(@".\update.zip");
            }

            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            // Starts the download
            client.DownloadFileAsync(new Uri("https://lmfinanciamentos.com.br/update/update.zip"), @".\update.zip");
            
            //System.Threading.Thread.Sleep(5000);
                //File.Delete(@".\LM-Financiamentos.exe");
                ////client.DownloadFile("https://lmfinanciamentos.com.br/update/update.zip", @"update.zip");
                //string zipPath = @".\update.zip";
                //string extractPath = @".\";
                //ZipFile.ExtractToDirectory(zipPath, extractPath);
                //File.Delete(@".\update.zip");
                //Process.Start(@".\LM-Financiamentos.exe");
                ////Close();
                //MessageBox.Show("Atualização Feita Com Sucesso!");
            //}
            //catch
           // {
                //Process.Start(@".\LM-Financiamentos.exe");
                //Close();
             //   MessageBox.Show("Não fez!");
            //}

        }
        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;

            progressBar1.Value = int.Parse(Math.Truncate(percentage).ToString());
        }
        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            string zipPath = @".\update.zip";
            string extractPath = @".\";
            ZipFile.ExtractToDirectory(zipPath, extractPath);
            lblatualizar.Text = "Sistema Atualizado!";
            timer.Enabled = true;
            lblCountDown.Visible = true;

        }

        private void Atualizando_FormClosed(object sender, FormClosedEventArgs e)
        {
            File.Delete(@".\update.zip");
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == -1)
            {
                if (File.Exists(@".\LM-Financiamentos.exe"))
                {
                    Process.Start(@".\LM-Financiamentos.exe");
                    Close();
                }
                timer.Stop();

            }
                
            lblCountDown.Text = counter.ToString();

           
        }
    }
}
