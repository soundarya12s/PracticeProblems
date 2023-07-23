using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    public class NumberOfDuplicates
    {
        public void NoOfDuplicates()
        {
            Console.WriteLine("Enter the size of array:");
            int size= Convert.ToInt32(Console.ReadLine());
            int[] array= new int[size];
            Console.WriteLine("Enter the array elements:");
            for(int i = 0; i < array.Length; i++)
            {
                array[i]= Convert.ToInt32(Console.ReadLine());  
            }

            var dict = new Dictionary<int, int>();

            foreach(var item in array)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                }
                else
                {
                    dict[item] = 1;
                }
            }
            int count = 0;
            foreach(var data in dict)
            {
                if (data.Value > 1)
                    count += data.Value;
            }
            Console.WriteLine("No. Of Duplicate elements:"+count);
        }
    }
}
