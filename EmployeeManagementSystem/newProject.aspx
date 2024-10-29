<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="newProject.aspx.cs" Inherits="EmployeeManagementSystem.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
           <script>
             $(document).ready(function () {
            $('.table').prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
            });
           </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    
    <div class="container">
        <div class="row">
            <div class="col-md-8 mx-auto">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img width="100px" src="images/newproject.png" />
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                   <h4>Add New Project Details</h4>
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
                                <label> Project ID </label>
                                <div class="form-group">
                                    <div class="input-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="Project ID"></asp:TextBox>  
                                    <asp:LinkButton class="btn btn-info" ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Go</asp:LinkButton>  
                                </div>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <label> Project Name </label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" placeholder="Project Name"></asp:TextBox>              
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-6">
                                <label> Associated Company </label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Company Name"></asp:TextBox>              
                                </div>
                            </div>
                            <div class="col-md-6">
                                <label> Contact Number </label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox9" runat="server" placeholder="Contact Number"></asp:TextBox>              
                                </div>
                            </div>
                            
                        </div>
                        <div class="row">
                            <div class="col-md-4">
                                <label> Start Date </label>
                                <div class="form-group">
                                    <asp:TextBox Class="form-control" ID="TextBox2" runat="server" TextMode="Date"></asp:TextBox>              
                                </div>
                            </div>
                            <div class="col-md-4">
                                <label> End Date </label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox5" runat="server" placeholder="End Date" TextMode="Date"></asp:TextBox>              
                                </div>
                            </div>
                            <div class="col-md-4">
                                <label> Status </label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox6" runat="server" placeholder="Status" ReadOnly="True" AutoPostBack="True"></asp:TextBox>
                                    <%-- <asp:DropDownList Class="form-control" ID="DropDownList2" runat="server">
                                        <asp:ListItem Value="0" Text="--Select Status--"></asp:ListItem>
                                        <asp:ListItem> Upcoming</asp:ListItem>
                                        <asp:ListItem> Pending</asp:ListItem>
                                        <asp:ListItem> Completed</asp:ListItem>
                                    </asp:DropDownList> --%>
                                     
                                                 
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-4">
                                <label> Project Manager </label>
                                <div class="form-group">
                                    <asp:DropDownList class="form-control" ID="DropDownList1" runat="server" placeholder="Project Manager" AppendDataBoundItems="true" DataSourceID="SqlDataSource2" DataTextField="staff_name" DataValueField="staff_name"> 
                                        <asp:ListItem Value="0" Text="--Select Manager--"></asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:emsystemDBConnectionString4 %>" SelectCommand="SELECT [staff_name] FROM [userTable]"></asp:SqlDataSource>           
                                </div>
                            </div>
                            <div class="col-md-4">
                                <label> Budget Allocated </label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox8" runat="server" placeholder="USD"></asp:TextBox>              
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-4">      
                                <div class="form-group">
                                    <asp:Button class="btn btn-primary btn-block btn-md" ID="Button1" runat="server" Text="Add" OnClick="Button1_Click"/>             
                                </div> 
                            </div>
                            <div class="col-md-4">      
                                <div class="form-group">
                                    <asp:Button class="btn btn-success btn-block btn-md" ID="Button2" runat="server" Text="Update" OnClick="Button2_Click"/>             
                                </div> 
                            </div>
                            <div class="col-md-4">      
                                <div class="form-group">
                                    <asp:Button class="btn btn-danger btn-block btn-md" ID="Button3" runat="server" Text="Delete" OnClick="Button3_Click"/>             
                                </div> 
                            </div>
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
                                   <h4>Project Details</h4>
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
                         <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:emsystemDBConnectionString3 %>" SelectCommand="SELECT * FROM [projectTable]"></asp:SqlDataSource>
                    <div class="col-md-12 mx-auto">
                         <asp:GridView class="table table-striped table-bordered compact hover" style="width:100%" ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Project_ID" DataSourceID="SqlDataSource1">
                             <Columns>
                                 <asp:BoundField DataField="Project_ID" HeaderText="Project ID" ReadOnly="True" SortExpression="Project_ID" />
                                 <asp:BoundField DataField="Project_Name" HeaderText="Project Name" SortExpression="Project_Name" />
                                 <asp:BoundField DataField="Associated_Company" HeaderText="Associated Company" SortExpression="Associated_Company" />
                                 <asp:BoundField DataField="Contact" HeaderText="Contact" SortExpression="Contact" />
                                 <asp:BoundField DataField="Start_Date" HeaderText="Start Date" SortExpression="Start_Date" />
                                 <asp:BoundField DataField="End_Date" HeaderText="End Date" SortExpression="End_Date" />
                                 <asp:BoundField DataField="staff_name" HeaderText="Associated Staff" SortExpression="staff_name" />
                                 <asp:BoundField DataField="Budget" HeaderText="Budget" SortExpression="Budget" />
                                 <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
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
