using System;
using System.Threading;
using System.Threading.Tasks;
namespace LearningThreads
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread mythread = new Thread(new ThreadStart(Work));

            mythread.Start();

            Console.ReadLine();
        }

        static void Work()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Work Complete");
        }
    }
}
