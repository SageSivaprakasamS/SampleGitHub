using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityApplicationBlock
{
    public class EventViewWriter : IWriter
    {
        public void Write(string msg)
        {
            EventLog.WriteEntry("TestUnity", msg,
                            EventLogEntryType.Information);
        }
    }
}
