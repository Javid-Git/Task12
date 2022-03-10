using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12.models
{
    class Library
    {
        
        public List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }
        public void AddToList(Book item)
        {
            books.Add(item);
        }
        public List<Book> FindAllBooksByName(string item)
        {
            List<Book> booknames = new List<Book>();
            foreach (Book book in books)
            {
                if (book.Name.Contains(item.ToUpper()))
                {
                    booknames.Add(book);
                }
            }
            if (booknames.Count == 0)
            {
                Console.WriteLine($"Yazdiginiz '{item}' parametri uzre bir kitab tapilmadi!");
            }
            return booknames;
        }
        public void RemoveAllBookByName(string item)
        {
            foreach (Book book in books)
            {
                if (book.Name.Contains(item.ToUpper()))
                {
                    books.Remove(book);
                    Console.WriteLine($"{book.Name} kitabi silindi!");
                    return;
                }
                Console.WriteLine($"Yazdiginiz '{item}' parametri uzre bir kitab tapilmadi!");
            }
        }
        public List<Book> SearchBooks(string item)
        {
            List<Book> searchedbooks = new List<Book>();
            foreach (Book book in books)
            {
                if (book.Name.Contains(item.ToUpper()))
                {
                    searchedbooks.Add(book);
                }
                else if (book.AuthorName.Contains(item.ToUpper()))
                {
                    searchedbooks.Add(book);
                }
                else if (book.PageCount.ToString().Contains(item.ToUpper()))
                {
                    searchedbooks.Add(book);
                }
            }
            if (searchedbooks.Count == 0)
            {
                Console.WriteLine($"Yazdiginiz '{item}' parametri uzre bir kitab tapilmadi!");
            }
            return searchedbooks;
        }
        public List<Book> FindAllBooksByPageCountRange(int item1, int item2)
        {
            List<Book> booksbypage = new List<Book>();
            foreach (Book book in books)
            {
                if (book.PageCount>item1 && book.PageCount < item2 )
                {
                    booksbypage.Add(book);
                }
            }
            if (booksbypage.Count == 0)
            {
                Console.WriteLine($"Yazdiginiz '{item1}' ve '{item2}' sehife araliqlarinda olan kitab tapilmadi!");
            }
            return booksbypage;
        }
        public void RemoveByNo(string item)
        {
            foreach (Book book in books)
            {
                if (book.Code == item.ToUpper())
                {
                    books.Remove(book);
                    Console.WriteLine($"{item.ToUpper()} nomreli kitab silindi!");
                    return;
                }
            }
            Console.WriteLine($"Axtardiginiz {item.ToUpper()} nomre uzre kitab tapilmadi!");
        }

    }
}
