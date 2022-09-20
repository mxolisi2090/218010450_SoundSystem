using _218010450_FrontEndMini.Models;
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
    public partial class AddComponents : System.Web.UI.Page
    {
        private readonly System.Net.Http.HttpClient client = new System.Net.Http.HttpClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected  void addCompClicked(object sender, EventArgs e)
        {
            var UserID = Session["LoggedInUserID"];
            var total = Request.QueryString["Total"];
            var status = Request.QueryString["status"];


            if (FileUpload1.HasFile)
            {
                string ext = System.IO.Path.GetExtension(FileUpload1.FileName);
                if (ext == ".png")
                {
                    string path = Server.MapPath("assets//images//shop//");
                    FileUpload1.SaveAs(path + FileUpload1.FileName);

                   
                    HttpResponseMessage comp = client.GetAsync("https://localhost:44311/api/Components?compName="+ name.Value+"&brandname="+ brand.Value+"&image=/assets/images/shop/"+ FileUpload1.FileName +"&price="+ price.Value+"&status="+ stat.Value + "&description="+ descri.Value).Result;
                    var omp = comp.Content.ReadAsAsync<int>().Result;
                    if (omp == 1)
                    {
                        error.Attributes.Add("style", "color:green;");
                        error.Text = "Component Added.";
                        error.Visible = true;
                    }
                    else if(omp==-3)
                    {
                        error.Attributes.Add("style", "color:green;");
                        error.Text = "Component .";
                        error.Visible = true;
                    }
                }
                else
                {
                    error.Attributes.Add("style", "color:red;");
                    error.Text = "You can only upload png file";
                    error.Visible = true;
                }
            }

           

        }
    }   
}