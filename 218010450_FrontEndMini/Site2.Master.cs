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
    public partial class Site2 : System.Web.UI.MasterPage
    {
        private readonly System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            var userID = Session["LoggedInUserID"].ToString();

            if (userID != null)
            {
                int ID = Convert.ToInt32(Session["LoggedInUserID"]);
                HttpResponseMessage loggedInUser = client.GetAsync("https://localhost:44311/api/User?userId=" + ID).Result;

                if (loggedInUser.IsSuccessStatusCode)
                {
                    var userDetails = loggedInUser.Content.ReadAsAsync<User>().Result;
                    if (userDetails.Type == "Admin")
                    {
                        dashboard.Visible=true;
                        dash.Visible=true;
                        manaComp.Visible=true;
                        addApp.Visible=true;
                        brands.Visible= true;
                        manBrands.Visible= true;
                        addbrand.Visible= true;
                    }
                    if (userDetails.Type == "Manager")
                    {
                        dashboard.Visible = false;
                        dash.Visible = false;
                        manaComp.Visible = false;
                        addApp.Visible = false;
                        brands.Visible = false;
                        manBrands.Visible = false;
                        addbrand.Visible = false;
                    }
                }


            }    }
    }
}