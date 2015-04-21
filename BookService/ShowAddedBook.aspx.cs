using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookService
{
    public partial class ShowAddedBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label5.Text = (string)(Session["bookName"]);
            DateTime date = (DateTime)(Session["releaseDate"]);
            Label6.Text = date.ToString();
            Label7.Text = (string)(Session["ISBN"]);
        }
    }
}