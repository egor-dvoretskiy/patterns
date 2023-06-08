using Patterns.Mediatr.Source.Colleagues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Mediatr.Source.Mediators
{
    public class ManagerMediator : Mediator
    {
        public Colleague Customer { get; set; }

        public Colleague Programmer { get; set; }

        public Colleague Tester { get; set; }

        public override void Send(string msg, Colleague colleague)
        {
            if (Customer == colleague)
            {
                Programmer.Notify(msg);
                return;
            }

            if (Programmer == colleague)
            {
                Tester.Notify(msg);
                return;
            }

            if (Tester == colleague)
            {
                Customer.Notify(msg);
                return;
            }
        }
    }
}
