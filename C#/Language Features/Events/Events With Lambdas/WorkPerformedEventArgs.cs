using System;

namespace Training.CSharp
{
    public class WorkPerformedEventArgs : EventArgs
    {
        public int Hours { get; set; }
        public WorkType WorkType { get; set; }

        public WorkPerformedEventArgs(int hours, WorkType type)
        {
            this.Hours = hours;
            this.WorkType = type;
        }
    }
}
