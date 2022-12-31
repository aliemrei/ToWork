using System;
namespace Threading.Models
{
	public class ParallelismVSConcurrecy
	{
        int delayTime = 20000;

        void SetTimer()
        {
            for (int i = delayTime / 1000; i > 0 ; i--)
            {
                Console.WriteLine($"Remain second to complete task : {i}, Thread id {Thread.CurrentThread.ManagedThreadId}" );

                Thread.Sleep(1000);
            }
        }

        public static void Run()
        {
            ParallelismVSConcurrecy parallelism1 = new ParallelismVSConcurrecy();

            Task.Factory.StartNew(parallelism1.SetTimer); //Parallelism

            parallelism1.Exec1(); //Concurrecy

            parallelism1.Exec2(); //Concurrecy
        }

		public async void Exec1()
		{
            Console.WriteLine("Exec 1 has started " + Thread.CurrentThread.ManagedThreadId);

            await Task.Delay(delayTime);

			Console.WriteLine("Exec 1 has completed " + Thread.CurrentThread.ManagedThreadId);

        }

        public async void Exec2()
        {
            Console.WriteLine("Exec 2 has started " + Thread.CurrentThread.ManagedThreadId);

            await Task.Delay(delayTime);

            Console.WriteLine("Exec 2 has completed " + Thread.CurrentThread.ManagedThreadId);

        }

    }
}

