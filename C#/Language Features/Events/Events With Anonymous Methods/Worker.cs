using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.CSharp
{
    public delegate void WorkPerformedHandler(int hours, WorkType workType);

    public class Worker
    {
        public event WorkPerformedHandler WorkPerformed;
        public event EventHandler WorkCompleted;

        public void DoWork(int hours, WorkType type)
        {
            for (int i = 0; i < hours; i++)
            {
                OnWorkPerformed(i, type);
            }

            OnWorkCompleted();
        }

        private void OnWorkCompleted()
        {
            if (WorkCompleted != null)
            {
                WorkCompleted(this, EventArgs.Empty);
            }
        }

        private void OnWorkPerformed(int hours, WorkType type)
        {
            // Ensure that there is at least one subscriber to the event
            if (WorkPerformed != null)
            {
                WorkPerformed(hours, type);
            }
        }
    }
}
