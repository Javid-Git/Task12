using Task12.models;
using System;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            string name = "Kitab";
            string authorname = "Cavid";
            int pagecount = 150;
            Book book = new Book(name, authorname, pagecount);

            library.AddToList(book);

            foreach (Book item in library.books)
            {
                Console.WriteLine($"Kod: {item.Code}\nKitabin adi: {item.Name}\nMuellif: {item.AuthorName}\nSehife sayi: {item.PageCount}");
            }
        }
    }
}
