using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project.Aurora.TOCI._2015.DelegatesTraining;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Aurora.Tests
{
    [TestClass]
    public class DelegatTesty
    {
        [TestMethod]
        public void PierwszyTestDelegata()
        {
            DelegateExampleBasics deb = new DelegateExampleBasics();
            deb.PierwszyTestDelegata();
        }

        [TestMethod]
        public void TestDelegateZParametrem()
        {
            DelegatesWithParametersConceptCheck dwpcc = new DelegatesWithParametersConceptCheck();
            var result = dwpcc.RunDelegate();
        }
    }
}
