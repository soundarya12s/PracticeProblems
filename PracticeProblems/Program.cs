using System;
namespace PracticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag= true;
            Console.WriteLine("Practice Problems:");
            Console.WriteLine("Choose your option:\n 1.Number of Duplicates\n 2.Unique elements\n 3.Frequency\n 4.MinMaxElements\n 5.Print Pattern\n 6.Print Pattern-2\n 7.Reverseord\n 8.Sum Of Digits\n9.Convert to Capital\n`0.Exit");
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
                        Pattern pattern = new Pattern();
                        pattern.PrintGivenPattern();
                        break;
                    case 6:
                        Pattern1 pattern1 = new Pattern1();
                        pattern1.PrintGivenPattern2();
                        break;
                    case 7:
                        ReverseWord reverse = new ReverseWord();
                        reverse.PrintReverseEachWord();
                        break;
                    case 8:
                        SumOfDigits sumOfDigits = new SumOfDigits();    
                        sumOfDigits.FindSumOfDigits();
                        break;
                    case 9:
                        ToCapital toCapital = new ToCapital();
                        toCapital.ConvertLetterAsCapital();
                        break;
                    case 10:
                        flag = false;
                        break;

                    default:
                        break;
                }
            }
           
        }
    }
}