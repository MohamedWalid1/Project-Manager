using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_Manager
{
    public partial class Create : System.Web.UI.Page
    {
        private Controller controllerObj;
        public Create()
        {
            controllerObj = new Controller();

        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnCreate_Click(object sender, EventArgs e)
        {
            bool Valid = controllerObj.Create(TxtCode.Text, TxtName.Text);
            if (!Valid)
                Response.Write("Code Already Exists");
            else
                Response.Write("Project Added Successfully");
        }

        protected void BtnProjects_Click(object sender, EventArgs e)
        {
            Response.Redirect("Projects.aspx");
        }
    }
}