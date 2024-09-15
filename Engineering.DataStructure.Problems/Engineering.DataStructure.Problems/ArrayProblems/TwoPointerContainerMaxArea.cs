using System;
using System.Collections.Generic;
using System.Text;

namespace Engineering.DataStructure.Problems.ArrayProblems
{
    public static class TwoPointerContainerMaxArea
    {
        /// <summary>
        /// These are 2 pointer problems where we keep 1 pointer to the left and 1 to the right and move them close to each other. 
        /// It is type of sliding window problem but here the window is shrinking from both sides
        /// </summary>
        /// <param name="inputs"></param>
        /// <returns></returns>
        public static int FindMaxAreaOfContaier(int[] inputs)
        {
            int length = inputs.Length - 1;
            int left = 0;
            int right = length;
            int area = 0;
            int tempArea = 0;
            int height, width;

            while (left < right)
            {
                if (inputs[left] < inputs[right])
                {                   
                    height = inputs[left];
                    width = length;
                    left++;
                }
                else
                {
                    height = inputs[right];
                    width = length;
                    right--;
                }

                if (area == 0)
                {
                    area = height * width;
                }
                else
                {
                    tempArea = height * width;
                    if (tempArea > area) area = tempArea;
                }
                length--;
            }

            return area;
        }
    }
}
