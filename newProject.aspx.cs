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
    public partial class WebForm2 : System.Web.UI.Page
    {
        //to fill the project manager dropdown list with username from usertable
        //database connection
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //message when the projectID is already taken
            if (checkProjectExists())
            {
                Response.Write("<script>alert ('ProjectID already exists, try another ID'); </script>");
            }
            else
            {
                //add project
                addProject();

            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            // update button clicked
            if (checkProjectExists())
            {
                updateProject();

            }
            else
            {
                Response.Write("<script>alert ('ProjectID doesnot exists, first add project'); </script>");
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //delete button clicked
            if (checkProjectExists())
            {
                deleteProject();

            }
            else
            {
                Response.Write("<script>alert ('Username doesnot exists'); </script>");
            }


        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            //go button
            goButton();

        }




        //user defined functions
        bool checkProjectExists()
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
                //checking for duplicate creation of projectID from textfield username
                SqlCommand cmd = new SqlCommand("SELECT * from projectTable WHERE Project_ID='" + TextBox3.Text.Trim() + "';", con);
                //alternative way of database connectivity
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);//fill the data from the textbox 3 to data table dt

                if (dt.Rows.Count >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "'); </script>");
                return false;
            }
        }

        void addProject()
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

                SqlCommand cmd = new SqlCommand("INSERT INTO projectTable (Project_ID,Project_Name,Associated_Company,Contact,Start_Date,End_Date,staff_name,Budget,Status) VALUES (@p_id,@p_name,@c_name,@contact,@s_date,@e_date,@staff_name,@budget,@status) ", con);

                cmd.Parameters.AddWithValue("@p_id", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@p_name", TextBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@c_name", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@contact", TextBox9.Text.Trim());
                cmd.Parameters.AddWithValue("@s_date", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@e_date", TextBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@staff_name", DropDownList1.SelectedItem.Text);
                cmd.Parameters.AddWithValue("@budget", TextBox8.Text.Trim());
                
                //cmd.Parameters.AddWithValue("@status", DropDownList2.SelectedItem.Text);
                DateTime dt1 = DateTime.Now;
                DateTime dt2 = Convert.ToDateTime(TextBox2.Text.Trim());
                DateTime dt3 = Convert.ToDateTime(TextBox5.Text.Trim());
                if (dt1 < dt2)
                {
                    
                    TextBox6.Text = "Upcoming";
                }
                else if (dt3 <= dt1)
                {
                    
                    TextBox6.Text = "Completed";
                }
                else
                {
                    
                    TextBox6.Text = "In Progress";
                }
                cmd.Parameters.AddWithValue("@status", TextBox6.Text.Trim());



                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Successfully created');</script>");
                clearForm(this.Controls);
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "'); </script>");
            }

        }

        void updateProject()
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

                SqlCommand cmd = new SqlCommand("UPDATE projectTable " +
                    "SET " + 
                    "Project_Name=@p_name," +
                    "Associated_Company=@c_name," +
                    "Contact=@contact," +
                    "Start_Date=@s_date," +
                    "End_Date=@e_date," +
                    "staff_name=@staff_name," +
                    "Budget=@budget," +
                    "Status=@status" +
                    " WHERE Project_ID = '" + TextBox3.Text.Trim() + "'", con);

                cmd.Parameters.AddWithValue("@p_name", TextBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@c_name", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@contact", TextBox9.Text.Trim());
                cmd.Parameters.AddWithValue("@s_date", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@e_date", TextBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@staff_name", DropDownList1.SelectedItem.Text);
                cmd.Parameters.AddWithValue("@budget", TextBox8.Text.Trim());
                //cmd.Parameters.AddWithValue("@status", DropDownList2.SelectedItem.Text);
                //Check for the start date and end date and change status
                DateTime dt1 = DateTime.Now;
                DateTime dt2 = Convert.ToDateTime(TextBox2.Text.Trim());
                DateTime dt3 = Convert.ToDateTime(TextBox5.Text.Trim());
                if (dt1 < dt2)
                {

                    TextBox6.Text = "Upcoming";
                }
                else if (dt3 <= dt1)
                {

                    TextBox6.Text = "Completed";
                }
                else
                {

                    TextBox6.Text = "Pending";
                }
                cmd.Parameters.AddWithValue("@status", TextBox6.Text.Trim());

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Successfully Updated');</script>");
                clearForm(this.Controls);
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "'); </script>");
            }
        }

        void deleteProject()
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

                SqlCommand cmd = new SqlCommand("DELETE from projectTable " +
                    " WHERE Project_ID = '" + TextBox3.Text.Trim() + "'", con);

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Successfully Deleted');</script>");
                clearForm(this.Controls);
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "'); </script>");
            }
        }

        void clearForm(ControlCollection controls)
        {
            //function to clear all the textbox values
            foreach (TextBox tb in controls.OfType<TextBox>())
                tb.Text = string.Empty;
            foreach (Control c in controls)
                clearForm(c.Controls);
        }

        void goButton()
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
                SqlCommand cmd = new SqlCommand("SELECT * from projectTable WHERE Project_ID='" + TextBox3.Text.Trim() + "';", con);
                //alternative way of database connectivity
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);//fill the data from the textbox 5 to data table dt

                if (dt.Rows.Count >= 1)
                {
                    TextBox4.Text = dt.Rows[0][1].ToString();//project name
                    TextBox1.Text = dt.Rows[0][2].ToString();//associated company
                    TextBox9.Text = dt.Rows[0][3].ToString();//contact no
                    TextBox2.Text = dt.Rows[0][4].ToString();//start date 
                    TextBox5.Text = dt.Rows[0][5].ToString();//end date
                    //DropDownList2.SelectedItem.Text = dt.Rows[0][8].ToString();//status
                    TextBox6.Text = dt.Rows[0][8].ToString();//end date
                    DropDownList1.SelectedItem.Text = dt.Rows[0][6].ToString();//project manager
                    TextBox8.Text = dt.Rows[0][7].ToString();//budget allocated 
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



    }   
}