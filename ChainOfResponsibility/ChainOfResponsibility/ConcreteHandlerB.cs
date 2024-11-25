using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{


    internal class ConcreteHandlerB : Handler
    {
        public override void Handle(Request request)
        {
            if (request.EventType == "TypeB")
            {
                Console.WriteLine($"Обработчик B обработал запрос: {request.Content}");
            }
            else if (NextHandler != null)
            {
                NextHandler.Handle(request);
            }
            else
            {
                Console.WriteLine($"Обработчик B не смог обработать запрос: {request.Content}");
            }
        }
    }
}
