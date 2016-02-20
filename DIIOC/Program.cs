using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIIOC.Implement;
using DIIOC.Interface;
using DIIOC.Mock;

namespace DIIOC
{
    class Program
    {
        static void Main(string[] args)
        {
            // Voi moi interface ta define 1 module tuong ung 
            DIContainer.SetModule<IDatabase,DataBase>();
            DIContainer.SetModule<IEmailSender, EmailSender>();
            DIContainer.SetModule<ILogger, Logger>();
            
            // DIContainer sẽ tự động inject  vào DataBase , EMailSender và Logger 
            //var myCart = DIContainer.GetModule<Cart>();
            // Khi can thay đổi thì ta chỉ cần sửa code define 
            //DIContainer.SetModule<IDatabase, XMLDatabase>();
            var myCart = new Cart(new XMLDatabase(), new EmailSender(), new Logger());
            myCart.CheckOut(1,1);
        }
    }
}
