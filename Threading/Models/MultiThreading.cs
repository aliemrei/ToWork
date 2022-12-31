using System;
namespace Threading.Models
{
	public static class MultiThreading
	{
        public static void Run()
        {
            Thread t1 = new Thread(() => CountDown());

            t1.Name = "Worker Thread 1";

            Thread t2 = new Thread(() => CountUp());

            t2.Name = "Worker Thread 2";


            t1.Start();

            t2.Start();

        }

        public static void CountDown()
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine($"Count down : {i} - {Thread.CurrentThread.Name}");

                Thread.Sleep(1000);
            }
        }

        public static void CountUp()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"Count up : {i} - {Thread.CurrentThread.Name}");

                Thread.Sleep(1000);
            }
        }
    }
}

