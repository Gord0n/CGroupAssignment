using System;
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

            String bookName = TextBox1.Text;
            DateTime date = Calendar1.SelectedDate;
            int isbn = Int32.Parse(TextBox3.Text);

            if (TextBox1.Text == "" || TextBox3.Text == "")
            {
                Label4.Text = "Fields cannot be left empty.";
            }
            else
            {
                

                using (BookReference.BooksInterfaceClient myClient = new BookReference.BooksInterfaceClient())
                {
                   

                    Book book = new Book(bookName, date, isbn);
                    

                }      

                Session["bookName"] = TextBox1.Text;
                Session["releaseDate"] = date;
                Session["ISBN"] = TextBox3.Text;
                Response.Redirect("~/ShowAddedBook.aspx");
            }
        }
    }
}