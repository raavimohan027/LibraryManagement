using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagement.Controllers
{
    [ApiController]
    [Route("api/book")]
    public class BookController : ControllerBase
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

        public BookController()
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

        [Route("{id}")]
        public Book GetBook(int id)
        {
            return Books.FirstOrDefault(book => book.Id == id);
        }

        [Route("{id}/reviews")]
        public List<string> GetBookReviews(int id)
        {
            return Books.FirstOrDefault(book => book.Id == id)?.Reviews;
        }

        public int PostBook(Book book)
        {
            Books.Append(book);
            return 0;
        }

        [Route("{id}")]
        public bool PutBook(int id, Book book)
        {
            var index = Books.FindIndex(book => book.Id == id);
            if (index != -1)
            {
                Books[index] = book;
                return true;
            }

            return false;
        }

        [Route("{id}/review")]
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

        [Route("{id}")]
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
