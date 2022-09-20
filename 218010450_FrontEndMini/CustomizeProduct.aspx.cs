using _218010450_FrontEndMini.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _218010450_FrontEndMini
{
    public partial class CustomizeProduct : System.Web.UI.Page
    {
        private readonly System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();
        protected void Page_Load(object sender, EventArgs e)
        {

            var UserID = Session["LoggedInUserID"];
            //var brand = Session["BrandName"];

            var CompId = Request.QueryString["CategoryId"];
            string name = Request.QueryString["CategoryName"];

            HttpResponseMessage respond = client.GetAsync("https://localhost:44311/api/ProductParts?compId=" + CompId).Result;
                var Comp = respond.Content.ReadAsAsync<List<Component>>().Result;

                string display = "";
                string play = "";
                string btn = "";

                var val = Session["ReturnValue"];


                play += "<div class='container'>";
                play += "<div class='row'>";
                play += "<div class='col-sm-6 col-sm-offset-3'>";
                play += "<h1 class='module-title font-alt'>" + name + "</h1>";
                play += "</div>";
                play += "</div>";
                foreach (var z in Comp)
                {
                

                display += "</tr>";
                    display += "<tr>";
                    display += "<td class='hidden-xs'><a href ='#' ><img src='" + z.Image + "' alt='Accessories Pack'/></a></td>";
                    display += "<td>";
                    display += "<h5 class='product-title font-alt'>" + z.Name + "</h5>";
                    display += "</td>";
                    display += " <td class='hidden-xs'>";
                    display += "<h5 class='product-title font-alt'>R" + z.Price + "</h5>";
                    display += "</td>";
                    display += "<td>";
                    //display += "<a class='btn btn-border-d btn-circle' id='customize' runat='server' href='ClientProduct.aspx?ItemID=" + z.SoundId  + "&CategoryName=" + name + "&Price=" + z.Price +"'>Add To Cart</a>";
                    display += "<a class='btn btn-border-d btn-circle'  href='#'>Reject</a>";
                    display += "</td>";
                    display += "</tr>";


                }
           

            btn += "<a class='btn btn-block btn-round btn-d pull-right'id='customize' runat='server' href='Cart.aspx?Brand=&Comp="+ name+ "&Status=Add"+"&Price=12' type='submit'>Update Cart</a>";
                nav.InnerHtml = play;
                treport.InnerHtml = display;
                dis.InnerHtml = btn;
            QueryString();
        }
        public void QueryString()
        {
            var UserID = Session["LoggedInUserID"];
            var brandName = Session["BrandName"];


            string status = Request.QueryString["Status"];
            string Feature = Request.QueryString["FeatureName"];
            string itemname = Request.QueryString["CategoryName"];
            string price = Request.QueryString["Price"];

            var compName = Session["ItName"];




            HttpResponseMessage respond = client.GetAsync("https://localhost:44311/api/ProductParts?userID=" + UserID + "&ItemID=" + 1 + "&featureName=" + Feature + "&status="+ status).Result; // + "&status=" + UserID + "&itmeName=" + brandName + "&compName=" + itemname + "&feature=" + itemName + "&status=" + status + "&price=" + price).Result;

            if (respond.ReasonPhrase == "Bad Request")
            {
                return;
            }
            else
            {
                var Comp = respond.Content.ReadAsAsync<int>().Result;
            }
            
        }
            

        }
    }

            
           
            

            
            

            

        
