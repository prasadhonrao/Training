using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhyDelegates
{

    /// <summary>
    /// delegetes is representative to communication between two parties.
    ///Example: Create one method which returns current value of counter.
    ///Purpose of delegates is callback.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.LongRunningMethod(Callback);

        }
        //This method will maintain the current counter value present in LongRunningMethod.
        public static void Callback(int i)
        {
            Console.WriteLine(i);
        }

    }

    class MyClass
    {
        public delegate void CallBack(int i);
        public void LongRunningMethod(CallBack obj)
        {
            for (int i = 0; i < 10000; i++)
            {
                //Some long running logic here
                obj(i);
            }
        }
    }
}
