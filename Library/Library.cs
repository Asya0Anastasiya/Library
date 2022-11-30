using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Library
    {
        public List<Book> books = new();

        public void Add(Book book)
        {
            books.Add(book);
        }

    }
}
