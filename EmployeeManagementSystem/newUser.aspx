<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="newUser.aspx.cs" Inherits="EmployeeManagementSystem.newUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <script>
        $(document).ready(function () {
            $('.table').prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
        });

        //image of user 
        function readimageURL(input) {
            if (input.files && input.files[0]) {
                var reader = new FileReader();//file reading javascript
                //using onload event for userImages
                reader.onload = function (e) {
                    $('#userImage').attr('src', e.target.result);
                };
                reader.readAsDataURL(input.files[0]);
            }
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    
    <div class="container">
        <div class="row">
            <div class="col-md-8 mx-auto">
                <div class="card">
                    <div class="card-body" font-bold="True">
                        <div class="row">
                            <div class="col">
                                <center>
                                        <img ID="userImage" width="100px" style="border-radius:50px;" src="images/adduser.png" />        
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                   <h4>Add New User</h4>
                                </center>
                            </div>
                        </div>
                        <div class="row">
                                <div class="col-md-12"> 
                                    <center><asp:Label ID="Message" runat="server" ForeColor="#00CC00" Font-Bold="True" Font-Size="18"></asp:Label></center>
                                </div>
                            </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                   <hr>
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-6">
                                <label> First Name </label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="First Name"></asp:TextBox>              
                                </div>
                            </div>
                            <div class="col-md-6">
                                <label> Last Name </label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" placeholder="Last Name"></asp:TextBox>              
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-6">
                                <label> Contact Number </label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Contact Number"></asp:TextBox>              
                                </div>
                            </div>
                            <div class="col-md-6">
                                <label> Date Of Birth </label>
                                <div class="form-group">                                   
                                    <asp:TextBox Class="form-control" ID="TextBox2" runat="server" placeholder="dob" TextMode="Date"></asp:TextBox>              
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-6">
                                <label> User ID </label>
                                <div class="form-group">
                                    <div class="input-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox5" runat="server" placeholder="Username"></asp:TextBox>  
                                    <asp:LinkButton class="btn btn-info" ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Go</asp:LinkButton>  
                                        </div>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <label> Password </label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox6" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>              
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-4">
                                <label> Address Line </label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox7" runat="server" placeholder=" Address Line"></asp:TextBox>              
                                </div>
                            </div>
                            <div class="col-md-3">
                                <label> City </label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox8" runat="server" placeholder="City"></asp:TextBox>              
                                </div>
                            </div>
                            <div class="col-md-3">
                                <label> State </label>
                                <div class="form-group">
                                    <asp:DropDownList  class="form-control" ID="DropDownList1" runat="server" AppendDataBoundItems="True" AutoPostBack="True">
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div class="col-md-2">
                                <label> Postal Code </label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox11" runat="server" placeholder="Postal Code"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                      <div class="row">
                            <div class="col-md-12">
                                <label> Full Address </label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" ID="TextBox12" runat="server" placeholder="Full Address" ReadOnly="True"></asp:TextBox>              
                                </div>
                            </div>
                        </div>
                          <div class="row">
                            <div class="col-md-4">
                                <label> Role </label>
                                <div class="form-group">
                                    <asp:TextBox class="form-control" ID="TextBox9" runat="server" placeholder=" Role"></asp:TextBox>              
                                </div>
                            </div>
                            <div class="col-md-4">
                                <label> Department </label>
                                <div class="form-group">
                                    <asp:DropDownList  class="form-control" ID="DropDownList2" runat="server">
                                        <asp:ListItem Value="0" Text="--Select Department--"></asp:ListItem>
                                        <asp:ListItem Text="Admin" />
                                        <asp:ListItem Text="Accounts and Finance" Value="Accounts and Finance" />
                                        <asp:ListItem Text="HR" Value="HR" />
                                        <asp:ListItem Text="IT Services" Value="IT" />
                                        <asp:ListItem Text="Marketing" Value="Marketing" />
                                        <asp:ListItem Text="Product Development" Value="Product Development" />
                                        <asp:ListItem Text="Sales" Value="Sales" />                                      
                                   </asp:DropDownList>
                                </div>
                            </div>
                             <div class="col-md-4">
                                <label> Monthly Pay </label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox10" runat="server" placeholder="Monthly Pay"></asp:TextBox>              
                                </div>
                            </div>
                        </div>
                       <div class="row">
                           <div class="col-md-6">   
                               <label> Upload Picture </label>
                                <div class="form-group">
                                    <asp:FileUpload onchange="readimageURL(this);" ID="FileUpload1" runat="server" />           
                                </div> 
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-4">      
                                <div class="form-group">
                                    <asp:Button class="btn btn-primary btn-block btn-md" ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />             
                                </div> 
                            </div>
                            <div class="col-md-4">      
                                <div class="form-group">
                                    <asp:Button class="btn btn-success btn-block btn-md" ID="Button2" runat="server" Text="Update" OnClick="Button2_Click" />             
                                </div> 
                            </div>
                            <div class="col-md-4">      
                                <div class="form-group">
                                    <asp:Button class="btn btn-danger btn-block btn-md" ID="Button3" runat="server" Text="Delete" OnClick="Button3_Click" />             
                                </div> 
                            </div>
                        </div>
                        <div>
                            
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <br />
    <br />

    <div class="container-fluid">
        <div class="row">
             <div class="col-md-12 mx-auto">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col-md-12 mx-auto">
                                <center>
                                   <h4>User Details</h4>
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-12 mx-auto">
                                <center>
                                   <hr>
                                </center>
                            </div>
                        </div>
                <div class="row">
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:emsystemDBConnectionString %>" SelectCommand="SELECT * FROM [userTable]"></asp:SqlDataSource>
                     <div class="col-md-12 mx-auto">
                        <asp:GridView class="table table-striped table-bordered compact hover" style="width:100%" ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
                            <Columns>
                                <asp:BoundField DataField="staff_name" HeaderText="Name" SortExpression="staff_name" />
                                <asp:BoundField DataField="contact_number" HeaderText="Contact" SortExpression="contact_number" />
                                <asp:BoundField DataField="full_address" HeaderText="Address" />
                                <asp:BoundField DataField="dob" HeaderText="DOB" SortExpression="dob" />
                                <asp:BoundField DataField="username" HeaderText="Username" SortExpression="username" />
                                <asp:BoundField DataField="password" HeaderText="Password" SortExpression="password" />
                                <asp:BoundField DataField="role" HeaderText="Role" SortExpression="role" />
                                <asp:BoundField DataField="department" HeaderText="Department" SortExpression="department" />
                                <asp:BoundField DataField="salary" HeaderText="Salary" SortExpression="salary" />
                            </Columns>
                         </asp:GridView>
                     </div>
                </div>
                </div>
            </div>
        </div>
    </div>
        </div>
    
    <br />
    <br />

</asp:Content>
