using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeManagementSystem
{
    public partial class homePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {   //on page load display greeting message

                DateTime now = DateTime.Now;
                int h = now.Hour;
                int m = now.Minute;
                int s = now.Second;

                GreetingLabel.Font.Size = 20;
                GreetingLabel.Font.Italic = true;
                if (h < 12)
                {
                    GreetingLabel.Text = "<b>Goodmorning,</b> " + Session["first_name"].ToString() + "!";
                }
                else if (h >= 12 && h <= 17)
                {
                    GreetingLabel.Text = "<b> Goodafternoon, </b>" + Session["first_name"].ToString() + "!";
                }
                else if (h >= 17 && h <= 24)
                {
                    GreetingLabel.Text = "Goodevening, " + Session["first_name"].ToString();
                }
                else
                {
                    GreetingLabel.Text = "Goodnight, " + Session["first_name"].ToString();
                }
            }
            catch (Exception ex)
            {
                Response.Write("< script > alert('" + ex.Message + "'); </ script > ");
            }

        }
    }
}