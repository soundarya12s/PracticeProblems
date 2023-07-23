using System;
namespace PracticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag= true;
            Console.WriteLine("Practice Problems:");
            Console.WriteLine("Choose your option:\n 1.Number of Duplicates\n 2.Unique elements\n 3.Frequency\n 4.MinMaxElements\n 5.Exit");
            while(flag)
            {
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        NumberOfDuplicates duplicates = new NumberOfDuplicates();
                        duplicates.NoOfDuplicates();
                        break;
                    case 2:
                        UniqueElements unique = new UniqueElements();   
                        unique.PrintUniqueElements();
                        break;
                    case 3:
                        Frequency frequency = new Frequency();  
                        frequency.CountFrequency();
                        break;
                    case 4:
                        MinMaxElements minMaxElements = new MinMaxElements();   
                        minMaxElements.FindMaxMinElement();
                        break;
                    case 5:
                        flag = false;
                        break;

                    default:
                        break;
                }
            }
           
        }
    }
}