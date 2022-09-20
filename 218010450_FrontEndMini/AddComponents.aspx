<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="AddComponents.aspx.cs" Inherits="_218010450_FrontEndMini.AddComponents" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <form runat="server">
    <div class="content-wrapper">
            <!-- Content -->

            <div class="container-xxl flex-grow-1 container-p-y">
              <h4 class="fw-bold py-3 mb-4"><span class="text-muted fw-light">Admin/</span> Add Component</h4>

              <!-- Basic Layout -->
              <div class="row">
                <div class="col-xl">
                  <div class="card mb-4">
                    <div class="card-header d-flex justify-content-between align-items-center">
                      <h5 class="mb-0">Component</h5>
                      <small class="text-muted float-end">Default label</small>
                    </div>
                    <div class="card-body">
                      <form>
                        <div class="mb-3">
                          <label class="form-label" for="basic-default-fullname">Component Name</label>
                          <input type="text" runat="server" class="form-control" id="name" placeholder="Head Phones" />
                        </div>
                        <div class="mb-3">
                          <label class="form-label" for="basic-default-company">Brand Name</label>
                          <input type="text" runat="server" class="form-control" id="brand" placeholder="Samsung" />
                        </div>
                        <div class="mb-3">
                          <label class="form-label" for="basic-default-price">Price</label>
                          <div class="input-group input-group-merge">
                            <input
                              type="text"
                              id="price"
                              class="form-control"
                                runat="server"
                              placeholder="R100"
                              aria-label="john.doe"
                              aria-describedby="basic-default-email2"
                            />
                            <span class="input-group-text" id="basic-default-price"></span>
                          </div>
                         
                        </div>
                          <div class="mb-3">
                          <label class="form-label" for="basic-default-image">Component Image</label>
                          <%--<input type="file"  runat="server" class="form-control" id="image" placeholder="" />--%>
                              
                             
                             
                        </div>
                          
                           <asp:FileUpload ID="FileUpload1" class="form-control" runat="server" />

                        <div class="mb-3">
                          <label class="form-label" for="basic-default-fullname">Descripstion</label>
                          <input type="text" runat="server" class="form-control" id="descri" placeholder="Head Phones" />
                        </div>

                          <div class="mb-3 col-md-6">
                            <label class="form-label" for="country">Brand</label>
                            <select id="stat" runat="server" class="select2 form-select">
                              <option value="">Select</option>
                              <option value="Available">Available</option>
                              <option value="Not-Available">Not-Available</option>
                              <%--<option value="Belarus">Belarus</option>--%>                             
                            </select>
                          </div>

                        <%--<div class="mb-3">
                          <label class="form-label" for="basic-default-phone">Phone No</label>
                          <input
                            type="text"
                            id="basic-default-phone"
                            class="form-control phone-mask"
                            placeholder="658 799 8941"
                          />
                        </div>--%>
                        <%--<div class="mb-3">
                          <label class="form-label" for="basic-default-message">Message</label>
                          <textarea
                            id="basic-default-message"
                            class="form-control"
                            placeholder="Hi, Do you have a moment to talk Joe?"
                          ></textarea>
                        </div>--%>
                        <button type="submit" runat="server" onserverclick="addCompClicked" class="btn btn-primary">Add</button>
                           <asp:Label ID="error" runat="server" Visible="false"></asp:Label>
                      </form>
                    </div>
                  </div>
                </div>
                  </div>
                </div>
        </div>
        </form>


     <div class="col-lg-4 col-md-6">
                <small class="text-light fw-semibold">Default</small>
                      <div class="mt-3">
         

                        <button
                          type="button"
                          class="btn btn-primary"
                          data-bs-toggle="modal"
                          data-bs-target="#basicModal"
                          >
                          Launch modal
                        </button>

         <!-- Modal -->
                        <div class="modal fade" id="basicModal" tabindex="-1" aria-hidden="False">
                          <div class="modal-dialog" role="document">
                            <div class="modal-content">
                              <div class="modal-header">
                                <h5 class="modal-title" id="exampleModalLabel1">Modal title</h5>
                                <button
                                  type="button"
                                  class="btn-close"
                                  data-bs-dismiss="modal"
                                  aria-label="Close"
                                ></button>
                              </div>
                              <div class="modal-body">
                                <div class="row">
                                  <div class="col mb-3">
                                    <label for="nameBasic" class="form-label">Name</label>
                                    <input type="text" id="nameBasic" class="form-control" placeholder="Enter Name" />
                                  </div>
                                </div>
                                <div class="row g-2">
                                  <div class="col mb-0">
                                    <label for="emailBasic" class="form-label">Email</label>
                                    <input type="text" id="emailBasic" class="form-control" placeholder="xxxx@xxx.xx" />
                                  </div>
                                  <div class="col mb-0">
                                    <label for="dobBasic" class="form-label">DOB</label>
                                    <input type="text" id="dobBasic" class="form-control" placeholder="DD / MM / YY" />
                                  </div>
                                </div>
                              </div>
                              <div class="modal-footer">
                                <button type="button" class="btn btn-outline-secondary" data-bs-dismiss="modal">
                                  Close
                                </button>
                                <button type="button" class="btn btn-primary">Save changes</button>
                              </div>
                            </div>
                          </div>
                        </div>
                      </div>
                    </div>

</asp:Content>
