using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Observer.Interfaces
{
    public interface IObserver
    {
        public void Update(ISubject subject);

        public string Name { get; set; }
    }
}
