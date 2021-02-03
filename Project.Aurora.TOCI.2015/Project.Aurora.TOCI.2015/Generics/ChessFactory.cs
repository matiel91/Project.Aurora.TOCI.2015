using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Aurora.TOCI._2015.Generics
{
    public class ChessFactory : RegularFactoryGenericsWithDelegates<IChessFigures>
    {
        public ChessFactory()
        {
            this.factoryItemsList = new Dictionary<string, Func<IChessFigures>>
            {
                {"king", () => new King() },
            };
        }
    }
}
