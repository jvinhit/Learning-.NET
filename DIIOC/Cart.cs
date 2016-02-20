using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIIOC.Interface;

namespace DIIOC
{
    public class Cart
    {
        IDatabase _db;
        IEmailSender _es;
        ILogger _log;

        public Cart(IDatabase db, IEmailSender es, ILogger log)
        {
            _db = db;
            _log = log;
            _es = es;
        }

        public void CheckOut(int orderId, int userId)
        {
            _db.Save(orderId);
            _es.SendEmail(userId);
            _log.LogInfo("Has been save log info");
        }
    }
}
