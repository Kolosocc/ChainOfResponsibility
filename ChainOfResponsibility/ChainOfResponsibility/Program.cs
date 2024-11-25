using System;
using System.Collections.Generic;

using ChainOfResponsibility;









class Program
{
    static void Main()
    {

        Handler handlerA = new ConcreteHandlerA();
        Handler handlerB = new ConcreteHandlerB();
        Handler handlerC = new ConcreteHandlerC();


        handlerA.SetNext(handlerB).SetNext(handlerC);


        List<Request> requests = new List<Request>
        {
            new Request("TypeA", "Событие для обработчика A"),
            new Request("TypeB", "Событие для обработчика B"),
            new Request("TypeC", "Событие для обработчика C"),
            new Request("TypeUnknown", "Событие с неизвестным типом")
        };


        foreach (var request in requests)
        {
            handlerA.Handle(request);
        }
    }
}
