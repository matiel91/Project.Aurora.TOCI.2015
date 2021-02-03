using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Aurora.TOCI._2015.Generics.HandlersExample
{
    public abstract class Handler<TRefParam>
    {
        public void RunHandlerOperation(TRefParam refChorParam)
        {
            throw new NotImplementedException();
        }

        protected abstract void Operate(TRefParam refChorParam);
    }
}
