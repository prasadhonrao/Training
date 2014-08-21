using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.CSharp
{
    public delegate void WorkPerformedHandler(object sender, WorkPerformedEventArgs args);

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

        private void OnWorkPerformed(int hours, WorkType type)
        {
            if (WorkPerformed != null)
            {
                WorkPerformed(this, new WorkPerformedEventArgs(hours, type));
            }
        }

        private void OnWorkCompleted()
        {
            if (WorkCompleted != null)
            {
                WorkCompleted(this, EventArgs.Empty);
            }
        }
    }
}
