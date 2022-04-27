using System;
using System.Collections.Generic;
using System.Text;

namespace Engineering.DataStructure.Problems.LinkedListProblems
{
    public class LinkedList
    {
        public LinkedList nextNode;
        public int data;

        public LinkedList(int input = 0)
        {
            nextNode = null;
            data = input;
        }

        public LinkedList AddNode(int nodeData, LinkedList currentlist)
        {
            var node = new LinkedList(nodeData);
            if (currentlist == null)
            {
                currentlist = node;
            } else
            {
                currentlist.nextNode = node;
            }
           
            return node;
        }



    }
}
