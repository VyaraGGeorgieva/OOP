using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsHandlingExc
{
    class PersonCore
    {
        static void Main(string[] args)
        {
            Person valid = new Person("Ivan", "Petrov", 20);
            try
            {
                Person notFirstName = new Person(string.Empty, "Ivanov", 100);
            }
            catch (ArgumentNullException ex)
            {

                Console.WriteLine("Exception thrown: {0}", ex.Message);
            }

            try
            {
                Person noLastName = new Person("Vyara", null, 89);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Exception thrown: {0}", ex.Message);
            }

            try
            {
                Person negativeAge = new Person("Peter", "Petrov", -16);
                Person tooOld = new Person("Marin", "Marinov", 122);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Exception thrown: {0}", ex.Message);
            }
            
            
        }
    }
}
