using System;
using System.Collections.Generic;
using System.Text;

namespace Engineering.DataStructure.Problems.LinkedListProblems
{
    public class LinkedListAlgoProblems
    {
        private LinkedList HeadNode { get; set; }

        public void RemoveDuplicate()
        {
            LinkedList currentNode = HeadNode;
            LinkedList nextNode = HeadNode.nextNode;

            if (currentNode.nextNode == null)
            {
                Console.WriteLine(currentNode.data);
            } else
            {
                Dictionary<int, int> hashData = new Dictionary<int, int>();
                while (currentNode != null)
                {
                    if (!hashData.ContainsKey(currentNode.data))
                    {
                        Console.WriteLine(currentNode.data);
                        hashData.Add(currentNode.data, currentNode.data);                        
                    }
                    currentNode = currentNode.nextNode;
                }
            }
        }

        public void DeleteNode(LinkedList node)
        {
            LinkedList firstNode = HeadNode;
            LinkedList PrevNode;

            if (firstNode.data == node.data)
            {
                HeadNode = node.nextNode;
                firstNode = null;
            }
            else
            {
                while (firstNode != null)
                {
                    PrevNode = firstNode;
                    if (firstNode.data == node.data)
                    {
                        PrevNode.nextNode = firstNode.nextNode;
                        firstNode = null;
                    }
                    firstNode = firstNode.nextNode;
                }
            }
        }

        public void FindKthElementTotheLast(int k)
        {
            // when list size is not known
            // find length of the list
            LinkedList node = HeadNode;
            int listlength = 0;
            while (node != null)
            {
                listlength++;
                node = node.nextNode;
            }

            int position = listlength -k ;
            node = HeadNode;
            listlength = 0;
            while (node != null)
            {
                listlength++;
                if (position == listlength)
                {
                    Console.WriteLine("K th value");
                    Console.WriteLine(node.data);
                }
                node = node.nextNode;
              
            }
        }

        public void traverseLinkedList()
        {
            LinkedList node = HeadNode;
            while (node != null)
            {
                Console.WriteLine(node.data);
                node = node.nextNode;
            }

        }

        public void PopulateSampleList()
        {
            LinkedList list = new LinkedList();
            

            var newNode = list.AddNode(1, list);
            HeadNode = newNode;
            newNode = newNode.AddNode(2, newNode);
            newNode = newNode.AddNode(3, newNode);
            newNode = newNode.AddNode(4, newNode);
            newNode = newNode.AddNode(5, newNode);
            newNode = newNode.AddNode(4, newNode);
            newNode = newNode.AddNode(3, newNode);
            newNode = newNode.AddNode(2, newNode);
            newNode = newNode.AddNode(1, newNode);

        }

        public void DisplaySum()
        {
            LinkedList first = new LinkedList();
            LinkedList headNode;
            var newNode = first.AddNode(7, null);
            headNode = newNode;
            newNode = newNode.AddNode(1, newNode);
            newNode = newNode.AddNode(6, newNode);
            var result = GetSumOfListWithWeights(headNode);
            Console.WriteLine(result);
        }

        private int GetSumOfListWithWeights(LinkedList linkedList)
        {
            int sumResult = 0;
            int runningMultiplier = 1;

            while (linkedList != null)
            {

                sumResult = sumResult + linkedList.data * runningMultiplier;
                runningMultiplier = runningMultiplier * 10;
                linkedList = linkedList.nextNode;

            }
            return sumResult;
        }

        public void checkIfPalindrome()
        {
            string originalString = string.Empty;
            string revereString = string.Empty;
            LinkedList list = HeadNode;

            while (list != null)
            {
                
                originalString += list.data;
                revereString = list.data + revereString;
                list = list.nextNode;
            }

            Console.WriteLine("-------------");
            Console.WriteLine("original string {0}", originalString);
            Console.WriteLine("reverse string {0}", revereString);

        }
    }
}
