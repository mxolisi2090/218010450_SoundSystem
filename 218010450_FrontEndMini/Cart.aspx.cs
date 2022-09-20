using _218010450_FrontEndMini.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace _218010450_FrontEndMini
{
    public partial class Cart : System.Web.UI.Page
    {
        private readonly System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();
        protected void Page_Load(object sender, EventArgs e)
        {


            var UserID = Session["LoggedInUserID"];
            
            HttpResponseMessage feature = client.GetAsync("https://localhost:44311/api/Cart?userId=" + UserID).Result;
            var Comp = feature.Content.ReadAsAsync<List<CartItem>>().Result;


            string display = "";
            string dis = "";
            string ord = "";
            double Total = 0;

            var idList = new List<int>();
            var itemId = new List<string>();

            Session["SessionList"] = new ArrayList();

            ArrayList cart1 = new ArrayList();
            ArrayList items = new ArrayList();
            ArrayList orde = new ArrayList();
            foreach (var a in Comp)
            {

                HttpResponseMessage item = client.GetAsync("https://localhost:44311/api/Components?itemID=" + a.ItemId).Result;
                var itemDetails = item.Content.ReadAsAsync<Component>().Result;

                HttpResponseMessage brand = client.GetAsync("https://localhost:44311/api/Brand?BrandName="+ itemDetails.BrandName+ "&val=1" ).Result;
                var brandDetails = brand.Content.ReadAsAsync<Brand>().Result;

               
                

                display += "<tr>";
                display += "<td class='hidden-xs'><a href ='#' ><img src='"+ itemDetails.Image+ "' alt='Accessories Pack'/></a></td>";
                display += "<td>";
                display += "<h4 class='product-title font-alt'>" + brandDetails.Name + "</h4>";
                display += "<h6 class='product-title font-alt'>" + itemDetails.Name + "</h6>";
                display += " </td>";
                display += "<td class='hidden-xs'>";
                display += "<h6 class='product-title font-alt'>Bluetooth</h6>";
                display += "</td>";
                display += "<td>";
                display += "<input class='form-control' maxlength='4' size='4' runat='server' id='itemquantity" + a.ItemId + " type='text' name='\' value='" + a.Quality + "' >";

                display += "<Button class='btn btn-border-d btn-circle' id='btnid" + a.ItemId + "'  onclick='sendQuant" + a.ItemId + "()' type='submit'>Update</Button>";

                display += "<script type='text/javascript'>";
                display += "function sendQuant" + a.ItemId + "(){";
                display += "var quant = document.getElementById('itemquantity" + a.ItemId + "').value;";
                display += "document.getElementById('btnid" + a.ItemId + "').href='Quality.aspx?QItem='+quant+ '&itemID=" + a.ItemId + "'; ";
                display += "}";
                display += "</script>";

                display += "</td>";



                display += " <td>";
                display += "<h5 class='product-title font-alt'>R" + itemDetails.Price + "</h5>";
                display += "</td>";
                display += "<td class='pr-remove'><a href ='RemoveCart.aspx?itemId=" + a.ItemId + "' title='Remove'><i class='fa fa-times'></i></a></td>";
                display += "</tr>";

                Total += itemDetails.Price;

                

                
               
                cart1.Add(itemDetails.PartId);
                items.Add(itemDetails.Name);
                Session["SessionList"] = cart1;
                Session["SessionNames"] = items;
                //display += "<a class='btn btn-border-d btn-circle' id='btnid" + a.ItemId + "' onclick='sendQuant" + a.ItemId + "()' runat='server' type='submit'>Update</a>";
                Session["SessionOrder"] = orde.Add(a.Quality);
            }
            Session["List"] = itemId.ToList();
            Session["Listid"] = idList.ToList();
            //idList = itemId.Aggregate((acc, next) => acc + next);

            dis += "<tr>";
            dis += "<th>Cart Subtotal:</th>";
            dis += "<td>R"+ Total + "</td>";
            dis += "</tr>";
            dis += "<tr>";
            dis += "<th> Shipping Total:</th>";
            dis += "<td>R2.00 </td>";
            dis += "</tr>";
            dis += "<tr class='shop-Cart-totalprice'>";
            dis += "<th>Total :</th>";
            Total += 2;
            dis += "<td>R"+ Total + "</td>";
            dis += "</tr>";

            ord += "<a class='btn btn-lg btn-block btn-round btn-d' href='Checkout.aspx?Total="+Total+ "&status=Active&itemsIds"+ itemId + "' runat='server' type='submit'>Proceed to Checkout</a>";
            ////ord += "<a class='btn btn-border-d btn-circle'  href='Order.aspx'><i class='fa fa-windows'></i> Customize</a>";

            //int rep =int.Parse(Request.QueryString["respo"]);
            //if (rep == 1)
            //{
            //    error.Attributes.Add("style", "color:green;");
            //    error.Text = "Order Added.";
            //    error.Visible = true;
            //}

            order.InnerHtml = ord;
            checkout.InnerHtml = dis;
            treport.InnerHtml = display;
        }
    }
}