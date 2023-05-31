using Patterns.Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Observer.Source.Observers
{
    public class ConcreteObserverA : IObserver
    {
        public ConcreteObserverA(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public void Update(ISubject subject)
        {
            if ((subject as Subject).State < 12)
                Console.WriteLine("ConcreteObserverA reacted to the event");
        }
    }
}
