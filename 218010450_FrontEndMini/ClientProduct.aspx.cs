using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace _218010450_FrontEndMini
{
    public partial class ClientProduct : System.Web.UI.Page
    {
        private readonly System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            var UserID = Session["LoggedInUserID"];

           

            string itemId = Request.QueryString["ItemID"];
            string price = Request.QueryString["Price"];
            string brand = Request.QueryString["BrandName"];

            HttpResponseMessage respond = client.GetAsync("https://localhost:44311/api/Cart?userID="+ UserID + "&price="+ price + "&ItemID=" + itemId).Result;

            //var user = respond.Content.ReadAsAsync<int>().Result;
            var Comp = respond.Content.ReadAsAsync<int>().Result;
            if (Comp == 1)
            {
                Response.Redirect("ProductList.aspx?BrandName="+ brand);

            }else if(Comp == -1)
            {
                Response.Redirect("ProductList.aspxBrandName="+ brand);
            }else if (Comp == 0)
            {
                Response.Redirect("ProductList.aspx");
            }

           

        }
    }
}