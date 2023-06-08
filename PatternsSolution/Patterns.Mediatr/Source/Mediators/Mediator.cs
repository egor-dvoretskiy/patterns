using Patterns.Mediatr.Source.Colleagues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Mediatr.Source.Mediators
{
    public abstract class Mediator
    {
        public abstract void Send(string msg, Colleague colleague);
    }
}
