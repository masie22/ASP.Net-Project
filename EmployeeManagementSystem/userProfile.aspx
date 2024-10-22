<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="userProfile.aspx.cs" Inherits="EmployeeManagementSystem.userProfile" %>
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
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-5">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                        <asp:Image ID="userImage" width="100px" style="border-radius:50px;"  runat="server"></asp:Image>
                                    <%-- <img id="userImage" width="100px" style="border-radius:50px;" src="images/adduser.png" /> --%>
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                   <h4>My Profile</h4>
                                </center>
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
                                    <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" TextMode="Date"></asp:TextBox>              
                                </div>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-6">
                                <label> Address Line </label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox7" runat="server" placeholder=" Address Line"></asp:TextBox>              
                                </div>
                            </div>
                            <div class="col-md-6">
                                <label> City </label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox8" runat="server" placeholder="City"></asp:TextBox>              
                                </div>
                            </div>
                            </div>
                        <div class="row">
                            <div class="col-md-6">
                                <label> State </label>
                                <div class="form-group">
                                    <asp:DropDownList  class="form-control" ID="DropDownList1" runat="server" AppendDataBoundItems="True">
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <label> Postal Code </label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox11" runat="server" placeholder="Postal Code"></asp:TextBox>
                                </div>
                            </div>
                        </div>                      
                       <div class="row">
                           <div class="col-md-6">   
                               <label> Upload Picture </label>
                                <div class="form-group">
                                    <asp:FileUpload ID="FileUpload1" placeholder="Upload Picture" runat="server" />           
                                </div> 
                            </div>
                        </div>
                      
                       
                       <div class="row">
                            <div class="col-md-4">
                                <label> User ID </label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox5" runat="server" placeholder=" User ID" ReadOnly="True"></asp:TextBox>              
                                </div>
                            </div>
                            <div class="col-md-4">
                                <label> Password </label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox6" runat="server" placeholder="Old Password" ReadOnly="True"></asp:TextBox>              
                                </div>
                            </div>
                            <div class="col-md-4">
                                <label> New Password </label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox9" runat="server" placeholder="New Password" TextMode="Password" AutoPostBack="True"></asp:TextBox>              
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-4">      
                                <div class="form-group">
                                    <asp:Button class="btn btn-primary btn-md" ID="UpdateBtn" runat="server" Text="Update" OnClick="UpdateBtn_Click" />             
                                </div> 
                            </div>
                        </div>
                  </div>
                </div>
            </div>
            <div class="col-md-7">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img width="100px" src="images/projectlist.png" />
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                   <h4> Working Projects </h4>
                                </center>
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
                            <div class="col">
                                <asp:GridView class="table table-striped compact order-column" ID="GridView1" runat="server" onrowdatabound="GridView1_RowDataBound"></asp:GridView>
                                <center><asp:Label ID="emptyGrid" runat="server" Font-Italic="True" ForeColor="#999999"></asp:Label> </center>
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
