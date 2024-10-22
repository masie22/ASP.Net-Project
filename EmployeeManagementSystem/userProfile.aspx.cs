using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace EmployeeManagementSystem
{
    public partial class userProfile : System.Web.UI.Page
    {
        //database connection
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        static string global_imagepath;//make them available through the page
        protected void Page_Load(object sender, EventArgs e)
        {
            //array list for states dropdown
            string[] stateArray = {"Alabama","Alaska","Arizona","Arkansas","California","Colorado","Connecticut","Delaware","Florida","Georgia","Hawaii","Iowa","Idaho","Illinois","Indiana","Kansas","Kentucky","Louisiana","Massachusetts","Maryland","Maine", "Michigan","Minnesota","Missouri","Mississippi", "Montana","North Carolina",
             "North Dakota","Nebraska", "New Hampshire","New Jersey","New Mexico","Nevada","New York","Ohio","Oklahoma","Oregon","Pennsylvania","Rhode Island","South Carolina","South Dakota","Tennessee","Texas","Utah","Virginia","Vermont","Washington","Wisconsin", "West Virginia","Wyoming"};
            DropDownList1.DataSource = stateArray;
            DropDownList1.DataBind();
            ListItem state = new ListItem("Select State");
            DropDownList1.Items.Insert(0, state);
            getUserData();
            if(!Page.IsPostBack)
            {
                getUserDetails();
            }  
        }//end pageload

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            //update 
            updateUser();
        }

        //user defined methods
        void getUserData()
        { //select query to get data from join database tables
            
            try
            {
                //connection to sql server
                SqlConnection con = new SqlConnection(strcon);
                //if connection is closed; open
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                //checking for duplicate creation of username from textfield username
                SqlCommand cmd = new SqlCommand("SELECT userTable.staff_name, userTable.role, projectTable.Project_Name, projectTable.Start_Date, projectTable.End_Date, projectTable.Status FROM[dbo].[userTable] INNER JOIN projectTable ON userTable.staff_name = projectTable.staff_name WHERE userTable.username ='" + Session["username"].ToString() + "';", con);
                //alternative way of database connectivity
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                    {
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                    }
                else
                    {
                        emptyGrid.Text = "No Project details to view.";
                    }
                }// end try

            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "'); </script>");
            }
        }

        void getUserDetails()
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
                //checking for duplicate creation of username from textfield username
                SqlCommand cmd = new SqlCommand("SELECT * from userTable WHERE username='" + Session["username"] + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);//fill the data from the textbox 5 to data table dt

                if (dt.Rows.Count >= 1)
                {
                    //Response.Write("<script>alert('" + dt.Rows[0]["dob"].ToString().Trim() + "'); </script>") ;

                    TextBox3.Text = dt.Rows[0][0].ToString();//first name
                    TextBox4.Text = dt.Rows[0][1].ToString();//lname
                    TextBox1.Text = dt.Rows[0][4].ToString();//contact
                    TextBox2.Text = dt.Rows[0][3].ToString().Trim();//dob 
                    TextBox5.Text = dt.Rows[0][5].ToString();//userid
                    TextBox6.Text = dt.Rows[0][6].ToString().Trim();//password

                    TextBox7.Text = dt.Rows[0][7].ToString();//address

                    TextBox8.Text = dt.Rows[0][8].ToString();//city
                    DropDownList1.SelectedItem.Text = dt.Rows[0][9].ToString();//state
                    TextBox11.Text = dt.Rows[0][10].ToString();//postal code               

                    global_imagepath = dt.Rows[0]["userimage"].ToString();

                    userImage.ImageUrl = global_imagepath;
                }
                else
                {
                    Response.Write("<script>alert('Invalid username'); </script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "'); </script>");

            }
        }

        void updateUser()
        {
            string password = "";
            if (TextBox9.Text.Trim() == "")//if new password blank
            {
                password = TextBox6.Text.Trim();//old password
            }
            else
            {
                password = TextBox9.Text.Trim();//new password
            }
            
            try
            {
               string imagepath = "~/images/adduser";
               string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
                //checkk if filename is blank or already has a file
               if (filename == "" || filename == null)
                {
                    imagepath = global_imagepath;//not updating the image path, it is the first uploaded one
                }
               else
                {    //updating the new image
                    FileUpload1.SaveAs(Server.MapPath("images/" + filename));
                    imagepath = "~/images/" + filename;
                }


                //connection to sql server
                SqlConnection con = new SqlConnection(strcon);
                //if connection is closed; open
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("UPDATE userTable " +
                    "SET " +
                    "first_name=@f_name," +
                    "last_name=@l_name," +
                    "contact_number=@c_number," +
                    "dob=@dob," +
                    "password=@password," +
                    " address_line=@address," +
                    "city=@city," +
                    "state=@state," +
                    "postal_code=@postal_code," +
                    "full_address=@full_address," +
                    "userimage=@userimage" +
                    " WHERE username = '" + Session["username"].ToString().Trim() + "'", con);

                cmd.Parameters.AddWithValue("@f_name", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@l_name", TextBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@c_number", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@dob", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@address", TextBox7.Text.Trim());
                cmd.Parameters.AddWithValue("@city", TextBox8.Text.Trim());
                cmd.Parameters.AddWithValue("@state", DropDownList1.SelectedItem.Text);
                cmd.Parameters.AddWithValue("@postal_code", TextBox11.Text.Trim());
                cmd.Parameters.AddWithValue("@full_address", TextBox7.Text.Trim() + ',' + TextBox8.Text.Trim() + ' ' + DropDownList1.SelectedItem.Text + ' ' + TextBox11.Text.Trim());
                cmd.Parameters.AddWithValue("@userimage", imagepath);

                int result = cmd.ExecuteNonQuery();
                con.Close();
                if (result > 0)
                {
                    Response.Write("<script>alert('Successfully Updated');</script>");
                    getUserDetails();
                    getUserData();
                }
                else
                {
                    Response.Write("<script>alert('Invalid Entry');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "'); </script>");
            }
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        { //renaming the headers in the gridview
            if (e.Row.RowType == DataControlRowType.Header)
            {
                e.Row.Cells[0].Text = "Name";
                e.Row.Cells[1].Text = "Role";
                e.Row.Cells[2].Text = "Project Name";
                e.Row.Cells[3].Text = "Start Date";
                e.Row.Cells[4].Text = "End Date";
                e.Row.Cells[5].Text = "Status";

            }
        }

    }//end class
}//end namespace