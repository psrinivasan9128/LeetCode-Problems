using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;

namespace Engineering.DataStructure.Problems.General_Debug
{
    class ConfigParser
    {

        public dynamic Parse(string Configuration)
        {
            dynamic myobject = new ExpandoObject();

            IDictionary<string, object> myUnderlyingObject = myobject;
            var retArr = Configuration.Split(";");
            foreach (var data in retArr)
            {
                var confVal = data.Split(":");

                //if (confVal.Length != 2) throw throw new UnknownKeyException();

                bool result = confVal[1].ToString().Any(x => !char.IsLetter(x));
                int temp;

                //if (myUnderlyingObject.ContainsKey(confVal[0])) throw new DuplicatedKeyException();
                //if (string.IsNullOrEmpty(confVal[0])) throw new EmptyKeyException();
                //if (int.TryParse(confVal[1].ToString().Substring(0, 1), out temp) || result) throw InvalidKeyException();

                if (confVal[1].GetType() == typeof(bool))
                {
                    bool b;
                    bool.TryParse(confVal[1].ToString(), out b);
                    myUnderlyingObject.Add(confVal[0].ToString().Trim(), b); 
                } else if (confVal[1].GetType() == typeof(int))
                {
                    int i;
                    int.TryParse(confVal[1].ToString(), out i);
                    myUnderlyingObject.Add(confVal[0].ToString().Trim(), i);
                } else
                {
                    myUnderlyingObject.Add(confVal[0].ToString().Trim(), confVal[1].ToString().Trim());
                }
                
            }


            return myobject;
        }
    }
}
