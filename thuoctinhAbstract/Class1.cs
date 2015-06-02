using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace thuoctinhAbstract
{
    abstract class Class1
    {
        public abstract string Path { get; set; }
        public abstract int NumberOf { get;  }
        public abstract void Show(ListView lstView);
        public void Show(ListView lstView, ComboBox cbView)
        {

            // Do some things
        }
    }
    // Ghi de thuoc tinh o lop con
    class Class2: Class1
    {
        private string strPathValue;
        private int iNumberoffile;
        // Phan than cua thuoc tinh truu tuong NumberOf
        public override int NumberOf
        {
            
            get
            {
                return iNumberoffile;
            }
        }
        // phan than cua Path
        public override string Path
        {
            get
            {
                return strPathValue;
            }
            set
            {
                strPathValue = value ;
            }
        }
        // Phan than cua phuong thuc truu tuong
        public override void Show(ListView lstView)
        {
            lstView.Items.Clear();
            iNumberoffile = 0;
            ListViewItem lvi;
            // Duyet tren tung tap tin
            foreach(string s in Directory.GetFiles(strPathValue))
            {
                iNumberoffile += 1;
                lvi = new ListViewItem(iNumberoffile.ToString());
                lvi.SubItems.Add(s);
                lstView.Items.Add(lvi);
              
            }
        }
    }
}
