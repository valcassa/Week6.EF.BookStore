using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6.EF.BookStore
{
    class EFBookRepository : IBookRepository
    {
        private  readonly BookContext _bookCtx;

        public  EFBookRepository()
        {
            _bookCtx = new BookContext();

        }

        public  List<Book> Fetch()
        {
            var books = _bookCtx.Book.ToList();
            return books;
        }

        public  void Add()
        {
            var newBook = new Book { Id = 02, Title = "Il piccolo principe", Author = "Antoine Saint Euxphery", ISBN = "2344576", Quantity = 10 };

            _bookCtx.Book.Add(newBook);

            _bookCtx.SaveChanges();
        }

        public  void Delete()
        {
            var book = _bookCtx.Book.Find(01);

            _bookCtx.Book.Remove(book);

            _bookCtx.SaveChanges();
        }


        public void GetAndUpdateBook()
        {
            var book = _bookCtx.Book.FirstOrDefault();

            book.Author = "Alessandro Manzoni";

            _bookCtx.SaveChanges();
        }

        public Book GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Add(Book item)
        {
            throw new NotImplementedException();
        }

        public bool Update(Book item)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Book item)
        {
            throw new NotImplementedException();
        }
    }
}
