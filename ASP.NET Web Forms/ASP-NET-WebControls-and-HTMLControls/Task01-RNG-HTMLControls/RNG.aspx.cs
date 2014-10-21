namespace Task01_RNG_HTMLControls
{
    using System;

    public partial class RNG : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int rangeMin;
            int rangeMax;
            bool rangeMinIsNumber = int.TryParse(this.rangeMin.Value, out rangeMin);
            bool rangeMaxIsNumber = int.TryParse(this.rangeMax.Value, out rangeMax);

            if (!(rangeMinIsNumber && rangeMaxIsNumber))
            {
                this.output.InnerText = "Please enter a valid integer!";
            }
            else if(rangeMin > rangeMax)
            {
                this.output.InnerText = "The second integer must be bigger than the first one!";
            }
            else
            {
                int number = random.Next(rangeMin, rangeMax);
                this.output.InnerText = "Your random number is" + number.ToString();
            }
        }
    }
}