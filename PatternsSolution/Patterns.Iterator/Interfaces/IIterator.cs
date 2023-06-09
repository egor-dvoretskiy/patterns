using Patterns.Iterator.Source.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Iterator.Interfaces
{
    public interface IIterator<T>
    {
        bool HasNext();
        T Next();
    }
}
