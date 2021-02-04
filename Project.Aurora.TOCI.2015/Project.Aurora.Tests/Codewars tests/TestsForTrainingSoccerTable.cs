﻿using CodeWars.Excersize.SoccerTable;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Aurora.Tests.Codewars_tests
{
    [TestClass]
    public class TestsForTrainingSoccerTable
    {
        [TestMethod]
        public void TableUpdateDebugging() 
        {
        TableRow O1 = new TableRow() { TeamName = "United", Game = 3, Win = 2, Draw = 0, Loss = 1, Point = 6 };
        TableRow O2 = new TableRow() { TeamName = "Inter", Game = 5, Win = 2, Draw = 2, Loss = 1, Point = 8 };
        TableRow O3 = new TableRow() { TeamName = "Milan", Game = 1, Win = 0, Draw = 1, Loss = 0, Point = 1 };
        TableRow O4 = new TableRow() { TeamName = "Barcelona", Game = 1, Win = 0, Draw = 1, Loss = 0, Point = 1 };
        var OldTable = new List<TableRow>() { O1, O2, O3, O4 };
        Kata.InjectNewResult("Milan 2:2 Inter", OldTable);

        }
        [TestMethod]
        public void ResultStringParseDebuging ()
        {
            string test = "Milan 2:2 Inter";
            Kata.ParseResultFromString(test);

        }
    }

    [TestFixture]
    public class SoccerTest
    {
        [Test]
        public void ResultTest1()
        {
            TableRow O1 = new TableRow() { TeamName = "Arsenal", Game = 3, Win = 2, Draw = 0, Loss = 1, Point = 6 };
            TableRow O2 = new TableRow() { TeamName = "City", Game = 5, Win = 2, Draw = 2, Loss = 1, Point = 8 };
            TableRow O3 = new TableRow() { TeamName = "Rome", Game = 1, Win = 0, Draw = 1, Loss = 0, Point = 1 };
            var OldTable = new List<TableRow>() { O1, O2, O3 };
            string NewResult = "Arsenal 0:2 Rome";
            TableRow N1 = new TableRow() { TeamName = "Arsenal", Game = 4, Win = 2, Draw = 0, Loss = 2, Point = 6 };
            TableRow N2 = new TableRow() { TeamName = "City", Game = 5, Win = 2, Draw = 2, Loss = 1, Point = 8 };
            TableRow N3 = new TableRow() { TeamName = "Rome", Game = 2, Win = 1, Draw = 1, Loss = 0, Point = 4 };
            List<TableRow> NewTable = new List<TableRow>() { N1, N2, N3 };

            NUnit.Framework.CollectionAssert.AreEqual(NewTable, Kata.InjectNewResult(NewResult, OldTable));
        }

        [Test]
        public void ResultTest2([Values(1)] int x, [Random(-1, 1, 5)] double d)
        {
            TableRow O1 = new TableRow() { TeamName = "United", Game = 3, Win = 2, Draw = 0, Loss = 1, Point = 6 };
            TableRow O2 = new TableRow() { TeamName = "Inter", Game = 5, Win = 2, Draw = 2, Loss = 1, Point = 8 };
            TableRow O3 = new TableRow() { TeamName = "Milan", Game = 1, Win = 0, Draw = 1, Loss = 0, Point = 1 };
            TableRow O4 = new TableRow() { TeamName = "Barcelona", Game = 1, Win = 0, Draw = 1, Loss = 0, Point = 1 };
            var OldTable = new List<TableRow>() { O1, O2, O3, O4 };
            string NewResult = "Milan 2:2 Inter";
            TableRow N1 = new TableRow() { TeamName = "United", Game = 3, Win = 2, Draw = 0, Loss = 1, Point = 6 };
            TableRow N2 = new TableRow() { TeamName = "Inter", Game = 6, Win = 2, Draw = 3, Loss = 1, Point = 9 };
            TableRow N3 = new TableRow() { TeamName = "Milan", Game = 2, Win = 0, Draw = 2, Loss = 0, Point = 2 };
            TableRow N4 = new TableRow() { TeamName = "Barcelona", Game = 1, Win = 0, Draw = 1, Loss = 0, Point = 1 };
            List<TableRow> NewTable = new List<TableRow>() { N1, N2, N3, N4 };

            NUnit.Framework.CollectionAssert.AreEqual(NewTable, Kata.InjectNewResult(NewResult, OldTable));
        }
    }
}
