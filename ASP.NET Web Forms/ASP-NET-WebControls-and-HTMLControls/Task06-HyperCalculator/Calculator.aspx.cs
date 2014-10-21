using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task06_HyperCalculator
{
    public partial class Calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void BTN_1_Click(object sender, EventArgs e)
        {
            if (this.Output.Text == "0")
            {
                this.Output.Text = string.Empty;
            }

            this.LBL_Alerts.Text = "HyperCalculator";
            this.Output.Text += "1";
        }

        protected void BTN_2_Click(object sender, EventArgs e)
        {
            if (this.Output.Text == "0")
            {
                this.Output.Text = string.Empty;
            }

            this.LBL_Alerts.Text = "HyperCalculator";
            this.Output.Text += "2";
        }

        protected void BTN_3_Click(object sender, EventArgs e)
        {
            if (this.Output.Text == "0")
            {
                this.Output.Text = string.Empty;
            }

            this.LBL_Alerts.Text = "HyperCalculator";
            this.Output.Text += "3";
        }

        protected void BTN_4_Click(object sender, EventArgs e)
        {
            if (this.Output.Text == "0")
            {
                this.Output.Text = string.Empty;
            }

            this.LBL_Alerts.Text = "HyperCalculator";
            this.Output.Text += "4";
        }

        protected void BTN_5_Click(object sender, EventArgs e)
        {
            if (this.Output.Text == "0")
            {
                this.Output.Text = string.Empty;
            }

            this.LBL_Alerts.Text = "HyperCalculator";
            this.Output.Text += "5";
        }

        protected void BTN_6_Click(object sender, EventArgs e)
        {
            if (this.Output.Text == "0")
            {
                this.Output.Text = string.Empty;
            }

            this.LBL_Alerts.Text = "HyperCalculator";
            this.Output.Text += "6";
        }

        protected void BTN_7_Click(object sender, EventArgs e)
        {
            if (this.Output.Text == "0")
            {
                this.Output.Text = string.Empty;
            }

            this.LBL_Alerts.Text = "HyperCalculator";
            this.Output.Text += "7";
        }

        protected void BTN_8_Click(object sender, EventArgs e)
        {
            if (this.Output.Text == "0")
            {
                this.Output.Text = string.Empty;
            }

            this.LBL_Alerts.Text = "HyperCalculator";
            this.Output.Text += "8";
        }

        protected void BTN_9_Click(object sender, EventArgs e)
        {
            if (this.Output.Text == "0")
            {
                this.Output.Text = string.Empty;
            }

            this.LBL_Alerts.Text = "HyperCalculator";
            this.Output.Text += "9";
        }

        protected void BTN_0_Click(object sender, EventArgs e)
        {
            if (this.Output.Text == "0")
            {
                this.Output.Text = string.Empty;
                this.Output.Text += "0";
            }
            else if (this.Output.Text.Length > 0 && this.Output.Text[this.Output.Text.Length - 1] == '/')
            {
                this.LBL_Alerts.Font.Bold = true;
                this.LBL_Alerts.Text = "Cannot divide by zero";
            }
            else
            {
                this.LBL_Alerts.Text = "HyperCalculator";
                this.Output.Text += "0";
            }
            
        }

        protected void BTN_Plus_Click(object sender, EventArgs e)
        {
            if (this.Output.Text.Length == 0)
            {
                this.LBL_Alerts.Text = "Addition of an empty expression... You want to break my software nigga?";
            }
            else if (
                this.Output.Text[this.Output.Text.Length - 1] == '/' ||
                this.Output.Text[this.Output.Text.Length - 1] == '+' ||
                this.Output.Text[this.Output.Text.Length - 1] == '*' ||
                this.Output.Text[this.Output.Text.Length - 1] == '-' ||
                this.Output.Text[this.Output.Text.Length - 1] == '%')
            {
                this.LBL_Alerts.Text = "SHIT MAN! Cannot do operations when the last character was operand.";
            }
            else
            {
                this.LBL_Alerts.Text = "HyperCalculator";
                this.Output.Text += "+";
            }
        }

        protected void BTN_Minus_Click(object sender, EventArgs e)
        {
            if (this.Output.Text.Length == 0)
            {
                this.LBL_Alerts.Text = "Substraction of an empty expression... You want to break my software nigga?";
            }
            else if (
                this.Output.Text[this.Output.Text.Length - 1] == '/' ||
                this.Output.Text[this.Output.Text.Length - 1] == '+' ||
                this.Output.Text[this.Output.Text.Length - 1] == '*' ||
                this.Output.Text[this.Output.Text.Length - 1] == '-' ||
                this.Output.Text[this.Output.Text.Length - 1] == '%')
            {
                this.LBL_Alerts.Text = "SHIT MAN! Cannot do operations when the last character was operand.";
            }
            else
            {
                this.LBL_Alerts.Text = "HyperCalculator";
                this.Output.Text += "-";
            }
        }

        protected void BTN_Multiply_Click(object sender, EventArgs e)
        {
            if (this.Output.Text.Length == 0)
            {
                this.LBL_Alerts.Text = "Multiplication of an empty expression... You want to break my software nigga?";
            }
            else if (
                this.Output.Text[this.Output.Text.Length - 1] == '/' ||
                this.Output.Text[this.Output.Text.Length - 1] == '+' ||
                this.Output.Text[this.Output.Text.Length - 1] == '*' ||
                this.Output.Text[this.Output.Text.Length - 1] == '-' ||
                this.Output.Text[this.Output.Text.Length - 1] == '%')
            {
                this.LBL_Alerts.Text = "SHIT MAN! Cannot do operations when the last character was operand.";
            }
            else
            {
                this.LBL_Alerts.Text = "HyperCalculator";
                this.Output.Text += "*";
            }
        }

        protected void BTN_Divide_Click(object sender, EventArgs e)
        {
            if (this.Output.Text.Length == 0)
            {
                this.LBL_Alerts.Text = "Division of an empty expression... You want to break my software nigga?";
            }
            else if (
                this.Output.Text[this.Output.Text.Length - 1] == '/' ||
                this.Output.Text[this.Output.Text.Length - 1] == '+' ||
                this.Output.Text[this.Output.Text.Length - 1] == '*' ||
                this.Output.Text[this.Output.Text.Length - 1] == '-' ||
                this.Output.Text[this.Output.Text.Length - 1] == '%')
            {
                this.LBL_Alerts.Text = "SHIT MAN! Cannot do operations when the last character was operand.";
            }
            else
            {
                this.LBL_Alerts.Text = "HyperCalculator";
                this.Output.Text += "/";
            }
        }

        protected void BTN_Modulus_Click(object sender, EventArgs e)
        {
            if (this.Output.Text.Length == 0)
            {
                this.LBL_Alerts.ForeColor = ColorTranslator.FromHtml("#FF0000");
                this.LBL_Alerts.Text = "Yeah sure... modulus of an empty expression... You want to break my software nigga?";
            }
            else if (this.Output.Text.Contains('.'))
            {
                this.LBL_Alerts.ForeColor = ColorTranslator.FromHtml("#FF0000");
                this.LBL_Alerts.Text = "Modulus of floating-point numbers... Do you even math bro?";
            }
            else if(
                this.Output.Text[this.Output.Text.Length - 1] == '/' ||
                this.Output.Text[this.Output.Text.Length - 1] == '+' ||
                this.Output.Text[this.Output.Text.Length - 1] == '*' ||
                this.Output.Text[this.Output.Text.Length - 1] == '-' ||
                this.Output.Text[this.Output.Text.Length - 1] == '%')
            {
                this.LBL_Alerts.ForeColor = ColorTranslator.FromHtml("#FF0000");
                this.LBL_Alerts.Text = "SHIT MAN! Cannot do operations when the last character was operand.";
            }
            else
            {
                this.LBL_Alerts.Text = "HyperCalculator";
                this.Output.Text += "%";
            }
        }

        protected void BTN_Clear_Click(object sender, EventArgs e)
        {
            this.Output.Text = "";
        }

        protected void BTN_Equals_Click(object sender, EventArgs e)
        {
            if (this.Output.Text.Length == 0 ||
                this.Output.Text[this.Output.Text.Length - 1] == '/' ||
                this.Output.Text[this.Output.Text.Length - 1] == '+' ||
                this.Output.Text[this.Output.Text.Length - 1] == '*' ||
                this.Output.Text[this.Output.Text.Length - 1] == '-' ||
                this.Output.Text[this.Output.Text.Length - 1] == '%')
            {
                this.LBL_Alerts.ForeColor = ColorTranslator.FromHtml("#FF0000");
                this.LBL_Alerts.Text = "Yeah sure... equals of an empty string... You want to break my software nigga?";
            }
            else
            {
                try
                {
                    string expression = this.Output.Text;
                    var loDataTable = new DataTable();
                    var loDataColumn = new DataColumn("Eval", typeof(double), expression);
                    loDataTable.Columns.Add(loDataColumn);
                    loDataTable.Rows.Add(0);
                    var result = (double)(loDataTable.Rows[0]["Eval"]);
                    this.Output.Text = result.ToString();
                    this.LBL_Alerts.Text = "Such expression. Much calculus. Wow!";
                }
                catch (Exception exception)
                {
                    this.LBL_Alerts.Text = "YOOO MAAN! Number too large, cant handle it!";
                }
            }
        }
    }
}