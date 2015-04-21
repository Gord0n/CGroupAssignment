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
    public interface IBooksService
    {
        [OperationContract]
        void conncetToDatabase();

        [OperationContract]
        bool AddBook();

        [OperationContract]
        int GetBook(int bookId);

    }

    [DataContract]
    public class Book
    {
        private string bookName;
        private DateTime releaseDate;
        private int isbn;
        private int id; //Auto generated
        
        public Book(String bookName, DateTime releaseDate, int isbn)
        {
            BookName = bookName;
            ReleaseDate = releaseDate;
            ISBN = isbn;
        }

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
