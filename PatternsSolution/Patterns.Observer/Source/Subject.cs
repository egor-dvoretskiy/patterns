using Patterns.Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Observer.Source
{
    public class Subject : ISubject
    {
        private readonly List<IObserver> _observers;

        public Subject()
        {
            _observers = new List<IObserver>();
        }

        public int State { get; set; }

        public void Attach(IObserver observer)
        {
            Console.WriteLine("Attached an observer: {0}", observer.Name);
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            Console.WriteLine("Detached an observer: {0}", observer.Name);
            _observers.Remove(observer);
        }

        public void Notify()
        {
            Console.WriteLine("Notifying observers...");

            foreach (var item in _observers)
            {
                item.Update(this);
            }
        }

        public void SomeBusinessLogic()
        {
            Console.WriteLine("Doing some logics...");

            State = Random.Shared.Next(0, 23);

            Console.WriteLine("State changed to {0}", State);

            Notify();
        }
    }
}
