using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.CSharp
{
    public delegate void WorkPerformedHandler(int hours, WorkType type);
    
    public class Worker
    {
        List<WorkPerformedHandler> subscribers = new List<WorkPerformedHandler>();
        private event WorkPerformedHandler _workPerformed;

        public event WorkPerformedHandler WorkPerformed
        {
            add
            {
                if (!subscribers.Contains(value))
                {
                    _workPerformed += value;
                    subscribers.Add(value);
                }
            }
            remove
            {
                _workPerformed -= value;
                subscribers.Remove(value);
            }
        }

        public void DoWork(int hours, WorkType type)
        {
            for (int i = 0; i < hours; i++)
            {
                OnWorkPerformed(i, type);
            }
        }

        private void OnWorkPerformed(int i, WorkType type)
        {
            if (_workPerformed != null)
            {
                _workPerformed(i, type);
            }
        }
    }
}
