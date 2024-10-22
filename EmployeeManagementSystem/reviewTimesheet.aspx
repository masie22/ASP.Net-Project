<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="reviewTimesheet.aspx.cs" Inherits="EmployeeManagementSystem.reviewTimesheet" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <script>
        $(document).ready(function () {
            $('.table').prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
        });
        </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <div class="container">
        <div class="row">
             <div class="col-md-12 mx-auto">
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
                                   <h4>Review Timesheet</h4>
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
                                <asp:GridView class="table table-striped compact order-column" ID="timesheetGrid" runat="server" AutoGenerateColumns="False">
                                    <Columns>
                                        <asp:BoundField DataField="username" HeaderText="Username" />
                                        <asp:BoundField DataField="date" HeaderText="Date" />
                                        <asp:BoundField DataField="time_in" HeaderText="Time In" />
                                        <asp:BoundField DataField="time_out" HeaderText="Time Out" />
                                        <asp:BoundField DataField="hours_worked" HeaderText="Hours worked" />
                                        <asp:BoundField DataField="cumulative_hours" HeaderText="Cumulative Hours" />

                                    </Columns>
                                </asp:GridView>
                                <center><asp:Label ID="emptyGrid" runat="server" Font-Italic="True" ForeColor="#999999"></asp:Label> </center>
                            </div>
                        </div> 
                        <div class="row">
                            <div class="col">
                                <center>
                                   <hr>
                                </center>
                            </div>
                        </div> 
                        <div class="card" id="CardHide" runat="server">
                             <div class="card-header">
                                Earning Distribution
                            </div>
                            <div class="card-body">
                                <h5 class="card-title">Working Summary</h5>
                                <p class="card-text">Your Total Worked Hours: <asp:Label ID="CumulativeHoursLabel" runat="server" Text="Label"></asp:Label> Hours </p>
                                <p class="card-text">Your Pay Rate per Hour: $<asp:Label ID="PerHourRateLabel" runat="server" Text="Label"></asp:Label></p>
                                <p class="card-text">Your Total Earnings: $<asp:Label ID="TotalEarningLabel" runat="server" Text="Label"></asp:Label></p>
                                <asp:Button ID="SubmitBtn" class="btn btn-primary" runat="server" Text="Submit" OnClick="SubmitBtn_Click" />
                             </div>
                       </div>
                        <div>
                            <center>
                                <asp:Label ID="SubmitLabel" runat="server" Text="Label" ForeColor="#00CC66" Font-Italic="True" Visible="False"></asp:Label>
                            </center>                         
                        </div>                       
                  </div>
                </div>                
            </div>
        </div>
    </div>
</asp:Content>
