using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqBasics
{
    class Program{
        public static void Main1(string[] args)
        {
            Console.WriteLine("Existing .Net Features");
            List<int> numbers = new List<int>() {1,2,3,4,5,6};
            foreach(var number in numbers)
            {
                if(number< 3)
                Console.WriteLine(number);
            }
            Console.WriteLine("Using LINQ");
            List<int> numbersLinq = new List<int>() {1,2,3,4,5,6};
            IEnumerable<int> query = from n in numbersLinq where n < 3 select n;
            foreach(int number in query)
            Console.WriteLine(number);
        }
    }
}