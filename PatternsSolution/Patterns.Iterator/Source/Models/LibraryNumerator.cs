using Patterns.Iterator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Iterator.Source.Models
{
    public class LibraryNumerator : IIterator<Book>
    {
        private INumerable<Book> aggregate;
        private int index = 0;

        public LibraryNumerator(INumerable<Book> a)
        {
            aggregate = a;
        }

        public bool HasNext() =>
            index < aggregate.Count;

        public Book Next() =>
            aggregate[index++];
    }
}
