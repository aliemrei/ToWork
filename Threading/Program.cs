// See https://aka.ms/new-console-template for more information


using Threading.Models;

#region Classic Multithread sample
//MultiThreading.Run();
#endregion

#region ThreadSafe Samples
//ThreadSafe.RunNonSafe();     //inproc

//ThreadSafe.RunWithLock();    //inproc

//ThreadSafe.RunWithMonitor(); //inproc
#endregion

#region Parallelism VS Concorrency sample
ParallelismVSConcurrency.Run();
#endregion

Console.WriteLine("Application started!");

Console.ReadLine();



