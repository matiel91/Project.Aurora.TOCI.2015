using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Aurora.TOCI._2015.OverridingTraining
{
    public class OverLoadingExampleToTaBazowa
    {
        public OverLoadingExampleToTaBazowa()
        {
            //this.KlasaKtoraMozeBycOverriden();
            
            Debug.WriteLine("Wywolalem sie w konstruktorze po this");
        }
        public OverLoadingExampleToTaBazowa(int s) : this() //zawsze wykonane to co w glownym konstruktorze napierw
        {
            s = 10;
        }

        public int MetodaDoPrzeciazenia()
        {
            OverLoadingExampleToTaBazowa przykladprzeciazenia = new OverLoadingExampleToTaBazowa();
            przykladprzeciazenia.MetodaDoPrzeciazenia(test2: "Przykladowy tekst");
            return 0;
        }

        private int MetodaDoPrzeciazenia(string test2)
        {
            return 0;
        }

        private int MetodaDoPrzeciazenia(double test = 1.22, string test2 = "Tekst Defaultowy Konstruktora Klasy Overloading example", int parametr = 43)
        {
            return 0;
        }


        ////  Przykklady przeciazen powyzej potrzebne beda do cwiczen debugowania-------------------------------------------------------
        /////
        /// Ponizsze to juz raczej chyba do cwiczenia przeslaniania

        public virtual void KlasaKtoraMozeBycOverriden()
        {
            Debug.Write("Zatrzymalem sie w virtual ,,,,");
        }

        public string NieVirtualnaMetoda()
        {
            return "Metoda nievirtualna w klasie bazowej";
        }

        public string NiejestemVirtualAleMamNew()
        {
            Debug.WriteLine("Klasa bazowa -  NiejestemVirtualAleMamNew()");
            return "Metoda nievirtualna w klasie bazowej";
        }

        public virtual string JestemVirtualIMamNewWKlasieDziedziczacej()
        {
            Debug.WriteLine("Klasa bazowa -  JestemVirtualIMamNewWKlasieDziedziczacej()");
            return "Metoda virtualna w klasie bazowej";
        }



        public virtual string KlasaKtoraMozeBycOverridenZwracajacaSTRING()
        {
            return "Wartosc z metody bazowej mozemy przypisac sobie do zmiennej"; 
        }

        public void MetodaKtoraJestDostepnaTylkoZPoziomuKlasyBazowej()
        {
            
        }
    }
}
