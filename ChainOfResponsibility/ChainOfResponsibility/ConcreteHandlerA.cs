using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{

    internal class ConcreteHandlerA : Handler
    {
        public override void Handle(Request request)
        {
            if (request.EventType == "TypeA")
            {
                Console.WriteLine($"Обработчик A обработал запрос: {request.Content}");
            }
            else if (NextHandler != null)
            {
                NextHandler.Handle(request);
            }
            else
            {
                Console.WriteLine($"Обработчик A не смог обработать запрос: {request.Content}");
            }
        }
    }
}
