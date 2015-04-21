using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BookService
{
   
    public class BooksService : IBooksService
    {     
        //Makes the database connection
        public void conncetToDatabase()
        {

        }

        // Add a book to the database
        public bool AddBook()
        {
            //do connection to SQL database and add it in
            bool success = false; //change this depending on if the database recieved the information properly or not
            
            return success;
        }

        //Recieve a books information from the database
        public int GetBook(int bookId)
        {
            int success = -1;

            return success;
        }     
      
    }
}
