//model, manufacturer, processor, RAM, graphics card, HDD, screen, battery, battery life in hours and price.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopShop
{
    class Laptop
    {
        //fields:
        private string model;
        private string manufacturer;
        private string processor;
        private int ram;
        private string graphicCard;
        private string hdd;
        private string screen;
        private Battery battery;
        private double price;

        //properties
        public string Model
        {
            get { return this.model; }
            set
            {
                this.model = Validate(value);
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                this.manufacturer = Validate(value);
            }
        }

        public string Processor
        {
            get { return this.processor; }
            set
            {
                this.processor = Validate(value);
            }
        }
        public int Ram
        {
            get { return this.ram; }
            set
            {
                this.ram = Validate(value);
            }
        }
        public string GraphicCard
        {
            get { return this.GraphicCard; }
            set
            {
                this.graphicCard = Validate(value);
            }
        }
        public string Hdd
        {
            get { return this.hdd; }
            set
            {
                this.hdd = Validate(value);
            }
        }
        public string Screen
        {
            get { return this.screen; }
            set
            {
                this.screen = Validate(value);
            }
        }
        public double Price
        {
            get { return this.price; }
            set
            {
                this.price = Validate(value);
            }
        }

        //constructors
        //full constructor - the whole info held
        public Laptop(string model, string manufacturer, string processor, int ram,
                string grapthicCard, string hdd, string screen, string battery, double batteryLife, double price)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.GraphicCard = graphicCard;
            this.Hdd = hdd;
            this.Screen = screen;
            this.battery = new Battery(battery, batteryLife);
            this.Price = price;
        }

        //inheritance- only the obligatory data taken
        public Laptop(string model, double price)
            : this(model, "no data", "no data", 0, "no data", "no data",
                "no data", "no data", 0, price)
        {

        }

        public Laptop(string model, string manufacturer, string battery, double price)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.battery = new Battery(battery);
            this.Price = price;
        }

        //ToString() - identical to CW, returns string

        public override string ToString()
        {
            return string.Format("model: {0}\nmanufacturer: {1}\nprocessor: {2}\nRAM: {3} GB\n" +
                "graphics card: {4}\nHDD: {5}\nscreen: {6}\nbattery: {7}\nprice: {8:f} lv.",
                this.model, this.Manufacturer, this.processor, this.ram, this.graphicCard,
                this.hdd, this.screen, this.battery, this.price);
        }
        //methods for validation

        private string Validate(string data)
        {
            if (data.Length > 0)
            {
                return data;
            }
            else
            {
                throw new ArgumentException("The field cannot be empty!");
            }
        }

        private int Validate(int data)
        {
            if (data >= 0)
            {
                return data;
            }
            else
            {
                throw new ArgumentException("The number needs to be bigger than 0!");
            }
        }

        private double Validate(double data)
        {
            if (data >= 0)
            {
                return data;
            }
            else
            {
                throw new ArgumentException("The number needs to be bigger than 0!");
            }
        }




    }
}
