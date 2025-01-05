using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library;

public class GroupBooks
{
    public class SortedBook
    {
        private List<AddBook> books = new List<AddBook>();
        public void GroupByAuthor()
        {
            var groupByAutor = books.GroupBy(x => x.Author);
            foreach (var group in groupByAutor)
            {
                Console.WriteLine($"Autor: {group.Key}");
                foreach (var book in group)
                {
                    Console.WriteLine($"  Title: {book.Title}, Author: {book.Author}");
                }
            }
        }
        public void GroupByGenre()
        {
            var groupByGenre = books.GroupBy(x => x.Genre);
            foreach (var group in groupByGenre)
            {
                Console.WriteLine($"Genre: {group.Key}");
                foreach (var book in group)
                {
                    Console.WriteLine($"  Title: {book.Title}, Autor: {book.Author}");
                }
            }
        }
        public void GroupByYear()
        {
            var groupByYear = books.GroupBy(x => x.Year);
            foreach (var group in groupByYear)
            {
                Console.WriteLine($"Year: {group.Key}");
                foreach (var book in group)
                {
                    Console.WriteLine($"  Title: {book.Title}, Autor: {book.Author}");
                }
            }
        }
       
    }
}
