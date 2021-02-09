
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project.Aurora.Tasks.TaskTrainingThreeSolution;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Aurora.Tests
{
    [TestClass]
    public class LookingForProperPath
    {
        [TestMethod]
        public void TestForPath()
        {
            MatFileOperation.GetCurentCatalog();
        }

        [TestMethod]
        public void TestForPath2()
        {
            MatFileOperation mfo = new MatFileOperation();
            mfo.GetFileContent("@\\..\\..\\Project.Aurora.Task\\TaskTrainingThreeSolution\\Files\\randomdata4.csv");
            Debug.WriteLine(mfo.FileContent);
        }

        [TestMethod]
        public void TestForDividingForLinesMethod()
        {
            MatFileOperation mfo = new MatFileOperation();
            mfo.GetFileContent("@\\..\\..\\Project.Aurora.Task\\TaskTrainingThreeSolution\\Files\\randomdata4.csv");
            var test = mfo.CutTheStringByNewLine(mfo.FileContent);
            Debug.WriteLine(mfo.FileContent);
        }
    }
}
