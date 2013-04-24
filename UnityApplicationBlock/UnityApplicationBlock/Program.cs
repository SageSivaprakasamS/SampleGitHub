using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System.Reflection;

namespace UnityApplicationBlock
{
    public class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer myUnityConatiner = new UnityContainer();
            UnityConfigurationSection configSection = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");

            configSection.Configure(myUnityConatiner,"FirstContainer");
            WriterHelperCls objWriter = myUnityConatiner.Resolve<WriterHelperCls>();

            objWriter.SelectedWriter.Write("Me Unity started.");

            //Assembly objAssembly;
            //objAssembly = Assembly.Load("IWriter");
            //Type types = objAssembly.GetType("");

            //foreach (Type item in types)
            //{
            //    Console.WriteLine(item.Name.ToString());
            //    Console.WriteLine(item.Module.ToString());
            //}
        }
    }
}
