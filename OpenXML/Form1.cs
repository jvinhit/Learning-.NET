using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace OpenXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenDocument_Click(object sender, EventArgs e)
        {
            try
            {
                string path = txtPath.Text;
                XmlDocument document =new XmlDocument();
                if (rdURL.Checked == true)
                {
                    document.Load(path);
                }
                if (rdStream.Checked == true)
                {
                    FileStream fs;
                    fs = File.OpenRead(path);
                    document.Load(fs);

                }
                if (rdMemory.Checked == true)
                {
                    
                }
            }
            catch (Exception rx)
            {
                MessageBox.Show(rx.ToString());
                throw;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\employees.xml";
            XmlDocument document = new XmlDocument();
            document.Load(path);
            // Return Name of Root Node
            TreeNode rootNode = treeView1.Nodes.Add(document.DocumentElement.Name);
            XmlNodeList nodes = document.DocumentElement.ChildNodes;
            foreach (XmlNode childnode in nodes)
            {
                TreeNode empNode = new TreeNode(childnode.Name + ":" + childnode.Attributes["employeeid"].Name + "=" + childnode.Attributes["employeeid"].Value);
                
                foreach (XmlNode node in childnode.ChildNodes)
                {
                    if (node.Name == "firstname")
                    {
                        empNode.Nodes.Add("First Name:" + node.InnerText);
                    }
                    if (node.Name == "lastname")
                    {
                        empNode.Nodes.Add("Last Name:" + node.InnerText);
                    }
                    if (node.Name == "homephone")
                    {
                        empNode.Nodes.Add("Home Phone:" + node.InnerText);
                    }
                    if (node.Name == "notes")
                    {
                        empNode.Nodes.Add("Notes:" + node.InnerText);
                    }
                }
                rootNode.Nodes.Add(empNode);
            }
        }
    }
}
