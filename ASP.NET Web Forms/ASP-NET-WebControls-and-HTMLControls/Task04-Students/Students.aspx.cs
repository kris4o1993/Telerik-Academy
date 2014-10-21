using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task04_Students
{
    public partial class Students : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SumbitInput_Click(object sender, EventArgs e)
        {
            var studentName = this.TB_FirstName.Text + " " + this.TB_LastName.Text;
            var fn = this.TB_FacNumber.Text;
            var university = this.DDL_University.Text;
            var courses = new List<ListItem>();

            for (int i = 0; i < LBOX_Courses.Items.Count; i++)
            {
                if (LBOX_Courses.Items[i].Selected)
                {
                    courses.Add(LBOX_Courses.Items[i]);
                }
            }

            this.PanelResults.Controls.Add(new LiteralControl("<p>Name: <strong>" + studentName + "</strong></p>"));
            this.PanelResults.Controls.Add(new LiteralControl("<p>Faculty Number: <strong>" + fn + "</strong></p>"));
            this.PanelResults.Controls.Add(new LiteralControl("<p>University: <strong>" + university + "</strong></p>"));
            this.PanelResults.Controls.Add(new LiteralControl("<p>Courses: <strong>" + String.Join(", ", courses) + "</strong></p>"));
        }
    }
}