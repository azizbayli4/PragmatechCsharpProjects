using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookList.Models
{
    public static class imgModel
    {
        public static List<Book> images = new List<Book>
        {
            new Book{ID=1,Name="The Greatest short stories of Leo Tolstoy",Link="1.jpg",Info="https://en.wikipedia.org/wiki/Category:Short_stories_by_Leo_Tolstoy"},
            new Book{ID=2,Name="Anna Karenina-Leo Tolstoy",Link="2.jpg"},
            new Book{ID=3,Name="The Midnight Library-Matt Heig",Link="3.jpg"},
            new Book{ID=4,Name="Ninety Three-Victor Hugo",Link="4.jpg"},
            new Book{ID=5,Name="The Complete Novels-Victor Hugo",Link="5.jpg"},
            new Book{ID=6,Name="Chess-Stefan Zweig",Link="6.png"}
        };
        public static List<Book> GetimgItem() => images;
    }

    public class Book
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public string Info { get; set; }
    }
}
