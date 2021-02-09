using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Aurora.Tests.Codewars_tests
{
    [TestClass]
    public class TestsForCubesTask
    {
        [TestMethod]
        public void CubesMethodDebugginh()
        {
            Cubes.isSumOfCubes("0 9026315 -827&()");
        }
        [TestMethod]
        public void Test1()
        {
            string s = "0 9026315 -827&()"; // "0 0 Lucky"
            String r = "0 0 Lucky";
            Assert.AreEqual(r, Cubes.isSumOfCubes(s));
        }
    }
}
