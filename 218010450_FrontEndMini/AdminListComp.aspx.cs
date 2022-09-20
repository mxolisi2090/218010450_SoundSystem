using System;
using _218010450_FrontEndMini.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _218010450_FrontEndMini
{
    public partial class AdminListComp : System.Web.UI.Page
    {
        private readonly System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();
        protected void Page_Load(object sender, EventArgs e)
        {
           

            HttpResponseMessage feature = client.GetAsync("https://localhost:44311/api/Components").Result;
            var Comp = feature.Content.ReadAsAsync<List<Component>>().Result;

            string display = "";
            foreach(var a in Comp)
            {
                display += "<tr>";
                display += "<td>";       
                display += "<ul class='list-unstyled users-list m-0 avatar-group d-flex align-items-center'>";          
                display += "<li";            
                display += "data-bs-toggle='tooltip' "; 
                display += "data-popup='tooltip-custom' ";             
                display += "data-bs-placement='top' ";              
                display += "class='avatar avatar-xs pull-up' ";              
                display += "title='Lilian Fuller'";             
                display += ">";           
                display += "<img src='"+a.Image+ "' style='width:55px;height:auto;' alt='image' class='' />";              
                display += "</li>";                                                             
                display += "</ul>";          
                display += "</td>";       

                display += "<td><strong>"+a.Name+"</strong></td>";        

                display += "<td>"+a.BrandName+"</td>";        

                display += "<td>R"+a.Price+"</td>";        

               display += "<td><span class='badge bg-label-primary me-1'>"+a.Status+"</span></td>";         
                       
               display += "<td>";         
               display += "<a type='button' runat='server' href='UpdateComponent.aspx?compId="+a.PartId+"'class='btn btn-info'>Update</a>";            
               display += "<a type='button' runat='server' href='MyOrders.aspx?compId="+a.PartId+"&status="+a.Status+"' class='btn btn-info'>Delete</a>";            
               display += " </td>";        
               display += "</tr>";       
            }
            treport.InnerHtml=display;
        }

    }
} 