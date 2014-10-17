using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_GSM
{
    class Display
    {
        //<fields>
        private double? sizeInInches = null;
        private long? colors = null;
        //</fields>


        //<properties>
        public double? SizeInInches
        {
            get { return this.sizeInInches; }
            set 
            {
                if (value < 1 || value > 20)
                {
                    throw new ArgumentException("Display size does matter!");
                }
                this.sizeInInches = value; 
            }
        }

        public long? Colors
        {
            get { return this.colors; }
            set 
            {
                if (value < 1)
                {
                    throw new ArgumentException("Wring number of colors entered!");
                }
                this.sizeInInches = value; 
                this.colors = value;
            }
        }
        //</properties>

        //<constructors>
        public Display(double sizeInInches, long colors)
        {
            this.sizeInInches = sizeInInches;
            this.colors = colors;
        }
        //</constructors>

        public override string ToString()
        {
            return string.Format("\n\nDISPLAY INFORMATION\n----------------\nDisplay Size: {0} \nNumber of colors: {1} \n\n",
                this.sizeInInches, this.colors);
        }
    }
}
