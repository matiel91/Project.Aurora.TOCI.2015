using CodeWars.Excersize.Lazy_Repeater;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Aurora.Tests.Codewars_tests
{
    [TestClass]
    public class TestsForRepeaterLooperTask
    {
        [TestMethod]
        public void WhatIsThisShitActuallyDoing()
        {
            //objekt ktory jest metoda klasy kata, kazde jego wywolanie result() wywoluje ten func. 
            // w tym funcu jest iterator ktory jest na stale przypisany do result(bo przeciez to instancja) i dlatego po kazdym wywolaniu mamy inna litere
            var result  = Kata.MakeLooper("string");
            var a = result();
            var b = result();
            var c = result();
        }
    }
}
