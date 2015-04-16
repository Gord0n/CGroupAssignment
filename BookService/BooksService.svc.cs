using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BookService
{
   
    public class BooksService : BooksInterface
    {

        // Add a book to the database
        public int AddBook(Book book)
        {
            //do connection to SQL database and add it in
            int success = 0; //change this depending on if the database recieved the information properly or not

            return success;
        }

        //Recieve a books information from the database
        public int GetBook(int bookId)
        {
            int success = -1;

            return success;
        }

        public Book GetDataUsingDataContract(Book book)
        {

            return book;
        }
      
    }
}
