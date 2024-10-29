using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeManagementSystem
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void TimeOut_TextChanged(object sender, EventArgs e)
        {
            hoursWorked();
        }

        protected void TimeIn_TextChanged(object sender, EventArgs e)
        {
            hoursWorked();
        }

        protected void Date_TextChanged(object sender, EventArgs e)
        {
            if(DateTextBox.Text != null) 
            {
                DateTime inputDate = DateTime.Parse(DateTextBox.Text);
                DayTextBox.Text = inputDate.DayOfWeek.ToString();
                if ((DayTextBox.Text == "Sunday") || (DayTextBox.Text == "Saturday"))
                {
                    TimeOut.Enabled = false;
                    TimeIn.Enabled = false;
                    SaveTime.Enabled = false;
                    TimeOut.Text = "";
                    TimeIn.Text = "";
                    HoursWorked.Text = "";
                }
                else
                {
                    TimeOut.Enabled = true;
                    TimeIn.Enabled = true;
                    SaveTime.Enabled = true;
                }
            }
            else
            {
                Response.Write("<script>alert('Date cannot be empty');</script>");
            }
            
        }

        protected void SaveTime_Click(object sender, EventArgs e)
        {
            addTimesheet();
        }

        //creating userdefined functions
        void hoursWorked()
        { //functions for timedifference
                DateTime timeOut = DateTime.Parse(TimeOut.Text.Trim());
                DateTime timeIn = DateTime.Parse(TimeIn.Text.Trim());
                var hour24diff = new TimeSpan(24, 0, 0);
                var difference = timeOut.Subtract(timeIn);
                difference = (difference.Duration() != difference) ? hour24diff.Subtract(difference.Duration()) : difference;//duration method to remove negative hour difference
                HoursWorked.Text = difference.TotalHours.ToString("#0.00");         
        }

        void addTimesheet()
        {
            if (DateTextBox.Text != " " && TimeOut.Text != " "  && TimeIn.Text !=  "")
            {
                try
                {
                    //connection to sql server
                    SqlConnection con = new SqlConnection(strcon);
                    //if connection is closed; open
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    SqlCommand cmd = new SqlCommand("INSERT INTO timesheetTable (username,date,time_in,time_out,hours_worked) VALUES (@username,@date,@time_in,@time_out,@hours_worked) ", con);

                    cmd.Parameters.AddWithValue("@username", Session["username"].ToString().Trim());
                    cmd.Parameters.AddWithValue("@date", DateTextBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@time_in", TimeIn.Text.Trim());
                    cmd.Parameters.AddWithValue("@time_out", TimeOut.Text.Trim());
                    cmd.Parameters.AddWithValue("@hours_worked", HoursWorked.Text.Trim());
                    
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Response.Write("<script>alert('Successfully Submitted!');</script>");
                    TimeOut.Text = "";
                    TimeIn.Text = "";
                    HoursWorked.Text = "";
                    DateTextBox.Text = "";
                    DayTextBox.Text = "";
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "'); </script>");
                }
            }// end if
            else
            {
                Response.Write("<script>alert('Field cannot be empty');</script>");
            }
        }

        protected void ReviewTimesheetBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("reviewTimesheet.aspx");
        }

        protected void repeatForm_Click(object sender, EventArgs e)
        {

        }
    }
}