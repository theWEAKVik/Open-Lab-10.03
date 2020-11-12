using System;
using System.Reflection;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            BOOK LOTR = new BOOK();
            LOTR.Title = ("Milujem Hansa");
            LOTR.Pages = (88);
            LOTR.Category = ("Bullshit");
            LOTR.Author = ("Komrad Boris");
            LOTR.ReleaseDate = (1942);
            Console.WriteLine("The book title is " + LOTR.Title + "and it has " + LOTR.Pages + " pages. It is " + LOTR.Category + " from " + LOTR.Author + " who wrote it in  " + LOTR.ReleaseDate + ". It is bullshit!");
        }
    }
    class BOOK
    {        
        private string title;
        private int pages;
        private string category;
        private string author;
        private int releaseDate;        
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
            
        }
        public int Pages
        {
            get
            {
                return pages;
            }
            set
            {
                if (value < 0)
                {
                    pages = 1;
                }
                else
                {
                    pages = value;
                }
            }
        }
        public string Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }
        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }
        public int ReleaseDate
        {
            get
            {
                return releaseDate;
            }
            set
            {
                if (value < 1450 || value > 2021)
                {
                    releaseDate = -1;
                }
                else
                {
                    releaseDate = value;
                }

            }
        }
        
        
    }
}
