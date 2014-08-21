using System;

namespace Training.CSharp
{
    public class Worker
    {
        public event EventHandler<WorkPerformedEventArgs> WorkPerformed;

        public void DoWork(int hours, WorkType type)
        {
            for (int i = 0; i < hours; i++)
            {
                OnWorkPerformed(i, type);
            }
        }

        private void OnWorkPerformed(int hours, WorkType type)
        {
            if (WorkPerformed != null)
            {
                WorkPerformed(this, new WorkPerformedEventArgs(hours, type));
            }
        }
    }
}
