using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrivateAssemblyProject;

namespace UsePrivateAssembly
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowsServices ws = new WindowsServices();
            this.cbService.DataSource = ws.GetService();
        }

        private void cbService_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbService.SelectedValue != null)
            {
                WindowsServices ws = new WindowsServices();
                this.lblService.Text = ws.GetService(cbService.SelectedValue.ToString());
            }
        }
    }
}
