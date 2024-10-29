<%@ Page Title="" Language="C#" MasterPageFile="~/signIn.Master" AutoEventWireup="true" CodeBehind="userLogin.aspx.cs" Inherits="EmployeeManagementSystem.userLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <div class="container">
        <div class="row">
            <div class="col-md-6 mx-auto">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img width="150px" src="images/loginuser.png" />
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                   <h3>Login</h3>
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
                                <label> User ID <i class="fas fa-user"></i> </label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="User ID"></asp:TextBox>              
                                </div>
                                <label> Password <i class="fas fa-key"></i> </label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>              
                                </div>
                                <label> Remember Me</label>                             
                                    <asp:CheckBox ID="RememberBox" runat="server" />         
                                <div class="form-group">
                                    <asp:Button class="btn btn-primary btn-block btn-lg" ID="Button1" runat="server" Text="Log In" OnClick="Button1_Click" />             
                                </div> 
                                <center> <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Forgot Password?</asp:LinkButton></center>  
                                 <center><asp:Label ID="Message" runat="server" ForeColor="Red"></asp:Label></center>                               
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
