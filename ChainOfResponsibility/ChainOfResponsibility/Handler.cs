using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal abstract class Handler
    {
        protected Handler NextHandler { get; private set; }

        public Handler SetNext(Handler handler)
        {
            NextHandler = handler;
            return handler;
        }


        public abstract void Handle(Request request);

    }
}
