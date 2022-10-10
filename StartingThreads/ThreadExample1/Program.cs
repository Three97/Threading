using System;
using System.Threading;

namespace ThreadExample1
{
    class MainClass
    {
        private const int REPETITIONS = 1000;

        public static void DoWork()
        {
            for (int i = 0; i < REPETITIONS; i++)
            {
                Console.Write("B");
            }
        }

        public static void Main(string[] args)
        {
            // create thread using thread and thread start constructors
            // Thread t1 = new Thread(new ThreadStart(DoWork));
            // t1.Start();
            
            // can also do this using just a Thread object
            // var t2 = new Thread(DoWork);
            // t2.Start();
            
            // can ALSO replace with lambda expression
            var t3 = new Thread(() => { DoWork(); });
            t3.Start();

            for (int i = 0; i < REPETITIONS; i++)
            {
                Console.Write("A");
            }
        }
    }
}