using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
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


    
        public class Student
        {
            public int Id { get; set; }
            public string name { get; set; }
            public string description { get; set; }


        }

        public Student makeObj()
        {
            Student stu = new Student();
            stu.description = "Ddas";
            stu.name = default(string);
            stu.Id = 22;

            return stu;
        }


        public void Sei()
        {
            Console.WriteLine(Serialize(makeObj()));
        }

        public IEnumerable<string> AllPrefixes(int prefixLength, IEnumerable<string> words)
        {
            var result = (from item in words.Cast<string>()
                          where item.Length >= prefixLength
                          select new { val = item.Substring(0, 3) }).Distinct();

            
            return null;
        }

        public   List<string> TransformDateFormat(List<string> dates)
        {
            List<string> strList = new List<string>();
            foreach ( var item in dates)
            {

               if (retDt(item,out DateTime newDateTime))
                {
                    Console.WriteLine(newDateTime.ToString("yyyyMMdd"));
                    strList.Add(newDateTime.ToString("yyyyMMdd"));
                }
            }
            return strList;
        }

        public string solution(string inputString)
        {
            string returnValue = string.Empty;
            Dictionary<string, string> dcData = new Dictionary<string, string>();
            foreach (char c in inputString)
            {
                if (dcData.ContainsKey(c.ToString()))
                {
                    returnValue = c.ToString();
                }
                else
                {
                    dcData.Add(c.ToString(), c.ToString());
                }               
            }
            return returnValue;
        }

        public void testHashTable()
        {
            Hashtable hstbl = new Hashtable();
            hstbl.Add(1, "dude");
            hstbl.Add("mama", "mia");

            foreach( DictionaryEntry item in hstbl)
            {
                Console.WriteLine($"Key {item.Key} value {item.Value}");
            }
        }

        public bool isPangram(string inptString)
        {
            bool retValue = true;
             
            for (int i = 65; i < 91; i++  )
            {
                if (!inptString.ToLower().Contains(((char)i).ToString().ToLower()))
                {
                    retValue = false;
                }
            }
             
            return retValue;
        }

        public void GeneralException(string inputSring)
        {
            Console.WriteLine(inputSring);
            throw new Exception(nameof(GeneralException));

        }


        private bool retDt(string item, out DateTime newDateTime)
        {
            bool isValid = false;
            newDateTime = DateTime.MinValue;

            if (DateTime.TryParseExact(item, "dd'/'MM'/'yyyy",
                         CultureInfo.InvariantCulture,
                         DateTimeStyles.None,
                         out DateTime retValue)) {
                newDateTime = retValue;
                return true;
            }

            if (DateTime.TryParseExact(item, "yyyy'/'MM'/'dd",
                         CultureInfo.InvariantCulture,
                         DateTimeStyles.None,
                         out DateTime retValue1))
            {
                newDateTime = retValue1;
                return true;
            }

            if (DateTime.TryParseExact(item, "MM'-'dd'-'yyyy",
                      CultureInfo.InvariantCulture,
                      DateTimeStyles.None,
                      out DateTime retValue3))
            {
                newDateTime = retValue3;
                return true;
            }

            return isValid;
        }

        private string Serialize(object ob)
        {
            return JsonConvert.SerializeObject(ob, new JsonSerializerSettings { DefaultValueHandling = DefaultValueHandling.Ignore });
        }
    }

}
