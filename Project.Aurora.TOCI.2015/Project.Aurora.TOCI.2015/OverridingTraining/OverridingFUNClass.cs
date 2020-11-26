using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Aurora.TOCI._2015.OverridingTraining
{
    public class OverridingFUNClass
    {
        public void TestItAll()
        {
            //P.1
            //ktora metoda KlasaKtoraMozeBycOverriden(); sie wywola? Z OverLoadingExampleToTaBazowa czy OverridingExampleToTaKtoraDziedziczy?
            OverLoadingExampleToTaBazowa przyklad_1 = new OverLoadingExampleToTaBazowa();
            przyklad_1.KlasaKtoraMozeBycOverriden();
            // ODP: OverLoadingExampleToTaBazowa


            //P.2
            //ktora metoda KlasaKtoraMozeBycOverriden(); sie wywola? Z OverLoadingExampleToTaBazowa czy OverridingExampleToTaKtoraDziedziczy?
            //Dla wyjasnienia przyklad_2 jest obiektem typu OverLoadingExampleToTaBazowa ale wywolywany jest konstruktor OverridingExampleToTaKtoraDziedziczy(); Czyli mozemy sobie 
            // wywolac konstruktor jaki nam sie podoba, jak przeciazony by nam wlasnie odpowiadal
            OverLoadingExampleToTaBazowa przyklad_2 = new OverridingExampleToTaKtoraDziedziczy(); 
            przyklad_2.KlasaKtoraMozeBycOverriden(); 

            //P.3 // Poczatek taki sam jak P.2 PRZYKLAD Z CASTOWANIEM 1
            //ktora metoda KlasaKtoraMozeBycOverriden(); sie wywola? Z OverLoadingExampleToTaBazowa czy OverridingExampleToTaKtoraDziedziczy?
            OverLoadingExampleToTaBazowa przyklad_3 = new OverridingExampleToTaKtoraDziedziczy();
            ((OverLoadingExampleToTaBazowa)przyklad_3).KlasaKtoraMozeBycOverriden();  //Bartek obstawia overriden

            //P.4 // Poczatek taki sam jak P.2 PRZYKLAD Z CASTOWANIEM 1
            //ktora metoda KlasaKtoraMozeBycOverriden(); sie wywola? Z OverLoadingExampleToTaBazowa czy OverridingExampleToTaKtoraDziedziczy?
            OverridingExampleToTaKtoraDziedziczy przyklad_4 = new OverridingExampleToTaKtoraDziedziczy();
            ((OverLoadingExampleToTaBazowa)przyklad_4).KlasaKtoraMozeBycOverriden(); //Bartek obstawia overriden

            //P.10 Wywolanie metody z klasy bazowej z poziomu klasy dziedziczacej oczywiscie public, bo private to raczej sie nie da.
            OverridingExampleToTaKtoraDziedziczy przyklad_10 = new OverridingExampleToTaKtoraDziedziczy();
            przyklad_4.MetodaKtoraJestDostepnaTylkoZPoziomuKlasyBazowej();


        }
    }
}
