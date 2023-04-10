using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Web.UI.HtmlControls;


namespace Project_Manager
{
    public partial class Edit : System.Web.UI.Page
    {
        HtmlTable table = new HtmlTable();
        private Controller controllerObj;
        protected string code;
        public Edit()
        {
            controllerObj = new Controller();
            

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            code = Request.QueryString["id"];
            HtmlTableRow row1 = new HtmlTableRow();

            HtmlTableCell cell1 = new HtmlTableCell();
            cell1.Width = "150px";
            cell1.InnerText = code.ToString();
            row1.Controls.Add(cell1);

            table.Controls.Add(row1);
            PlaceHolder1.Controls.Add(table);
        }

        protected void BtnEdit_Click(object sender, EventArgs e)
        {
            bool Valid = controllerObj.Edit(code, TxtName.Text, DDStatus.Text);
            if (!Valid)
                Response.Write("Code Does not Exist");
            else
                Response.Write("Project Edited Successfully");
        }

        protected void BtnProjects_Click(object sender, EventArgs e)
        {
            Response.Redirect("Projects.aspx");
        }
    }
}