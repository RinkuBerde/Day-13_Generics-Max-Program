using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_13_Generics_Max_Program
{
    internal class MaximumFloats
    {
        public static float MaxFloatNumber(float firstValue, float secondValue, float thirdValue)
        {
            //Condition to Compare the firstValue to secondValue and thirdValue
            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0 || firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) > 0 || firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) >= 0)
            {
                return firstValue;
            }
            //Condition to Compare the secondValue to firstValue and thirdValue
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0 || secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) > 0 || secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) >= 0)
            {
                return secondValue;
            }
            //Condition to Compare the thirdValue to secondValue and firstValue
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0 || thirdValue.CompareTo(firstValue) >= 0 && thirdValue.CompareTo(secondValue) > 0 || thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) >= 0)
            {
                return thirdValue;
            }
            //return value if all the numbers are equal
            return firstValue;
        }
    }
}

