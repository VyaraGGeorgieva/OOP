using System;
using System.Text.RegularExpressions;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Utilities
{
    class Sale:ISale
    {
        private string productName;
        private DateTime date;
        private decimal price;

        public Sale(string productName, DateTime date, decimal price)
        {
            this.Price = price;
            this.Date = date;
            this.ProductName = productName;
        }
        public string ProductName { 
            get { return this.productName; }
            set
            {
                if (Regex.IsMatch(value, "[a-zA-Z]{2,100}"))
                {
                    this.productName = value;
                }
                else
                {
                    throw new ArgumentException("The product's name sholuld consist of at least 2 and not more than 40 symbols!");
                }
                
            } 
        }
        public DateTime Date 
        { 
            get { return this.date; } 
            set { this.date = value; } 
        }
        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value>0)
                {
                    this.price = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("value", "The price must be a positive number!");
                }
                
            } }
    }
}
