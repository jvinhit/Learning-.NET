
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassA a = new ClassA() { Message = "Vinh" };
            ClassB b = new ClassB();

            UnityContainer iOC = new UnityContainer();


            //iOC.RegisterInstance(a);
            //iOC.RegisterType<IClassA, ClassA>();
            iOC.RegisterType<IClassA, ClassA>(new ContainerControlledLifetimeManager());
            iOC.RegisterType<IClassB, ClassB>();

            ClassA a1 = iOC.Resolve<ClassA>();
            a1.Message = "Phan thi quynh trang";
            ClassC c = iOC.Resolve<ClassC>();


        }
    }
}
