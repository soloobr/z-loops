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
        public Atualizando()
        {
            InitializeComponent();
        }

        private void Atualizando_Load(object sender, EventArgs e)
        {
            Atualizar();
        }
        private void Atualizar()
        {
            //WebClient webClient = new WebClient();
            var client = new WebClient();

            //try
            //{
            System.Threading.Thread.Sleep(5000);
            File.Delete(@".\LM-Financiamentos.exe");
            client.DownloadFile("https://lmfinanciamentos.com.br/update/update.zip", @"update.zip");
            string zipPath = @".\update.zip";
            string extractPath = @".\";
            ZipFile.ExtractToDirectory(zipPath, extractPath);
            File.Delete(@".\update.zip");
            System.Threading.Thread.Sleep(5000);
            Process.Start(@".\LM-Financiamentos.exe");
            Close();

            //}
            //catch
            //{
            //Process.Start(@".\LM-Financiamentos.exe");
            //Close();
            //}
        }
    }
}
