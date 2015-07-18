using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceProcess;
namespace PrivateAssemblyProject
{
    public class WindowsServices
    {
        public string GetService(string serviceName)
        {
            // variable contain service
            ServiceController sc= new ServiceController();
            sc.ServiceName = serviceName;
            return sc.Status.ToString();
        }

        public string[] GetService()
        {
            ServiceController []sc= ServiceController.GetServices();
            string[] _serviceName= new string[sc.Length];
            int i = 0;
            foreach (var scs in sc)
            {
                _serviceName[i] = scs.ServiceName;
                i++;
            }
            return _serviceName;
        }
    }
}
