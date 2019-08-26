using System;

namespace Template
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /* Purpose: This page is used only to redirect to the Login page.*/
            Response.Redirect("secure");
        }
    }
}