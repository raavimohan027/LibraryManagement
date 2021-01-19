using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagement.Controllers
{
    [ApiController]
    [Route("api/books")]
    public class BooksController : ControllerBase
    {
        private static List<Book> Books = new List<Book>()
        {
            new Book()
            {
                Id = 1,
                Name = "Wings Of Fire",
                Category = "Novel",
                Reviews = new List<string>{ "Good", "Thoughful" },
                Authors = new List<string>{ "Selvan" },
            },
        };

        public BooksController()
        {
        }

        [Route("all")]
        public IEnumerable<Book> GetAllBooks()
        {
            return Books;
        }

        [Route("available")]
        public IEnumerable<Book> GetAvailableBooks()
        {
            return Books.Where(book => book.Status == "Available");
        }

        [Route("{id}/details")]
        public Book GetBookDetails(int id)
        {
            return Books.FirstOrDefault(book => book.Id == id);
        }

        [Route("{id}/reviews")]
        public List<string> GetBookReviews(int id)
        {
            return Books.FirstOrDefault(book => book.Id == id)?.Reviews;
        }

        [Route("add")]
        public List<Book> PostBook(Book book)
        {
            Books.Append(book);
            return Books;
        }

        [Route("{id}/update")]
        public bool PostBook(int id, Book book)
        {
            var index = Books.FindIndex(book => book.Id == id);
            if (index != -1)
            {
                Books[index] = book;
                return true;
            }

            return false;
        }

        [Route("{id}/addreview")]
        public bool PostReview(int id, string review)
        {
            var index = Books.FindIndex(book => book.Id == id);
            if (index != -1)
            {
                Books[index].Reviews.Add(review);
                return true;
            }

            return false;
        }

        [Route("{id}/remove")]
        public bool DeleteBook(int id)
        {
            var book = Books.FirstOrDefault(book => book.Id == id);
            if (book != null)
            {
                Books.Remove(book);
                return true;
            }

            return false;
        }
    }
}
