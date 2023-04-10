using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Project_Manager
{
    public partial class Login : System.Web.UI.Page
    {
        private Controller controllerObj;
        public Login()
        {
            controllerObj = new Controller();
            
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            bool Output = controllerObj.Login(TxtUsername.Text, TxtPassword.Text);
            if (Output)
                Response.Write("Valid");
            else
                Response.Redirect("Projects.aspx");
        }
    }
}