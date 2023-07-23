using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    public class Frequency
    {
        public void CountFrequency()
        {
            Console.WriteLine("Enter the limit of array:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            var dict = new Dictionary<int, int>();
            foreach (int value in array)
            {
                if (dict.ContainsKey(value))
                {
                    dict[value]++;
                }
                else
                {
                    dict[value] = 1;
                }
            }
            Console.WriteLine("Frequency of each element:");
            foreach (var data in dict)
            {
                Console.WriteLine(data.Key + " appears " + data.Value + " times.");
            }
        }
    }
}
}
