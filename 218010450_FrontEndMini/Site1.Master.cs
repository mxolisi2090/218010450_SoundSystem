using System;
using System.Collections.Generic;
using System.Net.Http;

namespace _218010450_FrontEndMini
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        private readonly System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();
        protected void Page_Load(object sender, EventArgs e)
        {

            //var UserID = Session["LoggedInUserID"]; 

            //HttpResponseMessage feature = client.GetAsync("https://localhost:44311/api/Cart?value1=1&value2=1&UserID="+ UserID).Result;
            //var Comp = feature.Content.ReadAsAsync<int>().Result;

            //string display = "";

            //display += "<i class='fa' href='Cart.aspx' runat='server'  ata-toggle='dropdown' style='font-size:24px'>&#xf07a;</i>";
            //display += "<span class='badge badge-warning' id='lblCartCount'>"+ Comp + "</span>";

            //treport.InnerText=display;
        }
    }
}