using Patterns.Iterator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Iterator.Source.Models
{
    public class Reader
    {
        public void SeeBooks(Library library)
        {
            while (library.Iterator.HasNext())
            {
                Book book = library.Iterator.Next();
                Console.WriteLine(book.Name);
            }
        }
    }
}
