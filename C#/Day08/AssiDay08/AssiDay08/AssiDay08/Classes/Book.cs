using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssiDay08.Classes
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public Book()
        {
            Title = "Unknown";
            Author = "Unknown";
        }   
        public Book(string title)
        {
            Title = title;
            Author = "Unknown";
        }
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
        override public string ToString()
        {
            return $"Title: {Title}, Author: {Author}";
        }
    }
}
