using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project.Aurora.TOCI._2015.OverridingTraining;

namespace Project.Aurora.Tests
{
    [TestClass]
    public class OverridingTrainingTests
    {


        //Overriding training - Gdzie zaprowadza nas poszczegolne wywowalnia
        //pisane w osobnych testclassach aby uniknac komentowania
        //P.1
        //ktora metoda KlasaKtoraMozeBycOverriden(); sie wywola? Z OverLoadingExampleToTaBazowa czy OverridingExampleToTaKtoraDziedziczy?
        [TestMethod]
        public void MetodaDebugujacaOverridingPrzyklad1()
        {
            OverLoadingExampleToTaBazowa przyklad_1 = new OverLoadingExampleToTaBazowa();
            przyklad_1.KlasaKtoraMozeBycOverriden();
        }
        //P.2
        //ktora metoda KlasaKtoraMozeBycOverriden(); sie wywola? Z OverLoadingExampleToTaBazowa czy OverridingExampleToTaKtoraDziedziczy?
        //Dla wyjasnienia przyklad_2 jest obiektem typu OverLoadingExampleToTaBazowa ale wywolywany jest konstruktor OverridingExampleToTaKtoraDziedziczy(); Czyli mozemy sobie 
        // wywolac konstruktor jaki nam sie podoba, jak przeciazony by nam wlasnie odpowiadal 
        //ODPOWIEDZ -OVERRIDING
        [TestMethod]
        public void MetodaDebugujacaOverridingPrzyklad2()
        {
            OverLoadingExampleToTaBazowa przyklad_2 = new OverridingExampleToTaKtoraDziedziczy();
            przyklad_2.KlasaKtoraMozeBycOverriden();
        }
        //P.3 // Poczatek taki sam jak P.2 PRZYKLAD Z CASTOWANIEM 1
        //ktora metoda KlasaKtoraMozeBycOverriden(); sie wywola? Z OverLoadingExampleToTaBazowa czy OverridingExampleToTaKtoraDziedziczy?
        [TestMethod]
        public void MetodaDebugujacaOverridingPrzyklad3()
        {
            OverLoadingExampleToTaBazowa przyklad_3 = new OverridingExampleToTaKtoraDziedziczy();
            ((OverLoadingExampleToTaBazowa)przyklad_3).KlasaKtoraMozeBycOverriden();  //OVERRIDING
        }
        //P.4 // Poczatek taki sam jak P.2 PRZYKLAD Z CASTOWANIEM 1
        //ktora metoda KlasaKtoraMozeBycOverriden(); sie wywola? Z OverLoadingExampleToTaBazowa czy OverridingExampleToTaKtoraDziedziczy?
        [TestMethod]
        public void MetodaDebugujacaOverridingPrzyklad4()
        {
            OverridingExampleToTaKtoraDziedziczy przyklad_4 = new OverridingExampleToTaKtoraDziedziczy();
            ((OverLoadingExampleToTaBazowa)przyklad_4).KlasaKtoraMozeBycOverriden(); 
            
        }
        
        //P.5 // Wywolanie wirtualnej metody w konstruktorze w klasie bazowej?
        [TestMethod]
        public void WywolanieMetodyWirtualnejWKonstruktorzeKlasyBazowej()
        {
            OverLoadingExampleToTaBazowa przyklad_5 = new OverLoadingExampleToTaBazowa();
            //((OverLoadingExampleToTaBazowa)przyklad_4).KlasaKtoraMozeBycOverriden();
        }
        //P.6 // Wywolanie wirtualnej metody z kalsy bazowej w konstruktorze klasy dziedziczacej?
        [TestMethod]
        public void WywolanieMetodyWirtualnejWKonstruktorzeKlasyDziedziczacej()
        {
            OverridingExampleToTaKtoraDziedziczy przyklad_6 = new OverridingExampleToTaKtoraDziedziczy();
           // ((OverLoadingExampleToTaBazowa)przyklad_6).KlasaKtoraMozeBycOverriden();
        }
        //________________________________________-
        //________________________________________-
        //________________________________________-
        //________________________________________-

        //Seria testów z brakiem wirtualnej metody w klasie bazowej ale z tą metodą przesłonietą w klasie dziedziczącej
        //czyli w bazowej public int NiejestemVirtual(), a w dziedziczacej też public int NiejestemVirtual();
        //P.1
        //Z ktorej klasy NieVirtualnaMetoda Sie Wywola?
        //Odp. Overloading klasa bazowa
        [TestMethod]
        public void MetodaDebugujacaOverridingBrakVirtualaBezNewPrzyklad1()
        {
            OverLoadingExampleToTaBazowa przyklad_1 = new OverLoadingExampleToTaBazowa();
            przyklad_1.NieVirtualnaMetoda();
        }
        //P.2
        //ODPOWIEDZ -Overloading klasa bazowa
        [TestMethod]
        public void MetodaDebugujacaOverridingBrakVirtualaBezNewPrzyklad2()
        {
            OverLoadingExampleToTaBazowa przyklad_2 = new OverridingExampleToTaKtoraDziedziczy();
            przyklad_2.NieVirtualnaMetoda();
        }
        //P.3 
        //ODPOWIEDZ - Overloading klasa bazowa
        [TestMethod]
        public void MetodaDebugujacaOverridingBrakVirtualaBezNewPrzyklad3()
        {
            OverLoadingExampleToTaBazowa przyklad_3 = new OverridingExampleToTaKtoraDziedziczy();
            ((OverLoadingExampleToTaBazowa)przyklad_3).NieVirtualnaMetoda();  
        }
        //P.4 
        //ODPOWIEDZ - Overloading klasa bazowa
        [TestMethod]
        public void MetodaDebugujacaOverridingBrakVirtualaBezNewPrzyklad4()
        {
            OverridingExampleToTaKtoraDziedziczy przyklad_4 = new OverridingExampleToTaKtoraDziedziczy();
            ((OverLoadingExampleToTaBazowa)przyklad_4).NieVirtualnaMetoda();

        }
        //P.5 
        //ODPOWIEDZ - Overriding klasa dziedziczaca
        [TestMethod]
        public void MetodaDebugujacaOverridingBrakVirtualaBezNewPrzyklad5()
        {
            OverridingExampleToTaKtoraDziedziczy przyklad_4 = new OverridingExampleToTaKtoraDziedziczy();
            przyklad_4.NieVirtualnaMetoda();

        }

        //________________________________________-
        //________________________________________-
        //________________________________________-
        //________________________________________-

        //Seria testów z brakiem wirtualnej metody w klasie bazowej ale z tą metodą przesłonietą w klasie dziedziczącej ze SŁÓWKIEM >>>NEW<<<
        //czyli w bazowej public int NiejestemVirtualAleMamNew(), a w dziedziczacej public new int NiejestemVirtualAleMamNew();
        //P.1 
        //ODPOWIEDZ - overloading klasowa bazowa
        [TestMethod]
        public void MetodaDebugujacaOverridingBrakVirtualaZNewPrzyklad1()
        {
            OverLoadingExampleToTaBazowa przyklad_1 = new OverLoadingExampleToTaBazowa();
            przyklad_1.NiejestemVirtualAleMamNew();
        }
        //P.2
        //ODPOWIEDZ- klasa bazowa
        [TestMethod]
        public void MetodaDebugujacaOverridingBrakVirtualaZNewPrzyklad2()
        {
            OverLoadingExampleToTaBazowa przyklad_2 = new OverridingExampleToTaKtoraDziedziczy();
            przyklad_2.NiejestemVirtualAleMamNew();
        }
        //P.3 
        //ODPOWIEDZ - Overloading klasa bazowa
        [TestMethod]
        public void MetodaDebugujacaOverridingBrakVirtualaZNewPrzyklad3()
        {
            OverLoadingExampleToTaBazowa przyklad_3 = new OverridingExampleToTaKtoraDziedziczy();
            ((OverLoadingExampleToTaBazowa)przyklad_3).NiejestemVirtualAleMamNew();
        }
        //P.4 
        //ODPOWIEDZ - Overloading klasa bazowa
        [TestMethod]
        public void MetodaDebugujacaOverridingBrakVirtualaZNewPrzyklad4()
        {
            OverridingExampleToTaKtoraDziedziczy przyklad_4 = new OverridingExampleToTaKtoraDziedziczy();
            ((OverLoadingExampleToTaBazowa)przyklad_4).NiejestemVirtualAleMamNew();

        }
        //P.5 
        //ODPOWIEDZ - Overriding klasa dziedziczaca
        [TestMethod]
        public void MetodaDebugujacaOverridingBrakVirtualaZNewPrzyklad5()
        {
            OverridingExampleToTaKtoraDziedziczy przyklad_4 = new OverridingExampleToTaKtoraDziedziczy();
            przyklad_4.NiejestemVirtualAleMamNew();

        }


        //________________________________________-
        //________________________________________-
        //________________________________________-
        //________________________________________-

        //Seria testów z wirtualna metody w klasie bazowej ale z tą metodą przesłonietą w klasie dziedziczącej ze SŁÓWKIEM >>>NEW<<< bez OVERRIDE
        //czyli w bazowej public virtual int NiejestemVirtual(), a w dziedziczacej public new int NiejestemVirtual();

        //P.1 
        //ODPOWIEDZ - overloading klasowa bazowa
        [TestMethod]
        public void MetodaDebugujacaOverridingVirtualZNewPrzyklad1()
        {
            OverLoadingExampleToTaBazowa przyklad_1 = new OverLoadingExampleToTaBazowa();
            przyklad_1.JestemVirtualIMamNewWKlasieDziedziczacej();
        }
        //P.2
        //ODPOWIEDZ- klasa bazowa
        [TestMethod]
        public void MetodaDebugujacaOverridingVirtualZNewPrzyklad2()
        {
            OverLoadingExampleToTaBazowa przyklad_2 = new OverridingExampleToTaKtoraDziedziczy();
            przyklad_2.JestemVirtualIMamNewWKlasieDziedziczacej();
        }
        //P.3 
        //ODPOWIEDZ - Overloading klasa bazowa
        [TestMethod]
        public void MetodaDebugujacaOverridingVirtualZNewPrzyklad3()
        {
            OverLoadingExampleToTaBazowa przyklad_3 = new OverridingExampleToTaKtoraDziedziczy();
            ((OverLoadingExampleToTaBazowa)przyklad_3).JestemVirtualIMamNewWKlasieDziedziczacej();
        }
        //P.4 
        //ODPOWIEDZ - Overloading klasa bazowa
        [TestMethod]
        public void MetodaDebugujacaOverridingVirtualZNewPrzyklad4()
        {
            OverridingExampleToTaKtoraDziedziczy przyklad_4 = new OverridingExampleToTaKtoraDziedziczy();
            ((OverLoadingExampleToTaBazowa)przyklad_4).JestemVirtualIMamNewWKlasieDziedziczacej();

        }
        //P.5 
        //ODPOWIEDZ - Overriding klasa dziedziczaca
        [TestMethod]
        public void MetodaDebugujacaOverridingVirtualZNewPrzyklad5()
        {
            OverridingExampleToTaKtoraDziedziczy przyklad_4 = new OverridingExampleToTaKtoraDziedziczy();
            przyklad_4.JestemVirtualIMamNewWKlasieDziedziczacej();

        }
        // CWICZENIE DEBUGOWANIA OVERLOADINGOW
        [TestMethod]
        public void MetodaDebugujacaOverloading()
        {
            OverLoadingExampleToTaBazowa klasaPrzeciazajaca = new OverLoadingExampleToTaBazowa();
            klasaPrzeciazajaca.MetodaDoPrzeciazenia();
        }
    }
}
