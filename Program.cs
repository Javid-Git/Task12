using Task12.models;
using System;
using System.Collections.Generic;

namespace Task12
{
    class Program
    {
        public delegate List<Book> Finder<T>(T item);
        public delegate List<Book> Finder<T, U>(T item, U item1);
        public delegate void Findervoid<T>(T item);
        static void Main(string[] args)
        {
            Library library = new Library();
            string name = "Kitab";
            string authorname = "Cavid";
            int pagecount = 150;
            Book book = new Book(name, authorname, pagecount);

            library.AddToList(book);
            string findname = "i";
            int page1 = 130;
            int page2 = 200;
            string no = "KI1";

            Finder<string> searcher = new Finder<string>(library.FindAllBooksByName);

            searcher += library.SearchBooks;
            searcher.Invoke(findname);

            Finder<int, int> searcher2 = new Finder<int, int>(library.FindAllBooksByPageCountRange);

            searcher2(page1, page2);

            Findervoid<string> voider = new Findervoid<string>(library.RemoveAllBookByName);
            
            voider(findname);
            voider -= library.RemoveAllBookByName;
            voider += library.RemoveByNo;
            voider(no);
        }
    }
}

