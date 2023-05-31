using Patterns.Observer.Source;
using Patterns.Observer.Source.Observers;

namespace Patterns.Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var notifier = new Subject();
            var observerA = new ConcreteObserverA("ObserverAiko");
            notifier.Attach(observerA);

            var observerB = new ConcreteObserverB("ObserverMikoshi");
            notifier.Attach(observerB);

            notifier.SomeBusinessLogic();
            notifier.SomeBusinessLogic();
            notifier.SomeBusinessLogic();

            notifier.Detach(observerB);

            notifier.SomeBusinessLogic();

            Console.ReadKey();
        }
    }
}