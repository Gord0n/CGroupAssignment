using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BookService
{
    
    [ServiceContract]
    public interface BooksInterface
    {

        [OperationContract]
        int AddBook(Book book);

        [OperationContract]
        int GetBook(int bookId);

    }

    [DataContract]
    public class Book
    {
        string bookName;
        DateTime releaseDate;
        int isbn;
        int id;

        [DataMember]
        public string BookName { get; set; }

        [DataMember]
        public DateTime ReleaseDate { get; set; }

        [DataMember]
        public int ISBN { get; set; }

        [DataMember]
        public int Id { get; set; }

    }
   
}
