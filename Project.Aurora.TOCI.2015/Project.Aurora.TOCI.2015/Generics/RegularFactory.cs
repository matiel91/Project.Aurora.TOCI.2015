using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Aurora.TOCI._2015.Generics
{
    public class RegularFactoryNoGenerics
    {
        protected Dictionary<string, int> factoryItemsList;

        public int GetFactoryElement(string key)
        {
            //TODO tu powinna byc jeszcze walidacja contains key etc
            return factoryItemsList[key];
        }
    }
    //To samo tylko generyczne, co daje nam to ze teraz to fabryka DOWOLNYCH typow
    public class RegularFactoryGenerics<TFactoryItem>
    {
        protected Dictionary<string, TFactoryItem> factoryItemsList;

        public TFactoryItem GetFactoryElement(string key)
        {
            //TODO tu powinna byc jeszcze walidacja contains key etc
            return factoryItemsList[key];
        }
    }
    //to samo co wyzej ale opakowane w FUNC czyli obiekty nie inicjalizuja sie od razu w konstruktorze
    //Func<IchessFigure> - funckja zwracajaca ichesfigures
    public class RegularFactoryGenericsWithDelegates<TFactoryItem>
    {
        protected Dictionary<string, Func<TFactoryItem>> factoryItemsList;

        public TFactoryItem GetFactoryElement(string key)
        {
            //TODO tu powinna byc jeszcze walidacja contains key etc
            return factoryItemsList[key](); //<<----- na koncu nawias bo wywoalnie metody
        }
    }
}
