using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIIOC.Interface;

namespace DIIOC.Implement
{
    public class EmailSender:IEmailSender
    {
        public void SendEmail(int userId)
        {
            Console.WriteLine("Email has been Send");
        }
    }
}
