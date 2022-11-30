using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class BookComparer : IComparer<Book>
    {
        public int Compare(Book? book1, Book? book2)
        {
            if (book1 is null || book2 is null)
                throw new ArgumentException("Некорректное значение параметра");
            return book1.PublicationYear - book2.PublicationYear;
        }
    }
}
