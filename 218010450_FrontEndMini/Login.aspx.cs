using _218010450_FrontEndMini.Models;
using System;
using System.Net.Http;


namespace _218010450_FrontEndMini
{
    public partial class Login : System.Web.UI.Page
    {
        private readonly System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginClicked(object sender, EventArgs e)
        {
            //webapiminiproject.azurewebsites.net/api/User?password=123&email=MXO@11
            //client.BaseAddress = new Uri("https://localhost:44311/api/");

            HttpResponseMessage response = client.GetAsync("https://localhost:44311/api/User?password=" + pass.Value + "&email=" + email.Value).Result;
            HttpResponseMessage getUser = client.GetAsync("https://localhost:44311/api/User?email="+ email.Value + "&val=1").Result;

            if (response.IsSuccessStatusCode)
            {
                var user = response.Content.ReadAsAsync<int>().Result;
                var userDetails = getUser.Content.ReadAsAsync<User>().Result;
                if (user == -1)
                {

                    Response.Redirect("Home.aspx");
                }

                
               // Session["LoggedInAdmin"] = userDetails.Type;

                Session["LoggedInUserID"] = userDetails.Id;

                    if(userDetails.Type.Equals("Admin")){
                        Response.Redirect("AdminListComp.aspx");
                    }else if (userDetails.Type.Equals("client"))
                    {
                        Response.Redirect("Shop.aspx");
                    }else if (userDetails.Type.Equals("Manager"))
                    {
                        Response.Redirect("ViewStock.aspx");
                    }





                //Session["UserType"] = userDetails.UserType;
                //Session["UserCredentials"] = userDetails.Name + " " + userDetails.Surname;

                    /* if (userDetails.UserType.Equals("employee"))
                     {

                         Response.Redirect("appointment-page.aspx");

                         return;
                     }
                     else if (userDetails.UserType.Equals("admin"))
                     {

                         Response.Redirect("adminDashboard.aspx");

                         return;
                     }
                     else if (userDetails.UserType.Equals("supplier"))
                     {
                         Response.Redirect("supplier.aspx");
                     }
                    */

            }
            //Response.Redirect("UserRegister.aspx");

        }
    }
}