using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TimeSheetManagement
{
    public partial class Employeepanel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           if (Session["UserName"] == null)
            {
                Response.Redirect(" EmployeeLogin.aspx");
            }
            string mail = Request.QueryString["mail"];

            //if (Request.QueryString["UserName"] != null)
            //  Label1.Text = Request.QueryString["UserName"];
        }
    }
}