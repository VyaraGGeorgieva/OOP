using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterNumbers
{
    class ReadNumbers
    {
        //my method
        private static int EnteredNums(int min, int max)
        {
            int number = 0;
            
            bool validNumber = false;

            while (!validNumber)
            {
                try
                {
                    Console.WriteLine("Enter numbers in the range {0} - {1}", min, max);
                    number = int.Parse(Console.ReadLine());
                    validNumber = true;

                    if (number<min || number>max)
                    {
                        throw new ArgumentOutOfRangeException(string.Format("The number cannot be below {0} or above {1}",  min, max));
                    }
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine( " {0} Please, enter a number in the range {0} - {1}", ex.Message, min, max);
                    validNumber = false;
                }
            }
            Console.WriteLine("{0} is correct number!", number);
            return number;
        }

        //main method 
        static void Main ()
        {
            var chosenNumbers = new List<int>();
            int min = 1;
            const int max = 100;
            for (int i = 0; i <10; i++)
            {
                if (chosenNumbers.Count>=1)
                {
                    min = chosenNumbers.Max();
                }

                int number = EnteredNums(min, max);
                chosenNumbers.Add(number);
            }
            Console.WriteLine("Your numbers are: {0}");
            foreach (int number in chosenNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
