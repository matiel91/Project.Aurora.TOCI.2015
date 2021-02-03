using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Aurora.TOCI._2015.DelegatesTraining
{
    public class DelegatesWithParametersConceptCheck
    {
        private delegate int DelegatZParametrem(int wejscie);
        public int ZmiennaWDelegacie { get; set; } = 5;
        public int RunDelegate()
        {
            DelegatZParametrem dzp = AddFive;
            dzp += MinusThree;
            dzp += MultiplyBy4;

            var result = dzp(ZmiennaWDelegacie); // w tym wypadku wynik ostatniej metody w delegacie
            return ZmiennaWDelegacie;
        }
        public int AddFive(int wejscieAddFive)
        {
            ZmiennaWDelegacie += wejscieAddFive;
            return wejscieAddFive + 5;            
        }

        public int MinusThree(int wejscieMinusThree)
        {
            ZmiennaWDelegacie -= 3;
            return wejscieMinusThree - 3;
        }
        public int MultiplyBy4(int wejscieMultiplyByFour)
        {
            ZmiennaWDelegacie *= 4;
            return wejscieMultiplyByFour * 4;
        }
    }
}
