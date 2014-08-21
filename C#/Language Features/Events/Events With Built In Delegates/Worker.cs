using System;

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

        private void OnWorkPerformed(int hours, WorkType type)
        {
            if (WorkPerformed != null)
            {
                WorkPerformed(hours, type);
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
