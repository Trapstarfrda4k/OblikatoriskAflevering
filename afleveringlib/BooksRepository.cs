using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OblikatoriskAflevering
{
    public class BooksRepository
    {
        private List<Book> _books = new List<Book>();
        public BooksRepository()
        {
            _books = new List<Book>();
            _books.Add(new Book() { Id = 5, Title = "Hunde",Price = 25});
            _books.Add(new Book() { Id = 6, Title = "Katte", Price = 288 });
            _books.Add(new Book() { Id = 7, Title = "Fugle", Price = 177 });
            _books.Add(new Book() { Id = 8, Title = "Fisk", Price = 69 });
            _books.Add(new Book() { Id = 9, Title = "Aber", Price = 311 });

        }
        public IEnumerable<Book>Get(int? fillprice = null, int? sortprice = null)
        {
            IEnumerable<Book> result = new List<Book>(_books);
            if(fillprice!= null)
            {
                result = result.Where(a=> a.Price > fillprice);
            }
            return result;

        }
        public List<Book> GetallBook()
        {
            return new List<Book>(_books);
        }
        public Book Add(Book book)
        {
            book.validate();
            _books.Add(book);
            return book;
        }
        public Book Getbyid(int id)
        {
            foreach(Book book in _books)
            {
                if (book.Id == id)
                {
                    return book;
                }
            }
            return null;
        }
        public Book Deelete(int id)
        {
            Book delete = Getbyid(id);
            if (delete != null)
            {
                _books.Remove(delete);
                return delete;
            }
            return null;
        }
        public Book Update(int id, Book book)
        {
            book.validate();
            foreach(Book abokk in _books)
            {
                if(abokk.Id == id)
                {
                    abokk.Id = book.Id;
                    abokk.Title = book.Title;
                    abokk.Price = book.Price;
                    return abokk;
                }
            }
            return null;
        }
    }
}
