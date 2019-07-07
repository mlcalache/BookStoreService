using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace BookStore
{
    /// <summary>
    /// Summary description for Book
    /// </summary>
    [WebService(Namespace = "http://mybookstore.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class BookStoreService : WebService
    {
        [WebMethod]
        public List<Book> GetAllBooks()
        {
            throw new NotImplementedException();
        }

        [WebMethod]
        public Book GetBook(int bookId)
        {
            throw new NotImplementedException();
        }

        [WebMethod]
        public List<Book> GetBookByName(string bookName)
        {
            if (bookName == null)
            {
                throw new ArgumentNullException(nameof(bookName));
            }

            throw new NotImplementedException();
        }

        [WebMethod]
        public List<Book> GetBookByPublisher(string publisherName)
        {
            if (publisherName == null)
            {
                throw new ArgumentNullException(nameof(publisherName));
            }

            throw new NotImplementedException();
        }

        [WebMethod]
        public List<Book> GetBookByAuthor(string authorName)
        {
            if (authorName == null)
            {
                throw new ArgumentNullException(nameof(authorName));
            }

            throw new NotImplementedException();
        }

        [WebMethod]
        public Book CreateBook(Book book)
        {
            if (book == null)
            {
                throw new ArgumentNullException(nameof(book));
            }

            throw new NotImplementedException();
        }

        [WebMethod]
        public Book UpdateBook(Book book)
        {
            if (book == null)
            {
                throw new ArgumentNullException(nameof(book));
            }

            throw new NotImplementedException();
        }

        [WebMethod]
        public Book DeleteBook(int bookId)
        {
            throw new NotImplementedException();
        }
    }
}
