using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterview
{
    //This program tells count of subset of numbers in array that are in ascending order
    class AscendingOrder
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int[] b = new int[a];

            for(int i=0; i<a; i++)
            {
                b[i] = Convert.ToInt32(Console.ReadLine());
            }

            int count =0, temp = 0, largeSubset = 0;
            for (int i = 0; i < a; i++)
            {
                if (temp < b[i])
                {
                    count++;
                }
                else
                {
                    if (largeSubset < count)
                        largeSubset = count;
                    count = 0;
                }
                temp = b[i];
            }
            
            largeSubset++;
            Console.WriteLine("Ascending numbers {0}", largeSubset);

            Console.ReadLine();
        }
    }
}
