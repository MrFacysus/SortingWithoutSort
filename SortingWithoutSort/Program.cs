using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingWithoutSort
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string Inputs = Console.ReadLine();
            List<int> UnSorted = new List<int>();

            for (int i = 0; i < Inputs.Split(' ').Count(); i++)
            {
                UnSorted.Add(int.Parse(Inputs.Split(' ')[i]));
            }

            CheckTimeOfSorting(UnSorted, SortWithTwoLoops, "Two Loops");
        }

        public static void CheckTimeOfSorting(List<int> UnSorted, Func<List<int>, List<int>> SortingFunc, string Out)
        {
            DateTime Start = DateTime.Now;
            SortingFunc(UnSorted);
            DateTime End = DateTime.Now;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{(End - Start).TotalMilliseconds}ms --- {Out}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static List<int> SortWithTwoLoops(List<int> UnSorted)
        {
            List<int> Result = UnSorted;
            for (int i = 0; i < Result.Count; i++)
            {
                for (int j = i + 1; j < Result.Count; j++)
                {
                    if (Result[i] > Result[j])
                    {
                        int temp1 = Result[i];
                        int temp2 = Result[j];

                        Result[i] = temp2;
                        Result[j] = temp1;
                    }
                }
            }
            return Result;
        }
    }
}