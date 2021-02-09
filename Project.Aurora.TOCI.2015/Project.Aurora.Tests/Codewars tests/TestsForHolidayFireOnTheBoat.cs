using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeWars.Excersize.Holiday___Fire_on_the_boat;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Project.Aurora.Tests.Codewars_tests
{
    [TestClass]
    public class TestsForHolidayFireOnTheBoat
    {
        [TestMethod]
        public void BasicTests()
        {
            Assert.AreEqual("Boat Rudder Mast Boat Hull Water ~~ Boat Deck Hull ~~ Propeller Deck ~~ Deck Boat Mast", Kata.FireFight("Boat Rudder Mast Boat Hull Water Fire Boat Deck Hull Fire Propeller Deck Fire Deck Boat Mast"));
            Assert.AreEqual("Mast Deck Engine Water ~~", Kata.FireFight("Mast Deck Engine Water Fire"));
            Assert.AreEqual("~~ Deck Engine Sail Deck ~~ ~~ ~~ Rudder ~~ Boat ~~ ~~ Captain", Kata.FireFight("Fire Deck Engine Sail Deck Fire Fire Fire Rudder Fire Boat Fire Fire Captain"));
        }

    }
}
