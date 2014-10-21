using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task03_Escaping
{
    public partial class Escaping : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SumbitInput_Click(object sender, EventArgs e)
        {
            string input = this.Input.Text;
            this.TB_Result.Text = input;
            this.LBL_Result.Text = input;
        }
    }
}