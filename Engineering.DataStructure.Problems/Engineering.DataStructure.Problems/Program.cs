using Engineering.DataStructure.Problems.ArrayProblems;
using Engineering.DataStructure.Problems.General_Debug;
using Engineering.DataStructure.Problems.LinkedListProblems;
using System;
using System.Collections.Generic;

namespace Engineering.DataStructure.Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] data = { 2, 7, 11, 15 };
            
            var response = TwoSumTarget.TwoSum(data, 9);

            data = new int[] { 3, 2, 4 };
            response = TwoSumTarget.TwoSum(data, 6);

            data = new int[] { 2, 5, 5, 11 };
            response = TwoSumTarget.TwoSum(data, 10);

            response = TwoSumTarget.TwoSumUsingDictionary(data, 10);

            var area = TwoPointerContainerMaxArea.FindMaxAreaOfContaier(new int[] { 1, 8, 6, 2, 5, 6, 8, 3, 7 });
        }

        static void OtherCode ()
        {
            //LinkedListAlgoProblems linkedListAlgoProblems = new LinkedListAlgoProblems();
            //linkedListAlgoProblems.PopulateSampleList();
            //linkedListAlgoProblems.traverseLinkedList();
            //Console.WriteLine("removed the duplicates");
            //linkedListAlgoProblems.RemoveDuplicate();
            //linkedListAlgoProblems.FindKthElementTotheLast(2);
            //linkedListAlgoProblems.DisplaySum();
            //linkedListAlgoProblems.checkIfPalindrome();

            ArrayAlgoProblems arrayAlgoProblems = new ArrayAlgoProblems();
            //arrayAlgoProblems.FindMissingNumber();
            //arrayAlgoProblems.duplicates();
            arrayAlgoProblems.LeadersInArray();

            SortingProblems srt = new SortingProblems();
            srt.SelectionSort();

            GeneralDebug tesb = new GeneralDebug();
            ////tesb.TestingStringBuilder();
            tesb.Sei();
            tesb.TransformDateFormat(new List<string> { "2010/02/20", "19/12/2016", "11-18-2012", "20130720" });
            tesb.solution("codility");
            tesb.testHashTable();
            tesb.isPangram("The quick brown fox jumps over a lazy dog");

            try
            {
                tesb.GeneralException("dude");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            CropRatio cropRatio = new CropRatio();

            cropRatio.Add("Wheat", 4);
            cropRatio.Add("Wheat", 5);
            cropRatio.Add("Rice", 1);

            Console.WriteLine("Ratio of wheat: {0}", cropRatio.Proportion("Wheat"));

            SlidingWindowProblems slidingWindow = new SlidingWindowProblems();
            slidingWindow.BruteForceSlidingWindow();

            slidingWindow.CalculateUsingSlidingWindow();
            slidingWindow.prefixCount(5, 5, new string[] {"abracadabra", "geeksforgeeks",
      "abracadabra", "geeks", "geeksthrill"}, new string[]  {"abr", "geeks", "geeksforgeeks",
         "ge", "gar"});

            slidingWindow.CountGoodSubstrings("xyzzaz");
            //            ConfigParser c = new ConfigParser();

            //            c.Parse(@"UserName:admin;
            //Password: ""super % ^&*333password;
            //        DNSName: SomeName;

            //        TimeToLive: 4;
            //        ClusterSize: 2;
            //        PortNumber: 2222;

            //        IsEnabled: true;
            //        EnsureTransaction: false;
            //        PersistentStorage: false; ");

            ParallelProg pp = new ParallelProg();
            pp.Main();
        }
    }
}
