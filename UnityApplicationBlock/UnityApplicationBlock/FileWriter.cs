using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web;

namespace UnityApplicationBlock 
{
    public class FileWriter : IWriter
    {

        public void Write(string msg)
        {
             

            using (StreamWriter streamWriter =
                new StreamWriter("d:\\TestUnity.txt", false))
            {
                streamWriter.WriteLine(msg);
             
            }
        }
    }
}
