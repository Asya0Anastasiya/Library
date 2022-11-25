using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        private string title;
        public string Title { 
            get { return title; } 
            set { if (value != null) title = value; } 
        }
        
        private string author;
        public string Author
        {
            get { return author; }
            set { if (value != null) author = value; }
        }

        private int publicationYear;

        public int PublicationYear
        {
            get { return publicationYear; }
            set { if (value >= 0) publicationYear = value; }
        }

        //bool isSeria;

        private int pages;
        public int Pages
        {
            get { return pages; }
            set { if (value > 0) pages = value; }
        }

        public Book(string title, string author, int publicationYear, int pages)
        {
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
            Pages = pages;
        }
    }
}
