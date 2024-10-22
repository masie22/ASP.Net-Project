<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="homePage.aspx.cs" Inherits="EmployeeManagementSystem.homePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--creating cards-->
    <div>
        <asp:Label class="p-3" ID="GreetingLabel" runat="server" Text="Date"></asp:Label>
    </div>
    

    <div class="container-fluid py-4">
        <div class="row">
            <div class="col-sm-4">
                <div class="card">
                    <div class="card-body">
                        <div class="d-flex justify-content-between">
                            <i class="fas fa-layer-group fa-3x info"></i>
                            <div class="text-right text-secondary">
                            <h5>Projects completed</h5>
                            <h3>5</h3>
                            </div>
                        </div>
                    </div>
             </div>
         </div>
         <div class="col-sm-4">
                <div class="card">
                    <div class="card-body">
                        <div class="d-flex justify-content-between">
                            <i class="fas fa-user fa-3x info"></i>
                            <div class="text-right text-secondary">
                            <h5>Employees</h5>
                            <h3>12</h3>
                            </div>
                        </div>
                    </div>
             </div>
         </div>
        <div class="col-sm-4">
                <div class="card">
                    <div class="card-body">
                        <div class="d-flex justify-content-between">
                            <i class="fas fa-hand-holding-usd fa-3x info"></i>
                            <div class="text-right text-secondary">
                            <h5>Budget</h5>
                            <h3>$120000</h3>
                            </div>
                        </div>
                    </div>
             </div>
         </div>
    </div>
</div>

<!--creating tables for data-->
<div>
    <div class="container-fluid py-4">
        <div class="row">
            <div class="col-12">
                <h3 class="text-muted text-center md-3">Staff Salary </h3>
                <table class ="table table-striped table-hover bg-light text-center" data-pagination="true" data-page-size="12">
                    <thead>
                        <tr class="text-muted">
                            <th>#</th>
                            <th>Name</th>
                            <th>Salary</th>
                            <th>Contact</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>1</td>
                            <td>Taylor</td>
                            <td>$215000</td>
                            <td><button type="button" class="btn btn-info btn-sm">Message</button></td>
                        </tr>
                        <tr>
                            <td>2</td>
                            <td>Taylor</td>
                            <td>$215000</td>
                            <td><button type="button" class="btn btn-info btn-sm">Message</button></td>
                        </tr>
                        <tr>
                            <td>3</td>
                            <td>or</td>
                            <td>$215000</td>
                            <td><button type="button" class="btn btn-info btn-sm">Message</button></td>
                        </tr>
                        <tr>
                            <td>4</td>
                            <td>lor</td>
                            <td>$215000</td>
                            <td><button type="button" class="btn btn-info btn-sm">Message</button></td>
                        </tr>
                        <tr>
                            <td>5</td>
                            <td>ylor</td>
                            <td>$215000</td>
                            <td><button type="button" class="btn btn-info btn-sm">Message</button></td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
</div>

<!--pagination-->
<nav>
    <ul class="pagination justify-content-center">
        <li class="page-item">
            <a href="#" class="page-link py-2 px-3">
            <span>&laquo;</span>
            </a>
        </li>
        <li class="page-item active">
            <a href="#" class="page-link py-2 px-3">1
            </a>
        </li>
        <li class="page-item">
            <a href="#" class="page-link py-2 px-3">2
            </a>
        </li>
        <li class="page-item">
            <a href="#" class="page-link py-2 px-3">
            <span>&raquo;</span>
            </a>
        </li>

    </ul>
</nav>
<!--creating progress bars-->
<div class="container-fluid py-4">
   <div class="row align-items-center">
        <div class="col-xl-6 col-12"> <!-- in order to make them sit side to side-->
                       <div>
                        <h4 class="mb-5"> Conversion Rates</h4>
                        <h6 class="mb-3"> Google Chrome</h6>
                        <div class="progress mb-4" style="height:20px">
                            <div class="progress-bar progress-bar-striped font-weight-bold font-weight-bold font-weight-bold bg-success" style="width:91%"> 91% </div>
                        </div>
                        <h6 class="mb-3"> Firefox</h6>
                        <div class="progress mb-4" style="height:20px">
                            <div class="progress-bar progress-bar-striped font-weight-bold" style="width:82%"> 82% </div>
                        </div>
                        <h6 class="mb-3"> Safari </h6>
                        <div class="progress mb-4" style="height:20px">
                            <div class="progress-bar progress-bar-striped font-weight-bold font-weight-bold bg-info" style="width:67%"> 67% </div>
                        </div>
                        <h6 class="mb-3"> IE </h6>
                        <div class="progress mb-4" style="height:20px">
                            <div class="progress-bar progress-bar-striped font-weight-bold font-weight-bold bg-danger" style="width:12%"> 12% </div>
                        </div>
                    </div>
                  </div>
<!-- creating task item-->

<div class="col-lg-6">
    <h4 class="p-3 mb-3">Tasks</h4>
    <div class="container bg-white">
        <div class="row py-3 mb-4">
            <div class="col-1">
                <input type="checkbox" checked />
            </div>
            <div class="col-sm-9 col-8">
                hello hi bye bye.
            </div>
            <div class="col-1">
                <a href="#" data-toggle="tooltip" title="edit"><i class="fas fa-edit fa-lg text-success mr-2"></i> </a>
            </div>
            <div class="col-1">
                <a href="#" data-toggle="tooltip" title="delete"><i class="fas fa-trash-alt fa-lg text-danger mr-2"></i> </a>
            </div>
         </div>
      </div>
            <div class="container-fluid bg-white">
        <div class="row py-3 mb-4">
            <div class="col-1">
                <input type="checkbox" checked />
            </div>
            <div class="col-sm-9 col-8">
                hello hi bye bye.
            </div>
            <div class="col-1">
                <a href="#" data-toggle="tooltip" title="edit"><i class="fas fa-edit fa-lg text-success mr-2"></i> </a>
            </div>
            <div class="col-1">
                <a href="#" data-toggle="tooltip" title="delete"><i class="fas fa-trash-alt fa-lg text-danger mr-2"></i> </a>
            </div>
         </div>
      </div>
        <div class="container-fluid bg-white">
        <div class="row py-3 mb-4">
            <div class="col-1">
                <input type="checkbox" checked />
            </div>
            <div class="col-sm-9 col-8">
                hello hi bye bye.
            </div>
            <div class="col-1">
                <a href="#" data-toggle="tooltip" title="edit"><i class="fas fa-edit fa-lg text-success mr-2"></i> </a>
            </div>
            <div class="col-1">
                <a href="#" data-toggle="tooltip" title="delete"><i class="fas fa-trash-alt fa-lg text-danger mr-2"></i> </a>
            </div>
         </div>
      </div>
        <div class="container-fluid bg-white">
        <div class="row py-3 mb-4">
            <div class="col-1">
                <input type="checkbox" checked />
            </div>
            <div class="col-sm-9 col-8">
                hello hi bye bye.
            </div>
            <div class="col-1">
                <a href="#" data-toggle="tooltip" title="edit"><i class="fas fa-edit fa-lg text-success mr-2"></i> </a>
            </div>
            <div class="col-1">
                <a href="#" data-toggle="tooltip" title="delete"><i class="fas fa-trash-alt fa-lg text-danger mr-2"></i> </a>
            </div>
         </div>
      </div>
        </div>
    </div>
</div>
        

<!-- activities/ quick post-->

    <section>
        <div class="container-fluid">
            <div class="row">
                        <div class="col-12">
                            <h4 class="text-muted mb-4">Recent Customer</h4>
                                <div id="accordion">
                                    <div class="card">
                                        <div class="card-header">
                                            <button class="btn btn-block bg-secondary text-light text-left" type="button" data-toggle="collapse" data-target="#collapseOne" aria-expanded="false" aria-controls="collapseOne">
                                                  <img src="images/sponge.png" width="30" class="mr-3 rounded"/>
                                                Sponge posted a new comment
                                            </button>
                                        </div>
                                        <div class="collapse" id="collapseOne" data-parent="#accordion">
                                            <div class="card-body">
                                                Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. 
                                                Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure
                                            </div>
                                        </div>
                                    </div>
                                    <div class="card">
                                        <div class="card-header">
                                            <button class="btn btn-block bg-secondary text-light text-left" type="button" data-toggle="collapse" data-target="#collapseTwo">
                                                <img src="images/btman.png" width="30" class="mr-3 rounded"/>
                                                Batman posted a new comment
                                            </button>
                                        </div>
                                        <div class="collapse" id="collapseTwo" data-parent="#accordion">
                                            <div class="card-body">
                                                Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam,
                                                quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure
                                            </div>
                                        </div>
                                    </div>
                                </div>
                        </div>
                    </div>
                </div>
    </section>


</asp:Content>
