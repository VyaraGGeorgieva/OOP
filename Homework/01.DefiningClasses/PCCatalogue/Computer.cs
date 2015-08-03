using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCCatalogue
{
    class Computer
    {
        //fields
        private string name;
        private decimal price = 0;
        private List<Component> components;

        //properties
        public string Name 
        {
            get {return this.name;}
            set
            {
                if (value.Length>4)
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("Incorrect data entered, must be at least 4 symbols!");
                }
            }
        }

        public decimal Price 
        {
            get { return this.price; }
            private set
            {
                decimal totalPrice = this.components.Sum(component => component.Price);
                this.price = totalPrice;
            } 
        }

        public List<Component> Components 
        {
            get { return this.components; }
            set { this.components = value; }
        }

        //constructors
        public Computer(string name, List<Component> components)
        {
            this.Name = name;
            this.Components = components;
            this.Price = components.Sum(component => component.Price);
        }

        public Computer(string name) : this(name, new List<Component>()) { }
        public void GetComponents()
        {
            Console.Write("Components: ");
            if (components.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                Console.WriteLine();
                foreach (var component in this.Components)
                {
                    Console.WriteLine("{0} witch costs: {1:f} BGN", component.Name, component.Price);
                }
            }
        }

        public void GetPrice()
        {
            Console.WriteLine("The yotal price is: {0:f}", this.price);
        }

        public void GetName()
        {
            Console.WriteLine("The Computer's name is: {0}", this.name);
        }

        public override string ToString()
        {
            return string.Format("Computer name: {0}\nprice: {1}", this.name, this.price);
        }
    }
}
