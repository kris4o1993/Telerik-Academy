using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task02_RNG_WebControls
{
    public partial class RNG : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GenerateRandomNumber_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int rangeMin;
            int rangeMax;
            bool rangeMinIsNumber = int.TryParse(this.RangeMin.Text, out rangeMin);
            bool rangeMaxIsNumber = int.TryParse(this.RangeMax.Text, out rangeMax);

            if (!(rangeMinIsNumber && rangeMaxIsNumber))
            {
                this.Output.Text = "Please enter a valid integer!";
            }
            else if (rangeMin > rangeMax)
            {
                this.Output.Text = "The second integer must be bigger than the first one!";
            }
            else
            {
                int number = random.Next(rangeMin, rangeMax);
                this.Output.Text = "Your random number is" + number.ToString();
            }
        }
    }
}