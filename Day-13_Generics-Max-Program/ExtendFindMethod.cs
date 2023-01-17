using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_13_Generics_Max_Program
{
    internal class ExtendFindMethod<T> where T : IComparable
    {
        public T[] value;
        public ExtendFindMethod(T[] value)
        {
            this.value = value;
        }

        public T[] Sort(T[] value)
        {
            //The Array.Sort method takes array as an input and sorts the array in ascending order
            Array.Sort(value);
            return value;
        }
        public T MaxValue(T[] value)
        {
            var sortedValues = Sort(this.value);
            return sortedValues[sortedValues.Length - 1];
        }
    }
}
