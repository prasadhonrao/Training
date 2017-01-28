namespace Training.CSharp
{
    public delegate void WorkPerformedHandler(int hours, WorkType workType);

    public class Worker
    {
        public event WorkPerformedHandler WorkPerformed;

        public void DoWork(int hours, WorkType type)
        {
            for (int i = 0; i < hours; i++)
            {
                OnWorkPerformed(i, type);    
            }
        }

        private void OnWorkPerformed(int hours, WorkType type)
        {
            // ?. ensures checks for null instance hence checks that there is at least one subscriber to the event
            WorkPerformed?.Invoke(hours, type);
        }
    }
}
