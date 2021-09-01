using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6.EF.BookStore
{
    public class MainBL // business layer
    {
        private IBookRepository _bookRepo;
        internal MainBL(IBookRepository bookRepository)
        {
            _bookRepo = bookRepository;
        }

        public List<Book> FetchBooks()
        {

            return _bookRepo.Fetch();
        }

    }
}

