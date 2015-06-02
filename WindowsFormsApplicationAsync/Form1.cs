using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplicationAsync
{
    public partial class Form1 : Form
    {
        string _url = "https://msdn.microsoft.com/en-us/library/system.io.streamwriter(v=vs.110).aspx";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var task = NewDownLoadStringAsync();

            string path = @"D:\test.txt";

            // Dosome thing
            var resilt = await task;
            
            StreamWriter sw = new StreamWriter(path);
            sw.Write(resilt);
            sw.Close();
          
        }

        private async Task<string> NewDownLoadStringAsync()
        {
            using (var client = new WebClient())
            {
                var taks = client.DownloadStringTaskAsync(new Uri(_url));
                // Do some thing
                var result = await taks;
                return result;

            }
        }
    }
}
