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

    public partial class newUser : System.Web.UI.Page
    { //database connection
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        static string global_imagepath;//make them available through the page
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataBind();
            //array list for states dropdown
            string[] stateArray = {"Alabama","Alaska","Arizona","Arkansas","California","Colorado","Connecticut","Delaware","Florida","Georgia","Hawaii","Iowa","Idaho","Illinois","Indiana","Kansas","Kentucky","Louisiana","Massachusetts","Maryland","Maine", "Michigan","Minnesota","Missouri","Mississippi", "Montana","North Carolina",
             "North Dakota","Nebraska", "New Hampshire","New Jersey","New Mexico","Nevada","New York","Ohio","Oklahoma","Oregon","Pennsylvania","Rhode Island","South Carolina","South Dakota","Tennessee","Texas","Utah","Virginia","Vermont","Washington","Wisconsin", "West Virginia","Wyoming"};
            DropDownList1.DataSource = stateArray;
            DropDownList1.DataBind();
            ListItem state = new ListItem("Select State");
            DropDownList1.Items.Insert(0, state);
            
        }
        //create user button event
        protected void Button1_Click(object sender, EventArgs e)
        {
            // When Add Button Clicked
            //message when the username is already taken
            if (checkMemberExists())
            {
                Message.Text = "Username already exists, try another username";
            }
            else
            {
                signUp();
                
            }
            
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            // When Update Button Clicked
            if (checkMemberExists())
            {
                updateUser();
                
            }
            else
            {
                Message.Text = "Username doesnot exist, first add user";
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            // When Delete Button Clicked
            if (checkMemberExists())
            {
                deleteUser();

            }
            else
            {
                Message.Text = "Username doesnot exist.";
            }
        }




        //user defined function 

        bool checkMemberExists()
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
                SqlCommand cmd = new SqlCommand("SELECT * from userTable WHERE username='"+TextBox5.Text.Trim()+ "';", con);
                //alternative way of database connectivity
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);//fill the data from the textbox 5 to data table dt

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
        void signUp()
        {

            //image upload
            string imagepath = "~/images/adduser.png";
            string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
            FileUpload1.SaveAs(Server.MapPath("images/" + filename));
            imagepath = "~/images/" + filename;

            //signUp new user with database connection
            try
            {
                //connection to sql server
                SqlConnection con = new SqlConnection(strcon);
                //if connection is closed; open
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO userTable (first_name,last_name,contact_number,dob,username,password,address_line,city,state,postal_code,full_address,role,department,salary,userimage) VALUES (@f_name,@l_name,@c_number,@dob,@username,@password,@address,@city,@state,@postal_code,@full_address,@role,@department,@salary,@userimage) ", con);

                cmd.Parameters.AddWithValue("@f_name", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@l_name", TextBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@c_number", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@dob", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@username", TextBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@password", TextBox6.Text.Trim());
                cmd.Parameters.AddWithValue("@address", TextBox7.Text.Trim());
                cmd.Parameters.AddWithValue("@city", TextBox8.Text.Trim());
                cmd.Parameters.AddWithValue("@state", DropDownList1.SelectedItem.Text);
                cmd.Parameters.AddWithValue("@postal_code", TextBox11.Text.Trim());
                cmd.Parameters.AddWithValue("@full_address", TextBox7.Text.Trim() + ',' + TextBox8.Text.Trim() +  ' ' + DropDownList1.SelectedItem.Text + ' ' + TextBox11.Text.Trim());
                cmd.Parameters.AddWithValue("@role", TextBox9.Text.Trim());
                cmd.Parameters.AddWithValue("@department", DropDownList2.SelectedItem.Text);
                cmd.Parameters.AddWithValue("@salary", TextBox10.Text.Trim());
                cmd.Parameters.AddWithValue("@userimage", imagepath);

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Successfully Created!');</script>");
                //Message.Text = "Successfully Created!" ;
                clearForm(this.Controls);
                DropDownList1.ClearSelection();
                DropDownList2.ClearSelection();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "'); </script>");
            }
        }

        void updateUser()
        {

            try
            {
                string imagepath = "~/images/adduser";
                string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
                //checkk if filename is blank or already has a file
                if(filename == "" || filename == null)
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
                    "role=@role," +
                    "department=@department," +
                    "salary=@salary," +
                    "userimage=@userimage" +
                    " WHERE username = '" +TextBox5.Text.Trim() +"'", con);

                cmd.Parameters.AddWithValue("@f_name", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@l_name", TextBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@c_number", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@dob", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@password", TextBox6.Text.Trim());
                cmd.Parameters.AddWithValue("@address", TextBox7.Text.Trim());
                cmd.Parameters.AddWithValue("@city", TextBox8.Text.Trim());
                cmd.Parameters.AddWithValue("@state", DropDownList1.SelectedItem.Text);
                cmd.Parameters.AddWithValue("@postal_code", TextBox11.Text.Trim());
                cmd.Parameters.AddWithValue("@full_address", TextBox7.Text.Trim() + ',' + TextBox8.Text.Trim() + ' ' + DropDownList1.SelectedItem.Text + ' ' + TextBox11.Text.Trim());
                cmd.Parameters.AddWithValue("@role", TextBox9.Text.Trim());
                cmd.Parameters.AddWithValue("@department", DropDownList2.SelectedItem.Text);
                cmd.Parameters.AddWithValue("@salary", TextBox10.Text.Trim());
                cmd.Parameters.AddWithValue("@userimage",imagepath);

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Successfully Updated.');</script>");
                //Message.Text = "Successfully Updated!";
                clearForm(this.Controls);
                DropDownList1.ClearSelection();
                DropDownList2.ClearSelection();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "'); </script>");
            }


        }

        void deleteUser()
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

                SqlCommand cmd = new SqlCommand("DELETE from userTable " +
                    " WHERE username = '" + TextBox5.Text.Trim() + "'", con);

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Successfully Deleted.');</script>");
                //Message.Text = "Successfully Deleted!";
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
            foreach(TextBox tb in controls.OfType<TextBox>())
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
                SqlCommand cmd = new SqlCommand("SELECT * from userTable WHERE username='" + TextBox5.Text.Trim() + "';", con);
                //alternative way of database connectivity
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
                    TextBox6.Text = dt.Rows[0][6].ToString().Trim();//password
                    TextBox7.Text = dt.Rows[0][7].ToString();//address
                    TextBox8.Text = dt.Rows[0][8].ToString();//city
                    DropDownList1.SelectedItem.Text = dt.Rows[0][9].ToString();//state
                    TextBox11.Text = dt.Rows[0][10].ToString();//postal code
                    TextBox12.Text = dt.Rows[0][11].ToString();//full address
                    TextBox9.Text = dt.Rows[0][12].ToString();//role
                    DropDownList2.SelectedItem.Text = dt.Rows[0][13].ToString();//department
                    TextBox10.Text = dt.Rows[0][14].ToString();//salary

                    global_imagepath = dt.Rows[0]["userimage"].ToString();
                    //userImage.ImageUrl = dt.Rows[0]["userimage"].ToString();
                }
                else
                {
                    Message.Text = "Invalid Username";
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "'); </script>");
                
            }
        }

        //Go Button
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            goButton();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList1.DataBind();
        }
    }
}