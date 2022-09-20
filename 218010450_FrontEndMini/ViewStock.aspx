<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="ViewStock.aspx.cs" Inherits="_218010450_FrontEndMini.ViewStock" %>



<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div class="card">
                <h5 class="card-header">List of Stocks</h5>
                <div class="table-responsive text-nowrap">
                  <table class="table table-striped">
                    <thead class="table-dark">
                      <tr>
                        
                        <th>Stock Name</th>
                        <th>Description</th>
                        <th>#</th>
                        <th>Price</th>
                        <th>Available </th>
                        <th>OnSpecial </th>
                        <th>Sold</th>
                        <th>Capacity</th>
                        

                      </tr>
                    </thead>
                    <tbody class="table-border-bottom-0">
                     

                          <div class="row" id="treport" runat="server"></div>

                        <%--<td><i class="fab fa-angular fa-lg text-danger me-3"></i> <strong>Angular Project</strong></td>
                        <td>Albert Cook</td>
                        <td>
                          <ul class="list-unstyled users-list m-0 avatar-group d-flex align-items-center">
                            <li
                              data-bs-toggle="tooltip"
                              data-popup="tooltip-custom"
                              data-bs-placement="top"
                              class="avatar avatar-xs pull-up"
                              title="Lilian Fuller"
                            >
                              <img src="../assets/img/avatars/5.png" alt="Avatar" class="rounded-circle" />
                            </li>
                            
                          </ul>
                        </td>
                        <td><span class="badge bg-label-primary me-1">price</span></td>
                        <td>
                          <span class="badge bg-primary">5</span>
                        </td>
                        <td>
                           <span class="badge bg-success">2</span>
                        </td>
                          <td>
                           <span class="badge bg-success">2</span>
                        </td>
                          <td>
                          <a type="button" class="btn btn-outline-primary">
                              Max
                              <span class="badge bg-secondary rounded-pill">4</span>
                            </a>
                        </td>  --%>                      
                                          
                    </tbody>
                  </table>
                </div>
              </div>
</asp:Content>
