<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="fillTimesheet.aspx.cs" Inherits="EmployeeManagementSystem.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-12">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <asp:Image ID="userImage" width="100px" style="border-radius:50px;"  runat="server" src="images/payTime.png"></asp:Image>                                    
                                </center>
                            </div>
                        </div>
                         <div class="row">
                            <div class="col">
                                <center>
                                   <h4>Fill Timesheet again and again</h4>
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
                        <div id="repeatRow">
                        <div class="row">
                            <div class="col-md-2">
                                <label> Date </label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="DateTextBox" runat="server" Textmode="Date" OnTextChanged="Date_TextChanged" AutoPostBack="True"></asp:TextBox>   
                                </div>
                            </div>
                            <div class="col-md-2">
                                <label> Day </label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="DayTextBox" runat="server" placeholder="Day" AutoPostBack="True" ReadOnly="True"></asp:TextBox>              
                                </div>
                            </div>
                            <div class="col-md-2">
                                <label> Time In </label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TimeIn" runat="server" placeholder="Time In" Textmode="Time" OnTextChanged="TimeIn_TextChanged"></asp:TextBox>              
                                </div>
                            </div>
                            <div class="col-md-2">
                                <label> Time Out </label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TimeOut" runat="server" placeholder="Time Out" Textmode="Time" OnTextChanged="TimeOut_TextChanged" AutoPostBack="True"></asp:TextBox>              
                                </div>
                            </div>
                            <div class="col-md-2">
                                <label> Hours Worked </label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="HoursWorked" runat="server" placeholder="Hours Worked" AutoPostBack="true" ReadOnly="True"></asp:TextBox>              
                                </div>
                            </div>
                            <div class="col-md-2">
                                <label>  </label>
                                <div class="form-group">
                                    <asp:Button class="btn btn-primary mt-4" ID="SaveTime" runat="server" Text="Save" OnClick="SaveTime_Click" />                                    
                                </div>
                            </div>
                        </div>
                      </div>

                        <asp:Button ID="repeatForm" runat="server" Text="+" OnClick="repeatForm_Click" />
                        
                        <div class ="row">
                            <div class ="col">
                                <h6>To proceed with your timesheet submission, <asp:LinkButton ID="ReviewTimesheetBtn" runat="server" OnClick="ReviewTimesheetBtn_Click"> Review your timesheet here.</asp:LinkButton> </h6> 
                            </div>
                        </div>
                      </div>
                  </div>
                </div>
            </div>
        </div>
</asp:Content>
