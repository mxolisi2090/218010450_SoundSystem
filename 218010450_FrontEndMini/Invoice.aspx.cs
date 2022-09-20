using _218010450_FrontEndMini.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _218010450_FrontEndMini
{
    public partial class Invoice : System.Web.UI.Page
    {
        private readonly System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            var UserID = Session["LoggedInUserID"];
            var oderId = Request.QueryString["orderId"];
            var OrderTotal = Request.QueryString["Total"];

            HttpResponseMessage feature = client.GetAsync("https://localhost:44311/api/Orders?itemID=" + oderId).Result;
            var Comp = feature.Content.ReadAsAsync<Order>().Result;

            HttpResponseMessage user = client.GetAsync("https://localhost:44311/api/User?userId=" + Comp.OrderUserId).Result;
            var omp = user.Content.ReadAsAsync<User>().Result;


            HttpResponseMessage comp = client.GetAsync("https://localhost:44311/api/OrderItems?UserId="+ UserID + "&orderId=" + oderId).Result;
            var zomp = comp.Content.ReadAsAsync<List<OrderItem>>().Result;
            
            ArrayList names = new ArrayList();

            names = (ArrayList)Session["SessionNames"];

            //int val = 0;
            List<string> cartItems = new List<string>();

            string val = "";

            string display = "";

            display += "<div class='container'>";
            display += "";
            display += "<div class='brand-section'>";
            display += "<div class='row'>";
            display += "<div class='col-6'>";    
            display += "<h1 class='text-white'>Stomzy Sound Electronics Invoice</h1>";        
            display += "</div>";    
            display += "<div class='col-6'>";    
            display += "<div class='company-details'>";        
            display += "<p class='text-white'><strong>Stomzy Soound Electronics</strong></p>";            
            display += "<p class='text-white'><strong>Stomzy Soound Electronics@Gmail.com</strong></p>";            
            display += "<p class='text-white'><strong>+27 6207 94750</strong></p>";            
            display += "</div>";        
            display += "</div>";   
            display += "</div>";
            display += "</div>";

            display += "<div class='body-section'>";
            display += "<div class='row'>";
            display += "<div class='col-6'>";    
            display += "<h2 class='heading'><strong>Invoice No. : " + Comp.OrderId+ "</strong></h2>";        
            display += "<p class='sub-heading'><strong>Tracking No.fabcart2025</strong></p>";        
            display += "<p class='sub-heading'><strong>Order Date : " + Comp.Date+ "</strong></p>";        
            display += "<p class='sub-heading'><strong>Email Address : " + omp.Email+ "</strong></p>";        
            display += "</div>";    
            display += "<div class='col-6'>";    
            display += "<p class='sub-heading'><strong>Full Name : " + omp.Name+ "  </strong></p>";        
            display += "<p class='sub-heading'><strong>Address : " + omp.Address+ " </strong></p>";        
            display += "<p class='sub-heading'><strong>Phone Number : " + omp.PhoneNuber+ "  </strong></p>";        
            //display += "<p class='sub-heading'>City,State,Pincode:  </p>";        
            display += "</div>";    
            display += "</div>";
            display += "</div>";

           display += "<div class='body-section'>";
           display += "<h3 class='heading'>Ordered Items</h3>";  
           display += "<br>"; 
           display += "<table class='table-bordered'>"; 
           display += "<thead>";     
           display += "<tr>";         
           display += "<th>Product</th>";             
           display += "<th class='w-20'>Price</th>";             
           display += "<th class='w-20'>Quantity</th>";             
           display += "<th class='w-20'>Grandtotal</th>";             
           display += "</tr>";        
           display += "</thead>";     
           display += "<tbody>";

            foreach (var a in zomp)
            {
                HttpResponseMessage zoo = client.GetAsync("https://localhost:44311/api/Components?itemID=" +a.ItemId).Result;
                var world = zoo.Content.ReadAsAsync<Component>().Result;
                
                display += "<tr>";
                display += "<td>"+ world.Name.ToUpper() + "</td>";
                display += "<td>R"+ world.Price + "</td>";
                display += "<td></td>";
                display += "<td>R"+ OrderTotal + "</td>";
                display += "</tr>";
            }
           
            
           display += " <tr>";        
           display += "<td colspan='3' class='text-right'>Sub Total</td>";             
           display += "<td> 10.XX</td>";             
           display += "</tr>";         
           display += "<tr>";         
           display += "<td colspan ='3' class='text-right'>Tax Total %1X</td>";             
           display += "<td> 2</td>";             
           display += "</tr>";         
           display += "<tr>"; 
            
           display += "<td colspan='3' class='text-right'>Grand Total</td>";            
           display += "<td> 12.XX</td>";             
           display += "</tr>";         
           display += "</tbody>";     
           display += "</table>"; 
           display += "<br>"; 
           display += "<h3 class='heading'>Payment Status: Paid</h3>"; 
           display += "<h3 class='heading'>Payment Mode: Cash on Delivery</h3>"; 
           display += "</div>";

           display += "<div class='body-section'>";
           display += "<p>&copy; Copyright 2022 - Fabcart.All rights reserved."; 
           display += "<a href ='https://www.fundaofwebit.com/' class='float-right'></a>";     
           display += "</p>"; 
           display += "</div>";      
           display += "</div>";

            treport.InnerHtml = display;
        }
    }
}