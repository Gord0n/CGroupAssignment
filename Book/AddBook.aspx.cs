using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookPages
{
    public partial class AddBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            using (ServiceReference1.Service1Client myClient = new ServiceReference1.Service1Client())
            {
                int success = myClient.GetBook(0);

                Boolean ja = true;
                
                if (success == -1)
                    ja = false;

                Label1.Text = "Is it succesful: " + ja;
             
            }                                

        }
    }
}