using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class Book
    {
        private string title;
        private string author;
        private double price;

        public Book(string title, string author, double price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }
        public string Title
        {
            get 
            {
                return this.title;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value", "The title should be included, cannot be left empty");
                }
                else
                {
                    this.title = value;
                }
            }
        }
        public string Author 
        {
            get { return this.author; }
 
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value", "The author should be included, this cannot be left empty!");
                }
                else
                {
                    this.author = value;
                }
            }
        }
        public virtual double Price
        {
            get { return this.price; }
            private set
            {
                if (value<=0)
                {
                    throw new ArgumentOutOfRangeException("value", "The price cannot be a negative number!");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("-Type: {0}{1}", this.GetType().Name, Environment.NewLine);
            output.AppendFormat("-Title: {0}{1}", this.Title, Environment.NewLine);
            output.AppendFormat("-Author: {0}{1}", this.Author, Environment.NewLine);
            output.AppendFormat("-Price: {0}", this.Price.ToString("F")); //{0:2F}
            return output.ToString();
        }

    }
}
