using System;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                var stopWatch = new Stopwatch();
               // Console.WriteLine("StopWatch Started!");
                stopWatch.Start();
                string temp = "a";
                Console.WriteLine("StopWatch Started!");
                while (true)
                {
                    Console.WriteLine("Press 'z' to stop StopWatch. Press 'a' to start StopWatch. Press 'q' to quit StopWatch.");
                    temp = Console.ReadLine();
                    if (temp == "z")
                    {
                        stopWatch.Stop();
                        Console.WriteLine("Time Duration {0}", stopWatch.Duration);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input! Press 'z' to stop StopWatch. Press 'a' to start StopWatch. Press 'q' to quit StopWatch.");
                    }
                }
                
                    
                //Console.WriteLine("Start Time: {0}. Stop Time {1}. Duration {2}", stopWatch.startTime, stopWatch.stopTime, stopWatch.Duration);
                //Console.WriteLine("Time Duration {0}", stopWatch.Duration);


                //Console.WriteLine("\n\nEnter a key to start StopWatch again.");
                //temp = Console.ReadLine();
                //Console.WriteLine("StopWatch Started!");
                //stopWatch.Start();
                //stopWatch.Start();
                //Console.WriteLine("Press Enter key to stop StopWatch.");
                //temp = Console.ReadLine();
                //Console.WriteLine("StopWatch Stopped!");
                //stopWatch.Stop();
                ////Console.WriteLine("Start Time: {0}. Stop Time {1}. Duration {2}", stopWatch.startTime, stopWatch.stopTime, stopWatch.Duration);
                //Console.WriteLine("Time Duration {0}", stopWatch.Duration);
            }
            catch (Exception)
            {
                Console.WriteLine("Error: StopWatch already started.");
            }

        }
    }
}
