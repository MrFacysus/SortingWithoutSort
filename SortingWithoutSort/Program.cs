using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingWithoutSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Inputs = Console.ReadLine();
            List<int> UnSorted = new List<int>();

            for (int i = 0; i < Inputs.Split(' ').Count(); i++)
            {
                UnSorted.Add(int.Parse(Inputs.Split(' ')[i]));
            }

            //Actual Sorting part of code
            for (int i = 0; i < UnSorted.Count; i++)
            {
                for (int j = i + 1; j < UnSorted.Count; j++)
                {
                    if (UnSorted[i] > UnSorted[j])
                    {
                        int temp1 = UnSorted[i];
                        int temp2 = UnSorted[j];

                        UnSorted[i] = temp2;
                        UnSorted[j] = temp1;
                    }
                }
            }
            // End of sorting

            Console.WriteLine(String.Join(" ", UnSorted));
        }
    }
}
