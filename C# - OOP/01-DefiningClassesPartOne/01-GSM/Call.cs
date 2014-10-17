using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_GSM
{
    class Call
    {
        //<fields>
        private DateTime callStat;
        private string dialedNumber;
        private ulong duration;
        //</fields>



        //<properties>
        public DateTime CallStat
        {
            get { return this.callStat; }
            set { this.callStat = value; }
        }

        public string DialedNumber
        {
            get { return this.dialedNumber; }
            set { this.dialedNumber = value; }
        }

        public ulong Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }
        //</properties>


        //<constructors>
        public Call(DateTime currentCallTime, string currentDialedNumber, ulong durationInSeconds)
        {
            this.callStat = currentCallTime;
            this.dialedNumber = currentDialedNumber;
            this.duration = durationInSeconds;
        }

        //</constructors>


        public override string ToString()
        {
            return string.Format("\n\nCALL INFORMATION\n----------------\nDate: {0} \nNumber: {1} \nCall Duration: {2}\n\n",
                this.callStat, this.dialedNumber, this.duration);
        }

    }
}
