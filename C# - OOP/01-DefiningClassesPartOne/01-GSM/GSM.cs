using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_GSM
{
    class GSM
    {
        //<fields>
        private string model = null;
        private string manufacturer = null;
        private double? price = null;
        private string owner = null;
        private Battery battery = null;
        private Display display = null;
        static private readonly GSM iPhone4S = new GSM("iPhone4S", "Apple", 1500, "Krischo Petrov", new Battery("iphonemodel", 10, 5),
            new Display(10, 60000000));
        private List<Call> callHistory;
        //</fields>


        //<properties>
        public string Model
        {
            get { return this.model; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Model cannot be empty!");
                }

                if (value.Length < 3 || value.Length > 50)
                {
                    throw new ArgumentException("Model cannot be less than 3 and more than 50 letters long!");
                }

                this.model = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Manufacturer cannot be empty!");
                }

                if (value.Length < 3 || value.Length > 50)
                {
                    throw new ArgumentException("Manufacturer cannot be less than 3 and more than 50 letters long!");
                }
                this.manufacturer = value;
            }
        }

        public double? Price
        {
            get { return this.price; }
            set
            {
                if (value < 1 || value > 20000)
                {
                    throw new ArgumentException("Wrong price entered!");
                }
                this.price = value;
            }
        }

        public string Owner
        {
            get { return this.owner; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Owner cannot be empty!");
                }

                if (value.Length < 3 || value.Length > 50)
                {
                    throw new ArgumentException("Owner cannot be less than 3 and more than 50 letters long!");
                }
                this.owner = value;
            }
        }

        static public GSM IPhone4S
        {
            get { return GSM.iPhone4S; }
        }

        public List<Call> CallHistory
        {
            get { return callHistory; }
            set { callHistory = value; }
        }
        //</properties>


        //<constructors>
        public GSM(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
        }

        public GSM(string model, string manufacturer, double price, string owner)
            : this(model, manufacturer)
        {
            this.price = price;
            this.owner = owner;
        }

        public GSM(string model, string manufacturer, double price, string owner, Battery battery, Display display)
            : this(model, manufacturer, price, owner)
        {
            this.battery = battery;
            this.display = display;
        }
        //</constructors>


        public override string ToString()
        {

            return string.Format("\n\nBASIC INFORMATION\n----------------\nModel: {0} \nManufacturer: {1} \nPrice: {2} \nOwner: {3} \n--------------------------------------------------------\n",
                this.model, this.manufacturer, this.price, this.owner +
                this.battery + this.display);
        }

    }
}
