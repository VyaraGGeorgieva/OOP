using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    class Tests
    {
        static void Main()
        {
            Book regularBook = new Book("Under the Yawk", "Ivan Vazov", 10.50);
            Console.WriteLine(regularBook);
            Console.WriteLine();
            GoldenEditionBook goldenBook = new GoldenEditionBook("Tutun", "Dimityr Dimov", 22.50);
            Console.WriteLine(goldenBook);

        }
    }
}
