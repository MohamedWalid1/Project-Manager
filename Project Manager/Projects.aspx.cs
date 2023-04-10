using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using System.Web.UI.HtmlControls;

namespace Project_Manager
{
    public partial class Projects : System.Web.UI.Page
    {
        HtmlTable table = new HtmlTable();
        private Controller controllerObj;
        public Projects()
        {
            controllerObj = new Controller();
            table.Height = "125";   table.Width = "100%";
            table.Border = 1;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.Projects();
            foreach (DataRow row in dt.Rows)
            {
                int code = Convert.ToInt32(row["code"]);
                string name = row["name"].ToString();
                string status = row["status"].ToString();

                HtmlTableRow row1 = new HtmlTableRow();

                HtmlTableCell cell1 = new HtmlTableCell();
                cell1.Width = "150px";
                cell1.InnerText = code.ToString();
                row1.Controls.Add(cell1);

                HtmlTableCell cell2 = new HtmlTableCell();
                cell2.Width = "150px";
                cell2.InnerText = name;
                row1.Controls.Add(cell2);

                HtmlTableCell cell3 = new HtmlTableCell();
                cell3.Width = "150px";
                cell3.InnerText = status;
                row1.Controls.Add(cell3);

                HtmlTableCell cell4 = new HtmlTableCell();
                cell4.Width = "150px";
                Button btn1 = new Button();
                btn1.Text = "Edit";
                btn1.Click += new EventHandler((s, ev) => edit_Click(s, e, code));
                cell4.Controls.Add(btn1);
                row1.Controls.Add(cell4);

                HtmlTableCell cell5 = new HtmlTableCell();
                cell5.Width = "150px";
                Button btn2 = new Button();
                btn2.Text = "Delete";
                btn2.Click += new EventHandler((s, ev) => delete_Click(s, e, code));
                cell5.Controls.Add(btn2);
                row1.Controls.Add(cell5);

                table.Controls.Add(row1);
            }
            PlaceHolder1.Controls.Add(table);
        }
        void edit_Click(object sender, EventArgs e, int c)
        {
            Response.Redirect("Edit.aspx?id=" + c.ToString());
        }
        void delete_Click(object sender, EventArgs e, int c)
        {
            controllerObj.Delete(c.ToString());
            Response.Redirect("Projects.aspx");
        }

        protected void BtnNew_Click(object sender, EventArgs e)
        {
            Response.Redirect("Create.aspx");
        }
    }
   
}