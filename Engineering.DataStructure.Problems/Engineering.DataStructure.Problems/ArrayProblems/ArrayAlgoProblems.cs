using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Engineering.DataStructure.Problems.ArrayProblems
{
    public class ArrayAlgoProblems
    {

        public ArrayAlgoProblems()
        {

        }

        public void SubArraySum()
        {
            int[] arrayNums = new int[] { 135, 101, 170, 125, 79, 159, 163, 65, 106, 146, 82, 28, 162, 92, 196, 143, 28, 37, 192, 5, 103, 154, 93, 183, 22, 117, 119, 96, 48, 127, 172, 139, 70, 113, 68, 100, 36, 95, 104, 12, 123, 134 };
            var result = SubarraySum(arrayNums, 42, 468);
        }

        
        //Function to find a continuous sub-array which adds up to a given number.
        public List<int> SubarraySum(int[] arr, int n, int s)
        {
            //code here
            List<int> lstResult = new List<int>();
            List<int> lstPosition = new List<int>();
            bool isCompleted = false;
            int counter = 0;
            int sum = 0;
            while (!isCompleted && counter <= arr.Length)
            {
               
                if (sum > s)
                {
                    sum = sum - lstResult[0];
                    lstResult.RemoveAt(0);
                    lstPosition.RemoveAt(0);

                }
                lstResult.Add(arr[counter]);
                lstPosition.Add(counter + 1);
                sum += arr[counter];


                if (sum == s)
                {
                    isCompleted = true;
                } 
             
                counter++;
            }
           
            if (sum !=s )
            {
                lstResult.Clear();
                lstResult.Add(-1);
            } else if (sum == s)
            {
                lstResult.Clear();
                lstResult.Add(lstPosition[0]);
                lstResult.Add(lstPosition[lstPosition.Count - 1]);
            }
            return lstResult;
        }

        public void FindMissingNumber()
        {
            int[] arrayNums = new int[] { 6, 1, 2, 8, 3, 4, 7, 10, 5 };
            
            Console.WriteLine(FindMisingNumber(arrayNums, arrayNums.Length));
        }

        private int FindMisingNumber(int[] inputArray, int lengthArry)
        {
            var item = inputArray.ToList();
            item.Sort();
            int counter = 0;
            var tempArr = item.ToArray();
            for (int i = 0; i < tempArr.Length -1; i++)
            {
                if (tempArr[i] != tempArr[i+1] -1)
                {
                    counter = tempArr[i] + 1;
                    break;
                }
            }
            return counter;
        }

        public void duplicates()
        {
            int[] data = new int[] { 2, 3, 1, 2, 3 };
            var result = duplicates(data, data.Length);
        }

        private int[] duplicates(int[] arr, int n)
        {
            //Your code here
            int[] dupArry = new int[arr.Length / 2 + 1];
            int index = 0;
            for (int i = 0; i < arr.Length - 1; i ++)
            {
                if (arr[i] == arr[i+1])
                {
                    dupArry[index] = arr[i];
                    index++;
                }
            }
            return dupArry;
        }

        

    }
}
