using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Aurora.TOCI._2015.Generics.HandlersExample
{
    public class ChainOfResponsibilityHandlerStack<TRefChorStackHandler>
    {
        protected List<Handler<TRefChorStackHandler>> handlersList;

        public void RunAllHandlers(TRefChorStackHandler refType)
        {
            foreach (var item in handlersList)
            {
                item.RunHandlerOperation(refType);
            }
        }
    }
}
