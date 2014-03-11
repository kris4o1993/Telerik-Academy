using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_GSM
{
    public enum BatteryType
    {
        Undefined, LiIon, NiMH, NiCd
    }

    class Battery
    {
        //<fields>
        private string model = null;
        private BatteryType batteryType = BatteryType.Undefined;
        private double? hoursIdle = null;
        private double? hoursTalk = null;
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

        public BatteryType BatteryType
        {
            get { return this.batteryType; }
            set 
            { 
                this.batteryType = value;
            }
        }

        public double? HoursIdle
        {
            get { return this.hoursIdle; }
            set 
            { 
                this.hoursIdle = value; 
            }
        }

        public double? HoursTalk
        {
            get { return this.hoursTalk; }
            set 
            { 
                this.hoursTalk = value; 
            }
        }
        //</properties>


        //<constructors>
        public Battery(string model, double hoursIdle, double hoursTalk)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
            
        }
        //</constructors>


        public override string ToString()
        {
            return string.Format("\n\nBATTERY INFORMATION\n----------------\nModel: {0} \nBattery Type: {1} \nHours Idle: {2} \nHours Talk: {3}\n\n",
                this.model, this.batteryType, this.hoursIdle, this.hoursTalk);
        }
    }
}
