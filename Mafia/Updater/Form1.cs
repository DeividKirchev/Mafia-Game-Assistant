using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.IO.Compression;

namespace Updater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            WebClient webClient = new WebClient();
            var client = new WebClient();

            try
            {
                System.Threading.Thread.Sleep(5000);
                File.Delete(@".\Mafia.exe");
                client.DownloadFile("https://drive.google.com/file/d/1HlqTo6MKJoLX9FAJ8wp8aDK6Zd6npl_r/view?usp=sharing", @"Mafia.zip");
                string zipPath = @".\Mafia.zip";
                string extractPath = @".\";
                ZipFile.ExtractToDirectory(zipPath, extractPath);
                File.Delete(@".\Mafia.zip");
                Process.Start(@".\Mafia.exe");
                this.Close();
            }
            catch
            {
                Process.Start("Mafia.exe");
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
