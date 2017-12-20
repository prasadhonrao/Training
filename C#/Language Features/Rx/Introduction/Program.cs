using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Threading;

namespace Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            var query = from n in Enumerable.Range(1, 5) select n;

            #region Without Rx

            //foreach (var item in query)
            //{
            //    Console.WriteLine(item);
            //}

            //IAmDone(); // inform external function about completion of processing

            #endregion

            #region With Rx

            // Implementation using Observable
            //Console.WriteLine("UI Thread Id : " + Thread.CurrentThread.ManagedThreadId);
            //var observableQuery2 = query.ToObservable();
            //observableQuery2.Subscribe(DisplayNumber, IAmDone); // first function will run for each result in the observable query, second function will run at the end

            #endregion

            #region With Rx and Threading 

            //Console.WriteLine("Threading Example");
            //Console.WriteLine("UI Thread Id : " + Thread.CurrentThread.ManagedThreadId);
            //var observableQuery3 = query.ToObservable(NewThreadScheduler.Default); // Produces value on a diff thread than UI thread
            //observableQuery3.Subscribe(DisplayNumber, IAmDone);

            #endregion

            #region With Rx and Observer Pattern

            Console.WriteLine("With Observer Pattern");
            Console.WriteLine("UI Thread Id : " + Thread.CurrentThread.ManagedThreadId);
            var observableQuery4 = query.ToObservable(NewThreadScheduler.Default);

            var observer = Observer.Create<int>(DisplayNumber); // observer creation
            observableQuery4.Subscribe(observer); // observer subscribing to observarble query aka subject

            #endregion

            #region With RX - Completion function

            Console.WriteLine("With RX - Completion function");
            var newQuery = from n in Enumerable.Range(1, 25) select n.ToString();
            var newObservableQuery = newQuery.ToObservable();

            newObservableQuery.Subscribe(n =>
            {
                Console.WriteLine(string.Format("{0}", SlowString(n)));
            }, IAmDone );

            #endregion


            #region Custom Observer

            Console.WriteLine("Custom Observer");

            var numbers = new List<int> { 1, 2, 3 }.ToObservable();
            var myObserver = new MyObserver();
            numbers.Subscribe(myObserver);

            #endregion

            Console.ReadLine();
        }

        private static string SlowString(string str)
        {
            Thread.Sleep(250);
            return str;
        }

        static void DisplayNumber(int number)
        {
            Console.WriteLine($"{number} on thread {Thread.CurrentThread.ManagedThreadId}");
        }
        static void IAmDone()
        {
            Console.WriteLine("I am done!");
            Console.WriteLine();
        }

        class MyObserver : IObserver<int>
        {
            public void OnCompleted()
            {
                Console.WriteLine("I am done!");
            }

            public void OnError(Exception error)
            {
                throw new NotImplementedException("Not implemented");
            }

            public void OnNext(int value)
            {
                Console.WriteLine(value);
            }
        }
    }
}
