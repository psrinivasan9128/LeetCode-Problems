using System;
using System.Collections.Generic;
using System.Text;

namespace Engineering.DataStructure.Problems
{
    public class GeneralDebug
    {
        public void TestingStringBuilder()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ff");
            sb.AppendLine("ff");
            sb.AppendLine("ff");
            sb.AppendLine("ff");
            Console.WriteLine(sb.ToString());
            //sb.Clear();
            sb.AppendLine("aa");
            sb.AppendLine("aa");
            Console.WriteLine(sb.ToString());

            Console.WriteLine("Hello, world!");
        }
    }
}
