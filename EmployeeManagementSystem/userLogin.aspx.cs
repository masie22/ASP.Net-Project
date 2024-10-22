using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeManagementSystem
{
    public partial class userLogin : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {   //if cookies are available
                if (Request.Cookies["username"] !=null && Request.Cookies["password"] != null)
                {
                    TextBox1.Text = Request.Cookies["username"].Value;
                    TextBox2.Text = Request.Cookies["password"].Value;
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * from userTable WHERE username='"+ TextBox1.Text.Trim()+"' AND password='"+ TextBox2.Text.Trim() + "';", con);
                //connected architecture
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    if (RememberBox.Checked)
                    {
                        Response.Cookies["username"].Value = TextBox1.Text.Trim();
                        Response.Cookies["password"].Value = TextBox2.Text.Trim();
                        //expiry period for the cookies
                        Response.Cookies["username"].Expires = DateTime.Now.AddMinutes(1);
                        Response.Cookies["password"].Expires = DateTime.Now.AddMinutes(1);

                    }
                    else
                    {//if the user has not checked 
                        Response.Cookies["username"].Expires = DateTime.Now.AddMinutes(-1);
                        Response.Cookies["password"].Expires = DateTime.Now.AddMinutes(-1);
                    }
                    while (dr.Read())
                    {
                        //Response.Write("<script>alert('" + dr.GetValue(9) + "') </script>");
                        
                        Session["username"] = dr.GetValue(5).ToString();
                        Session["first_name"] = dr.GetValue(0).ToString();
                        Session["role"] = dr.GetValue(12).ToString().Trim();
                        //Response.Write("<script>alert('" + Session["role"] + "') </script>");
                    }
                    Response.Redirect("homePage.aspx");
                }
                else
                {
                    Message.Text = "Invalid Credentials. Try Again.";                   
                }
            }
            catch (Exception ex)
            {
                Response.Write("< script > alert('"+ex.Message+"'); </ script > ");
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Message.Text = "Contact your Admin for assistance.";            
        }
    }
}