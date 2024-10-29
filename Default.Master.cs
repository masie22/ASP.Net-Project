using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeManagementSystem
{
    public partial class Default : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try{
                if (Session["role"].ToString() == "Admin") //if (!(Session["role"].Equals("admin")))
                    {
                        LinkButton5.Text = "Logged in: " + Session["role"].ToString();//add username to hello,
                    LinkButton2.Visible = true;//add user
                    LinkButton1.Visible = true;//user details
                    LinkButton3.Visible = true;//add project
                    } 
                else
                {
                    LinkButton2.Visible = false;//add user
                    LinkButton1.Visible = false;//user details
                    LinkButton3.Visible = false;//add project
                    LinkButton5.Text = "Logged in: " + Session["username"].ToString();//add username to hello,
                }
            }
            catch (Exception ex)
            {
                Response.Write("< script > alert('" + ex.Message + "'); </ script > ");
            }
            
        }


        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("newUser.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("userDetails.aspx");
        }

        protected void LinkButton3_Click1(object sender, EventArgs e)
        {
            Response.Redirect("newProject.aspx"); 
        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Response.Redirect("projectDetails.aspx"); 
        }

        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            Response.Redirect("homePage.aspx");
        }

        protected void LinkButton4_Click1(object sender, EventArgs e)
        {
            Response.Redirect("userLogin.aspx");
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Response.Redirect("userProfile.aspx");
        }

        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            Response.Redirect("userProfile.aspx");
        }

        protected void LinkButton9_Click(object sender, EventArgs e)
        {
            Response.Redirect("fillTimesheet.aspx");
        }
    }
}