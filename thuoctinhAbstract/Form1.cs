using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace thuoctinhAbstract
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFiles_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Add("STT",100);
            listView1.Columns.Add("Name", 200);
            Class1 cls = new Class2();
            cls.Path = "D:\\";
            cls.Show(this.listView1);
            label1.Text = "CC " + cls.Path + " is " + cls.NumberOf;
        }
    }
}
