using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Aurora.TOCI._2015.OverridingTraining
{
    public class OverridingExampleToTaKtoraDziedziczy : OverLoadingExampleToTaBazowa
    {
        public OverridingExampleToTaKtoraDziedziczy()
        {
            //base.KlasaKtoraMozeBycOverriden();
            Debug.WriteLine("konstruktor tej ktora dziedziczy");
            //KlasaKtoraMozeBycOverriden();
            //this.KlasaKtoraMozeBycOverriden();
        }

        public override void KlasaKtoraMozeBycOverriden()
        {
            //Linijka ponizej zkaomentowana na potrzebe przykladu do pozniejszego debugowania
            //base.KlasaKtoraMozeBycOverriden(); // to wywoluje bazowa logike ale do tego mozemy dopisac jeszcze dodatkowa logike
            Debug.WriteLine("Wywolane w overridingexampletenktorydziedzczy");
        }

        public string NieVirtualnaMetoda()
        {
            return "Metoda nievirtualna w klasie dziedziczacej";
        }

        public new string NiejestemVirtualAleMamNew()
        {
            Debug.WriteLine("Klasa dziedziczaca -  NiejestemVirtualAleMamNew()");
            return "Metoda nievirtualna w klasie dziedziczacejj";
        }

        public new string JestemVirtualIMamNewWKlasieDziedziczacej()
        {
            Debug.WriteLine("Klasa dziedziczaca -  JestemVirtualIMamNewWKlasieDziedziczacej()");
            return "Metoda virtualna w klasie dziedziczacej";
        }

        public override string KlasaKtoraMozeBycOverridenZwracajacaSTRING()
        {
            string wartoscZMetodyBazowej =  base.KlasaKtoraMozeBycOverridenZwracajacaSTRING();

            return wartoscZMetodyBazowej + " Cos dodane w metodzie ktora overriduje";
        }
    }
}
