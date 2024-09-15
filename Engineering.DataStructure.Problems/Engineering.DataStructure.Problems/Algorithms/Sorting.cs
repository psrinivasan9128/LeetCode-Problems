using System;

public class SortingProblems
{
    public SortingProblems()
    {

    }

    public void SelectionSort()
    {
        int[] inputArr = new int[] { 64, 25, 12, 22, 11 };
        int minNum = 0;       
        int minPt = 0;
        int startVal;

        if (inputArr.Length != 0)
        { 
            for (int i =0; i < inputArr.Length; i++)
            {
                minNum = startVal = inputArr[i];
                for (int j = i + 1; j < inputArr.Length; j++)
                {
                    if (minNum > inputArr[j])
                    {
                        minNum = inputArr[j];
                        minPt = j;
                    }
                }
                if (i != inputArr.Length -1)
                {
                    inputArr[i] = minNum;
                    inputArr[minPt] = startVal;
                }
            }

        }
        Console.WriteLine("done");
    }


    public void BubbleSort()
    {

    }
}