using Patterns.Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Observer.Source.Observers
{
    public class ConcreteObserverB : IObserver
    {
        public ConcreteObserverB(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public void Update(ISubject subject)
        {
            if ((subject as Subject).State >= 12)
                Console.WriteLine("ConcreteObserverB reacted to the event");
        }
    }
}
