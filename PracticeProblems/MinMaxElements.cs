using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    public class MinMaxElements
    {
        public void FindMaxMinElement()
        {
            Console.WriteLine("Enter the limit of array:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max = array[0];
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
                if (array[i] < min)
                    min = array[i];
            }
            Console.WriteLine("Maximum Element: " + max);
            Console.WriteLine("Minimum Element: " + min);
        }
    }
}
