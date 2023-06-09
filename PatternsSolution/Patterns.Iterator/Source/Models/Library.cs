using Patterns.Iterator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Iterator.Source.Models
{
    public class Library : INumerable<Book>
    {
        private Book[] books;
        private IIterator<Book> iterator;

        public Library()
        {
            books = new Book[]
            {
                new Book { Name = "Perestuplenie i nakazanie" },
                new Book { Name = "Mertvie tushi" },
                new Book { Name = "Plastilinoviy chelovechek" },
            };
        }

        public Book this[int index]
        {
            get => books[index];
        }

        public int Count
        {
            get => books.Length;
        }

        public IIterator<Book> Iterator
        {
            get => iterator ??
                (iterator = new LibraryNumerator(this));
        }
    }
}
