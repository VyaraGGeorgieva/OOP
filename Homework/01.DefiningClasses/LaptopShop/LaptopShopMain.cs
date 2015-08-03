using System;

namespace LaptopShop
{
    class LaptopShopMain
    {
        static void Main()
        {
            Laptop myLaptop = new Laptop("Lenovo Pro", "Lenovo", "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)",
                     8, "Intel HD Graphics 4400", "128GB SSD", "13.3\" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display",
                     "Li-Ion, 4-cells, 2550 mAh", 4.5, 2259);
            Laptop otherLaptop = new Laptop("Lenovo Yoga", 21.123);
            Laptop yetAnOther = new Laptop("ACER Aspire", "Acer", "Good", 123.1);
            Console.WriteLine(myLaptop);
            Console.WriteLine();
            Console.WriteLine(otherLaptop);
            Console.WriteLine();
            Console.WriteLine(yetAnOther);
            Console.WriteLine();
        }
    }
}
