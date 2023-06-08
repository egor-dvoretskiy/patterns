using Patterns.Observer.Source;
using Patterns.Observer.Source.Observers;

namespace Patterns.Observer
{
    internal class Program
    {
        /// <summary>
        /// Когда система состоит из множества классов, объекты которых должны находиться в согласованных состояниях
        /// Когда общая схема взаимодействия объектов предполагает две стороны: одна рассылает сообщения и является главным, 
        ///     другая получает сообщения и реагирует на них. Отделение логики обеих сторон позволяет их рассматривать независимо 
        ///     и использовать отдельно друга от друга.
        /// Когда существует один объект, рассылающий сообщения, и множество подписчиков, которые получают сообщения.
        ///     При этом точное число подписчиков заранее неизвестно и процессе работы программы может изменяться.
        /// </summary>
        /// <param name="args"></param>
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