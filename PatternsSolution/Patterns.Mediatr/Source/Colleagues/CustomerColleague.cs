using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Mediatr.Source.Mediators;

namespace Patterns.Mediatr.Source.Colleagues
{
    public class CustomerColleague : Colleague
    {
        public CustomerColleague(Mediator mediator) 
            : base(mediator)
        {
        }

        public override void Notify(string message)
        {
            Console.WriteLine("Сообщение заказчику: " + message);
        }
    }
}
