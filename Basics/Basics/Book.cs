using System;
using System.Linq;
namespace Basics
{
    public class Book
    {
        public string title;
        public string author;
        public int pages;
        private string genre = "Undefined";
        private string[] type_genres = { "Sci-fi", "Drama", "Mistery", "Horror" };

        public Book(string title, string author, int pages)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
        }

        public string Genre
        {
            get { return genre; }
            set {
                if (type_genres.Contains(value))
                {
                    genre = value;
                }
            }
        }

        public static string SayHiAgain()
        {
            return "Hello, there";
        }

    }
}
