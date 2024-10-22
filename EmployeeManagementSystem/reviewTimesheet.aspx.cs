using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class reviewTimesheet : System.Web.UI.Page
    {
       //database connection
       string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            getTimesheetData();
            timesheetGrid.DataBind();
        }

        void getTimesheetData()
        { //select query to get data from database tables
            try
            {
                //connection to sql server
                SqlConnection con = new SqlConnection(strcon);
                //if connection is closed; open
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                
                SqlCommand cmd = new SqlCommand("SELECT username, date, time_in, time_out, hours_worked, SUM(hours_worked) OVER(ORDER by id) As cumulative_hours FROM timesheetTable WHERE username ='" + Session["username"].ToString() + "'; ", con);  
                SqlCommand cmdPay = new SqlCommand("SELECT * FROM userTable WHERE username='" + Session["username"] + "';", con); 
                //alternative way of database connectivity
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                SqlDataAdapter daPay = new SqlDataAdapter(cmdPay);
                DataTable dt = new DataTable();
                DataTable ds = new DataTable();
                daPay.Fill(ds);
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    timesheetGrid.DataSource = dt;
                    timesheetGrid.DataBind();
                    //a variable to store the maximum value from the column cumulative_hours
                    //double totalHours = dt.AsEnumerable().Sum(x => x["hours_worked"]);
                    var maxRow = dt.AsEnumerable().Max(x => x["cumulative_hours"]);
                    CumulativeHoursLabel.Text = maxRow.ToString();

                    /*double sum = 0.00d;
                    for (int i = 0; i < timesheetGrid.Rows.Count; ++i)
                    {
                        sum += Convert.ToDouble(timesheetGrid.Rows[i].Cells[4].Text);
                        CumulativeHoursLabel.Text = sum.ToString();
                    }*/

                    if (ds.Rows.Count >= 1)
                    {
                        PerHourRateLabel.Text = ds.Rows[0]["salary"].ToString();
                    }

                    TotalEarningLabel.Text = Convert.ToString((Convert.ToDouble(CumulativeHoursLabel.Text))*(Convert.ToDouble(PerHourRateLabel.Text)));
                }
                else
                {
                    CardHide.Visible = false;
                    emptyGrid.Text = "No Project details to view.";

                }// end else

                


            }//end try

            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "'); </script>");

            }//end catch
        }//end getTimesheetData method

  /*      protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            string message = "Do you want to delete this entry?";
            string title = "Delete entry";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
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

                    SqlCommand cmd = new SqlCommand("DELETE from timesheetTable " +
                        " WHERE username = '" + Session["username"].ToString() + "'", con);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    Response.Write("<script>alert('Successfully Deleted.');</script>");
                    timesheetGrid.DataBind();
                }//end try
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "'); </script>");
                }//end catch
            }//end if
            else
            {
                
            }
        }//end DeleteBtn*/


      /*  protected void timesheetGrid_RowDeleting(object sender, GridViewDeleteEventArgs e)
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

                SqlCommand cmd = new SqlCommand("DELETE from timesheetTable WHERE id = @id", con);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(timesheetGrid.DataKeys[e.RowIndex].Value.ToString()));
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Successfully Deleted.');</script>");
                timesheetGrid.DataBind();
            }//end try
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "'); </script>");
            }//end catch
        }//end timesheetGrid_RowDeleting*/

        protected void SubmitBtn_Click(object sender, EventArgs e)
        {
            CardHide.Visible = false;
            SubmitLabel.Visible = true;
            SubmitLabel.Text = "Submission Successful.";
        }

       
    }// end of class
}//end of namespace