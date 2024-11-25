using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{

    internal class ConcreteHandlerC : Handler
    {
        public override void Handle(Request request)
        {
            if (request.EventType == "TypeC")
            {
                Console.WriteLine($"Обработчик C обработал запрос: {request.Content}");
            }
            else if (NextHandler != null)
            {
                NextHandler.Handle(request);
            }
            else
            {
                Console.WriteLine($"Обработчик C не смог обработать запрос: {request.Content}");
            }
        }
    }

}
