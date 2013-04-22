using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace UnityApplicationBlock
{
    public class WriterHelperCls
    {
        private IWriter selectWriter;

        [Dependency]
        public IWriter SelectedWriter
        {
            get { return selectWriter; }
            set { selectWriter = value; }
        }

        public void WriteOutput(string msg)
        {
            selectWriter.Write(msg);
        }
    }
}
