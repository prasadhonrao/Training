using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.CSharp
{
    public class WorkPerformedEventArgs : EventArgs
    {
        public int Hour { get; set; }
        public WorkType WorkType { get; set; }

        public WorkPerformedEventArgs(int hour, WorkType workType)
        {
            this.Hour = hour;
            this.WorkType = workType;
        }
    }
}
