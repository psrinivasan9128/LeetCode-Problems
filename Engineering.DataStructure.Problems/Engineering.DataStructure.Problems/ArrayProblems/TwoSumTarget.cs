using Microsoft.Exchange.WebServices.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Engineering.DataStructure.Problems.ArrayProblems
{
    /// <summary>
    /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
    /// You can return the answer in any order.
    /// </summary>
    public static class TwoSumTarget
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];
            bool done = false;
            if (nums.Length < 2)
            {
                return null;
            }
            else if (nums.Length == 2)
            {
                result = (nums[0] + nums[1]) == target ? nums : null;
            }
            else if (nums.Length > 2)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[i] + nums[j] == target)
                        {
                            result[0] = i;
                            result[1] = j;
                            done = true;
                            break;
                        }
                    }
                    if (done) break;
                }
            }

            return result;
        }

        /// <summary>
        /// Logic is a.  Use a Dictionary. Which keys = value of the items in the array , Value of the dictionary = Index of the array
        /// Then, in the second iteration, we check if each element's complement (target−nums[i]) exists in the hash table. 
        /// If it does exist, we return current element's index and its complement's index. Beware that the complement must not be nums[i] itself!
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int[] TwoSumUsingDictionary(int[] nums, int target)
        {
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!keyValuePairs.ContainsKey(nums[i])) keyValuePairs.Add(nums[i], i);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                var complement = target - nums[i];
                if (keyValuePairs.ContainsKey(complement) && keyValuePairs[complement] != i)
                {
                    return new int[] { i, keyValuePairs[complement] };
                }
            }
            return null;
        }

        /*
         * It turns out we can do it in one-pass. While we are iterating and inserting elements into the hash table, we also look back to
         * check if current element's complement already exists in the hash table. If it exists, we have found a solution and return the indices immediately.
         */
        public static int[] TwoSumWithDict(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement], i };
                }
                map[nums[i]] = i;
            }
            // Return an empty array if no solution is found
            return new int[] { };
        }

    }
}
