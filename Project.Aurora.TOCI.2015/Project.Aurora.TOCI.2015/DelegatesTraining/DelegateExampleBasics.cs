using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Aurora.TOCI._2015.DelegatesTraining
{
    public class DelegateExampleBasics
    {
        private delegate int PierwszyDelegat();

        public void PierwszyTestDelegata()
        {
            PierwszyDelegat pierwyj = PierwszaMetodaDoDelegata;
            pierwyj += DrugaMetodaDoDelegata;
            pierwyj += PierwszaMetodaDoDelegata;
            pierwyj += TrzeciaMetodaDoDelegata;
            pierwyj += DrugaMetodaDoDelegata;
            pierwyj();
            //pierwyj -= DrugaMetodaDoDelegata;
            pierwyj -= PierwszaMetodaDoDelegata;
            pierwyj();

        }

        public int PierwszaMetodaDoDelegata()
        {
            Debug.WriteLine("Jestem w Pierwszej metodzie delegatowej");
            return 5;
        }

        public int DrugaMetodaDoDelegata()
        {
            Debug.WriteLine("Jestem w drugiej metodzie delegatowej");
            return 5;
        }

        public int TrzeciaMetodaDoDelegata()
        {
            Debug.WriteLine("Jestem w trzeciej metodzie delegatowej");
            return 5;
        }
    }
}
