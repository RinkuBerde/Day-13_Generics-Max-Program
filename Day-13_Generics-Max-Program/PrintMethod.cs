using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_13_Generics_Max_Program
{
    internal class PrintMethod<T> where T : IComparable
    {
        public T[] value;

        public PrintMethod(T[] value)
        {
            this.value = value;
        }

        public T[] SortValue(T[] value)
        {
            //The Array.Sort method takes array as an input and sorts the array in ascending order
            Array.Sort(value);
            return value;
        }

        public T GetMaximum(T[] value)
        {
            var sortedValues = SortValue(this.value);
            return sortedValues[sortedValues.Length - 1];
        }

        public void printMax()
        {
            var maximumValue = GetMaximum(this.value);
            Console.WriteLine("Maximum value is: " + maximumValue);
        }
    }
}
