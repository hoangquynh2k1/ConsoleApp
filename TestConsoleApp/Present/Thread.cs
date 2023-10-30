using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MyConsoleApp
{
    public class ThreadTest
    {
        public ThreadTest() { }

        private static void SingleThread()
        {
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(TimeSpan.FromSeconds(1));
                Console.WriteLine(i);
            }
        }

        private static void DemoThread(string threadIndex)
        {
            for (int i = 1; i <= 5; i++)
            {
                Thread.Sleep(TimeSpan.FromSeconds(1));
                Console.WriteLine(threadIndex + " - " + i);
            }
        }

        private static void ThreeThreads()
        {
            Thread t = new Thread(() => {
                DemoThread("Thread 1");
            });
            t.Start();

            Thread t2 = new Thread(() => {
                DemoThread("Thread 2");
            });
            t2.Start();

            Thread t3 = new Thread(() => {
                DemoThread("Thread 3");
            });
            t3.Start();
        }

        public static void Run()
        {
            ThreeThreads();
            Console.ReadKey();
        }
    }
}
