<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Shop.aspx.cs" Inherits="_218010450_FrontEndMini.Shop" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <%--<section class="module bg-dark-60 shop-page-header" >
        </section>--%>
        <%--<section class="module-small">
          <div class="container">
            <form class="row">
              <div class="col-sm-4 mb-sm-20">
                <select class="form-control">
                  <option selected="selected">Default Sorting</option>
                  <option>Popular</option>
                  <option>Latest</option>
                  <option>Average Price</option>
                  <option>High Price</option>
                  <option>Low Price</option>
                </select>
              </div>
              <div class="col-sm-2 mb-sm-20">
                <select class="form-control">
                  <option selected="selected">Woman</option>
                  <option>Man</option>
                </select>
              </div>
              <div class="col-sm-3 mb-sm-20">
                <select class="form-control">
                  <option selected="selected">All</option>
                  <option>Coats</option>
                  <option>Jackets</option>
                  <option>Dresses</option>
                  <option>Jumpsuits</option>
                  <option>Tops</option>
                  <option>Trousers</option>
                </select>
              </div>
              <div class="col-sm-3">
                <button class="btn btn-block btn-round btn-g" type="submit">Apply</button>
              </div>
            </form>
          </div>
        </section>--%>
        <hr class="divider-w">
        <section class="module-small">
          <div class="container">
            <div class="row multi-columns-row">

              <div class="row" id="treport" runat="server"></div>
              
            <%--<div class="row">
              <div class="col-sm-12">
                <div class="pagination font-alt"><a href="#"><i class="fa fa-angle-left"></i></a><a class="active" href="#">1</a><a href="#">2</a><a href="#">3</a><a href="#">4</a><a href="#"><i class="fa fa-angle-right"></i></a></div>
              </div>
            </div>--%>
          </div>
        </section>


</asp:Content>
