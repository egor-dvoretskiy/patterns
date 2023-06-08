using Patterns.Mediatr.Source.Colleagues;
using Patterns.Mediatr.Source.Mediators;
using System.Diagnostics.Metrics;

namespace Patterns.Mediatr
{
    internal class Program
    {
        /// <summary>
        /// Когда имеется множество взаимосвязаных объектов, связи между которыми сложны и запутаны.
        /// Когда необходимо повторно использовать объект, однако повторное использование затруднено в силу сильных связей с другими объектами.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            ManagerMediator mediator = new ManagerMediator();

            mediator.Customer = new CustomerColleague(mediator);
            mediator.Programmer = new ProgrammerColleague(mediator);
            mediator.Tester = new TesterColleague(mediator);

            mediator.Customer.Send("Есть заказ, надо сделать программу");
            mediator.Programmer.Send("Программа готова, надо протестировать");
            mediator.Tester.Send("Программа протестирована и готова к продаже");

            Console.ReadKey();
        }
    }
}