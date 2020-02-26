using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HW1_24808869768_WSP
{
    public class Calculate{

        public int Add(int FirstValue, int SecondValue)
        {
            return FirstValue + SecondValue;
        }
        public int Sub(int FirstValue, int SecondValue)
        {
            return FirstValue - SecondValue;
        }
        public int Multi(int FirstValue, int SecondValue)
        {
            return FirstValue * SecondValue;
        }
        public double Div(double FirstValue, double SecondValue)
        {
            
            return FirstValue / SecondValue;
        }
    }
    public partial class Default : System.Web.UI.Page
    {
        Calculate Cal;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            Cal = new Calculate();
          
            
        }
        protected void btn0_Click(object sender, EventArgs e)
        {

            if (Result.Value == "0" && txtBox.Text == "0")
            {
                txtBox.Text = "0";
                Result.Value = "0";
            }
            else if (txtBox.Text == "0")
            {
                Result.Value = "0";
                txtBox.Text = "0";
            }
            else
            {
                txtBox.Text += "0";
                Result.Value = Result.Value + "0";
            }
        }
        protected void btn1_Click(object sender, EventArgs e)
        {
            
            if (Result.Value == "0"&&txtBox.Text=="0")
            {                
                txtBox.Text = "1";
                Result.Value = "1";
            }
            else if (txtBox.Text == "0")
            {
                Result.Value = "1";
                txtBox.Text = "1";
            }
            else {
                txtBox.Text += "1";
                Result.Value = Result.Value + "1";
            }       
        }
        protected void btn2_Click(object sender, EventArgs e)
        {
            
           if (Result.Value == null && txtBox.Text == "0")
            {
                txtBox.Text = "";
                Result.Value = "2";
                txtBox.Text = "2";
            }

            else if (txtBox.Text == "0")
            {
                Result.Value = "2";
                txtBox.Text = "2";
            }
            else { 
                Result.Value = Result.Value + "2";
                txtBox.Text += "2";
            }      
        }
        protected void btn3_Click(object sender, EventArgs e)
        {
            
            if (Result.Value == "0" && txtBox.Text == "0")
            {
                Result.Value = "3";
                txtBox.Text = "3";
            }
            else if (txtBox.Text == "0")
            {
                Result.Value = "3";
                txtBox.Text = "3";
            }
            else { 
                Result.Value = Result.Value + "3";
                txtBox.Text += "3";
            }
          
        }
        protected void btn4_Click(object sender, EventArgs e)
        {
            if (Result.Value == "0" && txtBox.Text == "0")
            {
                Result.Value = "4";
                txtBox.Text = "4";
            }

            else if (txtBox.Text == "0")
            {
                Result.Value = "4";
                txtBox.Text = "4";
            }
            else
            {
                Result.Value = Result.Value + "4";
                txtBox.Text += "4";
            }      
        }

        protected void btn5_Click(object sender, EventArgs e)
        {
            if (Result.Value == "0" && txtBox.Text == "0")
            {
                Result.Value = "5";
                txtBox.Text = "5";
            }
            else if (txtBox.Text == "0")
            {
                Result.Value = "5";
                txtBox.Text = "5";
            }
            else { 
                Result.Value = Result.Value + "5";
                txtBox.Text += "5";
            }
        }

        protected void btn6_Click(object sender, EventArgs e)
        {
            if (Result.Value == "0" && txtBox.Text == "0")
            {
                Result.Value = "6";
                txtBox.Text = "6";
            }
            else if (txtBox.Text=="0") {
                Result.Value = "6";
                txtBox.Text = "6";
            }
            else { 
                Result.Value = Result.Value + "6";
                txtBox.Text += "6";
            }
        }
        protected void btn7_Click(object sender, EventArgs e)
        {
            if (Result.Value == "" && txtBox.Text == "")
            {
                Result.Value = "7";
                txtBox.Text = "7";
            }
            else if (txtBox.Text == "0")
            {
                Result.Value = "7";
                txtBox.Text = "7";
            }
            else { 
                Result.Value = Result.Value + "7";
                txtBox.Text += "7";
            }
        }
        protected void btn8_Click(object sender, EventArgs e)
        {
            if (Result.Value == "0" && txtBox.Text == "0")
            {
                Result.Value = "8";
                txtBox.Text = "8";
            }
            else if (txtBox.Text == "0")
            {
                Result.Value = "8";
                txtBox.Text = "8";
            }
            else 
            { 
                Result.Value = Result.Value + "8";
                txtBox.Text += "8";
            }
        }

        protected void btn9_Click(object sender, EventArgs e)
        {
            if (Result.Value == "0" && txtBox.Text == "0")
            {
                Result.Value = "9";
                txtBox.Text = "9";
            }
            else if (txtBox.Text == "0")
            {
                Result.Value = "9";
                txtBox.Text = "9";
            }
            else { 
                Result.Value = Result.Value + "9";
                txtBox.Text += "9";
            }
        }
        protected void btnMulti_Click(object sender, EventArgs e)
        {                
                ViewState["FirstValue"] = Result.Value;
                ViewState["Op"] = "Multi";
                Result.Value = "";
                txtBox.Text += "*";

        }

        protected void btnDiv_Click(object sender, EventArgs e)
        {                
                ViewState["FirstValue"] = Result.Value;
                ViewState["Op"] = "Div";
                Result.Value = "";
                txtBox.Text += "/";
        }

        protected void btnSub_Click(object sender, EventArgs e)
        {
                
                ViewState["FirstValue"] = Result.Value;
                ViewState["Op"] = "Sub";
                Result.Value = "";
                txtBox.Text += "-";
        }

        protected void btnPlus_Click(object sender, EventArgs e)
        {
                ViewState["FirstValue"] = Result.Value;
                ViewState["Op"] = "Sum";
                Result.Value = "";
                txtBox.Text += "+";
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Result.Value = "0";
            txtBox.Text = "0";
            if ((string)ViewState["Op"] != null)
            {
                ViewState["Op"] = null;
            }
            else if ((string)ViewState["FirstValue"] != null)
            {
                ViewState["FirstValue"] = null;
            }
        }

        protected void btnEqual_Click(object sender, EventArgs e)
        {
            if (Result.Value == "")
            {
                Response.Write("<script>alert('No Value is given.')</script>");
            }
            else
            {
                ViewState["SecondValue"] = Result.Value;
                Result.Value = "";
                txtBox.Text = Result.Value;

                try
                {
                    if ((string)ViewState["Op"] == "Sum")
                    {
                        Result.Value = Cal.Add(Convert.ToInt32(ViewState["FirstValue"]), Convert.ToInt32(ViewState["SecondValue"])).ToString();
                    }
                    else if ((string)ViewState["Op"] == "Sub")
                    {
                        Result.Value = Cal.Sub(Convert.ToInt32(ViewState["FirstValue"]), Convert.ToInt32(ViewState["SecondValue"])).ToString();
                    }
                    else if ((string)ViewState["Op"] == "Multi")
                    {
                        Result.Value = Cal.Multi(Convert.ToInt32(ViewState["FirstValue"]), Convert.ToInt32(ViewState["SecondValue"])).ToString();
                    }
                    else if ((string)ViewState["Op"] == "Div")
                    {
                        if(Convert.ToInt32(ViewState["SecondValue"]) == 0) { Response.Write("<script>alert('division-by-zero exception')</script>"); }
                        else {

                        Result.Value = Cal.Div(Convert.ToInt32(ViewState["FirstValue"]), Convert.ToInt32(ViewState["SecondValue"])).ToString();
                        }
                    }
                    else Response.Write("<script>alert('No Operation was recorded.')</script>");
                    txtBox.Text = Result.Value;
                }
               
                catch (FormatException)
                {
                    Response.Write("<script>alert('Wrong Input Format is Entered.')</script>");
                }
            }
        }

        protected void txtBox_TextChanged(object sender, EventArgs e)
        {
            Result.Value = "0";
        }
    }
}
