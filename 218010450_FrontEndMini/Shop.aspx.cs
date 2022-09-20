using _218010450_FrontEndMini.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace _218010450_FrontEndMini
{
    public partial class Shop : System.Web.UI.Page
    {
        private readonly System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            var UserID = Session["LoggedInUserID"];


            HttpResponseMessage respond = client.GetAsync("https://localhost:44311/api/Brand").Result;
            var brand = respond.Content.ReadAsAsync<List<Brand>>().Result;

            string display = "";

            foreach (var x in brand)
            {
                

                display += "<div class='col-sm-6 col-md-3 col-lg-3'>";
                display += "<div class='shop-item'>";
                display += "<div class='shop-item-image'><img src='" + x.Image + "' alt='Accessories Pack'/>";
                display += "<div class='shop-item-detail'><a class='btn btn-round btn-b' href='ProductList.aspx?BrandName=" + x.Name+"&Image="+x.Image+ "&BandID="+x.BrandId+ "'><span class='icon-basket'>My Product</span></a></div>";
                display += "</div>";
                display += "<h4 class='shop-item-title font-alt'><a href ='#'>" + x.Name + "</a></h4>R" + x.Rating + "";
                display += "</div>";
                display += "</div>";

            }

            treport.InnerHtml = display;
        }
    }
}