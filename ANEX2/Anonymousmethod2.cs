 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ANEX2
{
    // Anonymous function
    class Anonymousmethod2
    {
        delegate void SomeDelegate(string source);
        private void ShowMSG(string msg)
        {
            MessageBox.Show(msg);
            // Cai nay minh them tren google code
         
        }

        public void InvokeDelegate()
        {
            SomeDelegate de = ShowMSG;
            de("Nguyen Van Vinh");
        }
        public void InvokeAnonymousmethod()
        { 
            // vi du su dung phuong thuc khong ten bang keyword 'delegate'!


            SomeDelegate d = delegate(string str)
            {
                MessageBox.Show(str);
            };
            d("Tran Thi Dieu Hoa");
          

        }
        public void InvokeLambdaExpression()
        {
            SomeDelegate de = ((str) =>
                {
                    MessageBox.Show(str);
                });
            de("Nguyen Hoang Mai Thao");
        }
        static void Main(string[] args)
        {
            Anonymousmethod2 ex = new Anonymousmethod2();
            ex.InvokeDelegate();
            ex.InvokeAnonymousmethod();
            ex.InvokeLambdaExpression();
        }
    }
}
