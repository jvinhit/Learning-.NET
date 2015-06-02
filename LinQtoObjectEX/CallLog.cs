using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQtoObjectEX
{
    public class CallLog
    {
        public String Number { get; set; }
        public Int32 Duration { get; set; }
        public Boolean Incoming { get; set; }
        public DateTime When { get; set; }

        public static List<CallLog> SampleData()
        {
            List<CallLog> calllogs = new List<CallLog>();

            calllogs.Add(new CallLog { Number = "885 983 8858", Duration = 2, Incoming = true, When = new DateTime(2006, 08, 07) });
            calllogs.Add(new CallLog { Number = "165 737 1656", Duration = 15, Incoming = true, When = new DateTime(2006, 08, 07) });
            calllogs.Add(new CallLog { Number = "364 202 3644", Duration = 1, Incoming = false, When = new DateTime(2006, 08, 07) });
            calllogs.Add(new CallLog { Number = "603 303 6030", Duration = 2, Incoming = false, When = new DateTime(2006, 08, 07) });
            calllogs.Add(new CallLog { Number = "546 607 5462", Duration = 4, Incoming = true, When = new DateTime(2006, 08, 07) });
            calllogs.Add(new CallLog { Number = "885 983 8858", Duration = 15, Incoming = false, When = new DateTime(2006, 08, 07) });
            calllogs.Add(new CallLog { Number = "885 983 8858", Duration = 3, Incoming = true, When = new DateTime(2006, 08, 07) });
            calllogs.Add(new CallLog { Number = "546 607 5462", Duration = 1, Incoming = false, When = new DateTime(2006, 08, 07) });
            calllogs.Add(new CallLog { Number = "546 607 5462", Duration = 3, Incoming = false, When = new DateTime(2006, 08, 08) });
            calllogs.Add(new CallLog { Number = "603 303 6030", Duration = 23, Incoming = false, When = new DateTime(2006, 08, 08) });
            calllogs.Add(new CallLog { Number = "848 553 8487", Duration = 3, Incoming = false, When = new DateTime(2006, 08, 08) });
            calllogs.Add(new CallLog { Number = "848 553 8487", Duration = 7, Incoming = true, When = new DateTime(2006, 08, 08) });
            calllogs.Add(new CallLog { Number = "278 918 2789", Duration = 6, Incoming = true, When = new DateTime(2006, 08, 08) });
            calllogs.Add(new CallLog { Number = "364 202 3644", Duration = 20, Incoming = true, When = new DateTime(2006, 08, 08) });

            return calllogs;
        }
    }
}
