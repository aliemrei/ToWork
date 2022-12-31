using System;
namespace Threading.Models
{
	public class ThreadSafe
	{
		int x = 0;
		int y = 0;
		Random rnd = new Random();

	    public static void RunNonSafe()
		{
			var test = new ThreadSafe();

            Thread t1 = new Thread(test.DivideNonSafe);

			t1.Start();

			test.DivideNonSafe();
		}

        public static void RunWithLock()
        {
            var test = new ThreadSafe();

            Thread t1 = new Thread(test.DivideWithLock);

            t1.Start();

            test.DivideWithLock();
        }

        public static void RunWithMonitor()
        {
            var test = new ThreadSafe();

            Thread t1 = new Thread(test.DivideWithMonitor);

            t1.Start();

            test.DivideWithMonitor();
        }

        void DivideNonSafe()
		{
			for (int i = 0; i < 1000000; i++)
			{
				x = rnd.Next(1, 2);

				y = rnd.Next(1, 2);

				var r = x / y;

				x = 0;

				y = 0;
			}
		}

		void DivideWithLock()
		{
            for (int i = 0; i < 1000000; i++)
            {
				lock (this)
				{
					x = rnd.Next(1, 2);

					y = rnd.Next(1, 2);

					var r = x / y;

					x = 0;

					y = 0;
				}
            }
        }

        void DivideWithMonitor()
        {
            for (int i = 0; i < 1000000; i++)
            {
				Monitor.Enter(this);
                 
                x = rnd.Next(1, 2);

                y = rnd.Next(1, 2);

                var r = x / y;

                x = 0;

                y = 0;

				Monitor.Exit(this);
            }
        }
    }
}

