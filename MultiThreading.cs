using System;

namespace BlockchainAssignment
{
	internal class Multithreading
	{
		public Multithreading()
		{
			private timestamp = DateTime.Now;
		}
    public void StartMultipleThread()
    {
        DateTime startTime = timestamp;
        Thread thread1 = new Thread(() =>
        {
            int total_seconds = 0;

            while (total_seconds < 5)
            {
                Thread.Sleep(1000);
                total_seconds++;
            }
            String rantime = "I ran for 5 seconds";

        });

        Thread thread2 = new Thread(() =>
        {
            int total_seconds = 0;
            while (total_seconds < 8)
            {
                Thread.Sleep(1000);
                total_seconds++;
            }
            String rantime = "I ran for 8 seconds";
        });

        Thread thread3 = new Thread(p =>
        {
            int total_seconds = 0;
            while (total_seconds < Convert.ToInt32(p))
            {
                Thread.Sleep(1000);
                total_seconds++;
            }
            int rantime = total_seconds;
        });
        thread1.Start();
        thread2.Start();
        thread3.Start(20);

        thread1.Join();
        thread2.Join();
        thread3.Join();

        //Output time thread needed to end

     }
    }
}
