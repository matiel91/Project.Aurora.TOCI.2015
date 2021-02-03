using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project.Aurora.TOCI._2015.LINQ_JoinTraining;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Aurora.Tests
{
    [TestClass]
    public class LinqTests
    {
        [TestMethod]
        public void RunLinqTest()
        {
            BasicPlayWithLinq bpwl = new BasicPlayWithLinq();
            
            bpwl.RunLinqDefferedExecution();

        }
        [TestMethod]
        public void RunLinqTest2()
        {
            BasicPlayWithLinq bpwl = new BasicPlayWithLinq();

            bpwl.RunLinqRound1();
                        
        }
        [TestMethod]
        public void RunLinqTestJoin()
        {
            BasicPlayWithLinq bpwl = new BasicPlayWithLinq();

            bpwl.JoinExcersize();

        }
        [TestMethod]
        public void RunLinqTestOtherOverloads()
        {
            BasicPlayWithLinq bpwl = new BasicPlayWithLinq();

            bpwl.Linqexcersize();

        }
    }
}
