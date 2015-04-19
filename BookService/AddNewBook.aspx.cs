﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookService
{
    public partial class AddNewBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (BookReference.BooksInterfaceClient myClient = new BookReference.BooksInterfaceClient())
            {
                
            }        
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "")
            {
                Label4.Text = "Fields cannot be left empty.";
            }
            else
            {
                Session["bookName"] = TextBox1.Text;
                Session["releaseDate"] = TextBox2.Text;
                Session["ISBN"] = TextBox3.Text;
                Response.Redirect("~/ShowAddedBook.aspx");
            }
        }
    }
}