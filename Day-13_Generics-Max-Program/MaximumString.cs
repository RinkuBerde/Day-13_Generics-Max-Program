using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_13_Generics_Max_Program
{
    internal class MaximumString
    {
        public static string MaxStringValue(string string1, string string2, string string3)
        {
            //Condition to Compare the string1 to string2 and string3
            if (string1.CompareTo(string2) > 0 && string1.CompareTo(string3) > 0 || string1.CompareTo(string2) >= 0 && string1.CompareTo(string3) > 0 || string1.CompareTo(string2) > 0 && string1.CompareTo(string3) >= 0)
            {
                return string1;
            }
            //Condition to Compare the string2 to string1 and string3
            if (string2.CompareTo(string1) > 0 && string2.CompareTo(string3) > 0 || string2.CompareTo(string1) >= 0 && string2.CompareTo(string3) > 0 || string2.CompareTo(string1) > 0 && string2.CompareTo(string3) >= 0)
            {
                return string2;
            }
            //Condition to Compare the string3 to string2 and string1
            if (string3.CompareTo(string1) > 0 && string3.CompareTo(string2) > 0 || string3.CompareTo(string1) >= 0 && string3.CompareTo(string2) > 0 || string3.CompareTo(string1) > 0 && string3.CompareTo(string2) >= 0)
            {
                return string3;
            }
            //return value if all the strings are equal
            return string1;
        }
    }
}

