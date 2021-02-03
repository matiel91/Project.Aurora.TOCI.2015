using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Aurora.Tasks.TaskTrainingThreeSolution;

namespace Project.Aurora.Tests
{
    [TestClass]
    public class BankTaskTests
    {
        [TestMethod]
        public void ReturnListOfBankTransfersDebugging()
        {
            MatBankTransferParser mbtp = new MatBankTransferParser();
            var result = mbtp.GetBankTransfers();
        }
    }
}
