using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12.models
{
    class Book
    {
        private static int _count=0;
        public string Code { get; set; }
        private string _name;
        public string Name 
        {
            get => _name;
            set
            {
                while(value.Length <= 3)
                {
                    Console.WriteLine("Kitabin adi 3 herfden cox olmalidir!");
                    value = Console.ReadLine();
                }
                _name = value;
            }
        }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }

        public Book(string name, string authorname, int pagecount)
        {
            Name = name;
            AuthorName = authorname;
            PageCount = pagecount;
            _count++;
            Code = $"{Name.Substring(0,2).ToUpper()}{_count}";
        }
    }
}
