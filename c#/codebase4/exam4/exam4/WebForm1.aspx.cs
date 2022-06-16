using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace exam4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] str = new string[] { "Select", "Lamborghini", "Suv", "Nano", "OnePlus", "Boat" };
                for (int i = 0; i < str.Length; i++)
                {
                    DropDownList1.Items.Add(str[i]);
                }
            }
        }



        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = DropDownList1.Text;
            Image1.ImageUrl = "~/photos/" + str + ".Jpg";
        }
        protected void TextBox1_TextChanged1(object sender, EventArgs e)
        {



        }



        protected void Button1_Click1(object sender, EventArgs e)
        {
            TextBox1.Text = DropDownList1.SelectedIndex.ToString();
            if (DropDownList1.Text == "Lamborghini")
            {
                TextBox1.Text = "Rs. 40000000";
            }
            else if (DropDownList1.Text == "Suv")
            {
                TextBox1.Text = "Rs. 8000000";
            }
            else if (DropDownList1.Text == "Nano")
            {
                TextBox1.Text = "Rs.200000";
            }
            else if (DropDownList1.Text == "OnePlus")
            {
                TextBox1.Text = "Rs.35000";
            }
            else
            {
                TextBox1.Text = "Rs.2000";
            }
        }
    }
}
    
