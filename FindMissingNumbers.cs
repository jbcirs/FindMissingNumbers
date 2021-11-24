using System;
using System.Collections.Generic;
using System.Linq;

namespace FindMissingNumbers
{
    public class FindMissingNumbers
    {
        public static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 3, 4, 7, 20, 55, 89 };
            var outputList = FindMissingNubmers(numbers);
            
            outputList.ForEach(Console.WriteLine);
        }

        private static List<int> FindMissingNubmers(List<int> input, int start = 0, int end = 100)
        {
            var found = false;
            var output = new List<int>();

            for (int i = start; i <= end; i++)
            {
                found = input.Where(t => t == i).Count() > 0 ? true : false;

                if (!found)
                {
                    output.Add(i);
                }
            }

            return output;
        }
    }
}

