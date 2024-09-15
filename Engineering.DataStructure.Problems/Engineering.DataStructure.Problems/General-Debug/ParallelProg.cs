using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Engineering.DataStructure.Problems.General_Debug
{
    internal class ParallelProg
    {
        public void Main()
        {
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Parallel Foreach Loop Started");
            stopwatch.Start();
            List<int> integerList = Enumerable.Range(1, 10).ToList();

            var options = new ParallelOptions()
            {
                MaxDegreeOfParallelism = 3,
            };
            Parallel.ForEach(integerList,options, i =>
            {
                long total = DoSomeIndependentTimeconsumingTask();
                Console.WriteLine("{0} - {1}", i, total);
            });
            Console.WriteLine("Parallel Foreach Loop Ended");
            stopwatch.Stop();

            Console.WriteLine($"Time Taken by Parallel Foreach Loop in Miliseconds {stopwatch.ElapsedMilliseconds}");
            Console.ReadLine();
        }

        private long DoSomeIndependentTimeconsumingTask()
        {
            //Do Some Time Consuming Task here
            long total = 0;
            for (int i = 1; i < 100000000; i++)
            {
                total += i;
            }
            return total;
        }
    }
}


