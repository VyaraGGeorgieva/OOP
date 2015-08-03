using System;


namespace SquareRoot.cs
{
    class SquareRoot
    {
        static void Main()
        {
            try
            {
                string str = Console.ReadLine();
                if (string.IsNullOrEmpty(str))
                {
                    throw new ArgumentNullException("The argument can't be null"); //information for the developer
                }

                int num = int.Parse(str);

                if (num<0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                double sqrt = Math.Sqrt(num);
                Console.WriteLine(sqrt);
            }
            catch (ArgumentNullException ex)
            {

                Console.Error.WriteLine("Enter a number!\n" + ex.Message); //information for the user
            }
            catch(FormatException fe)
            {
                Console.Error.WriteLine("Invalid format!\n" + fe);
            }
            catch (ArgumentOutOfRangeException or)
            {
                Console.Error.WriteLine("The number must be positive!\n" + or);
            }
            catch (OverflowException oe)
            {
                Console.Error.WriteLine("The input must be within the boundaries of Int32!\n" + oe);
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
}
