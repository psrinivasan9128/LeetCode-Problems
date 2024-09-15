using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engineering.DataStructure.Problems.General_Debug
{
    public class SlidingWindowProblems
    {
        public void BruteForceSlidingWindow()
        {
            int k = 4;
            int[] arrInput = new int[] { 1, 4, 2, 10, 23, 3, 1, 0, 20 };
            int max = 0;
            int innerSum = 0;

            for (int outer = 0; outer < arrInput.Length - k; outer++)
            {
                if (innerSum > max)
                {
                    max = innerSum;
                }
                innerSum = 0;
                for (int inner = outer; inner < outer + 4; inner++)
                {
                    innerSum += arrInput[inner];
                }
            }

            Console.WriteLine($"Max value {max}");
        }

        public void CalculateUsingSlidingWindow()
        {
            int k = 4;
            int[] arrInput = new int[] { 1, 4, 2, 10, 23, 3, 1, 0, 20 };
            int max = 0;
            int innerSum = 0;
            int startIndex = 0;
            for (int counter = 0; counter < k; counter++)
            {
                max += arrInput[counter];
            }

            for (int outer = k; outer < arrInput.Length - k; outer++)
            {
                innerSum = max + arrInput[outer] - arrInput[startIndex];
                startIndex++;
                if (innerSum > max)
                {
                    max = innerSum;
                    innerSum = 0;
                }
            }

            Console.WriteLine($"Max Sliding window value {max}");
        }

        public List<int> prefixCount(int N, int Q, string[] li, string[] query)
        {
            // code here
            List<int> lstResults = new List<int>();
            foreach (var input in query)
            {
                var count = li.AsEnumerable().Select(x => x.StartsWith(input)).Where(x => x == true).Count();
                lstResults.Add(count);

            }

            return lstResults;
        }

        public int CountGoodSubstrings(string s)
        {
            int results = 0;
            StringBuilder sb = new StringBuilder();

            if (s.Length < 3) return 0;
            if (s.Length == 3) return ((s.Distinct().Count() == 3 ? 1 : 0));
            for (int i = 0; i < 3; i++)
            {
                sb.Append(s[i]);
            }
            

            if (sb.ToString().Distinct().Count() == 3)
            {
                results = 1;
            }

            for (int i = 3; i < s.Length; i++)
            {

                sb.Append(s[i]);
                sb.Remove(0,1);

                results = results + (sb.ToString().Distinct().Count() == 3 ? 1: 0) ;
            }

            return results;
        }
    }
}
