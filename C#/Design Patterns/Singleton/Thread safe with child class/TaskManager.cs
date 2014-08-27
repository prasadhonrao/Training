using System;

namespace Singleton.ThreadSafe
{
    public sealed class TaskManager
    {
        private TaskManager()
        {
            Console.WriteLine("TaskManager instance created");
        }

        public static TaskManager Instace
        {
            get
            {
                return NestedTaskManager.instance;
            }
        }

        public void DoWork()
        {
            Console.WriteLine("Done");
        }

        private class NestedTaskManager
        {
            static NestedTaskManager()
            {
                Console.WriteLine("Inside nested task manager");
            }

            internal static readonly TaskManager instance = new TaskManager();
        }
    }
}
